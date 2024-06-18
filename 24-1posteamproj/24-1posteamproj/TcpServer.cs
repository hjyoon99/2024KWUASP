using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using System.IO;

public class TcpServer
{
    private TcpListener listener;
    private Thread serverThread;
    private TextBox serverLogTextBox;
    private TextBox orderLogTextBox;
    private int port;

    public TcpServer(TextBox serverLogTextBox, TextBox orderLogTextBox, int port)
    {
        this.serverLogTextBox = serverLogTextBox;
        this.orderLogTextBox = orderLogTextBox;
        this.port = port;
    }

    public void Start()
    {
        serverThread = new Thread(new ThreadStart(RunServer));
        serverThread.IsBackground = true;
        serverThread.Start();
    }

    public void Stop()
    {
        if (listener != null)
        {
            listener.Stop();
        }
        if (serverThread != null && serverThread.IsAlive)
        {
            serverThread.Abort();
        }
    }

    private void RunServer()
    {
        listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        UpdateServerLog("클라이언트의 연결을 기다리는 중...");

        while (true)
        {
            try
            {
                TcpClient client = listener.AcceptTcpClient();
                UpdateServerLog("클라이언트가 연결되었습니다.");

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                ProcessReceivedData(receivedData);

                client.Close();
            }
            catch (Exception ex)
            {
                UpdateServerLog(ex.Message);
            }
        }
    }

    private void ProcessReceivedData(string data)
    {
        if (data.StartsWith("PHONE_NUMBER:"))
        {
            string phoneNumber = data.Replace("PHONE_NUMBER:", "");
            UpdateOrderLog("수신된 전화번호: \n" + phoneNumber);
        }
        else if (data.StartsWith("ORDER_DATA:"))
        {
            string orderData = data.Replace("ORDER_DATA:", "");
            UpdateOrderLog("수신된 주문 데이터:\r\n" + orderData.TrimStart(','));
            AddOrderToSales(orderData);
        }
    }

    private void UpdateServerLog(string message)
    {
        if (serverLogTextBox.InvokeRequired)
        {
            serverLogTextBox.Invoke(new Action<string>(UpdateServerLog), message);
        }
        else
        {
            serverLogTextBox.AppendText(message + Environment.NewLine);
        }
    }

    private void UpdateOrderLog(string message)
    {
        if (orderLogTextBox.InvokeRequired)
        {
            orderLogTextBox.Invoke(new Action<string>(UpdateOrderLog), message);
        }
        else
        {
            orderLogTextBox.AppendText(message + Environment.NewLine);
        }
    }

    private void AddOrderToSales(string msg) // 데이터베이스에 주문 기록 저장
    {
        DataSet ds = new DataSet();
        ds.ReadXml(Directory.GetCurrentDirectory() + @"\sales.xml");
        DataRow dr1 = ds.Tables["ORDER"].NewRow();
        string[] msgLine = msg.Split('\n');
        int orderNum = int.Parse(ds.Tables["ORDER"].Rows[ds.Tables["ORDER"].Rows.Count - 1][0].ToString()) + 1;
        dr1["NUMBER"] = orderNum.ToString();
        DateTime timeStamp = DateTime.Now;
        string strTime = timeStamp.ToString("yyyy-MM-dd HH:mm");
        dr1["TIME"] = strTime;
        ds.Tables["ORDER"].Rows.Add(dr1);
        ds.Tables["ORDER"].AcceptChanges();
        for (int i = 0; i < msgLine.Length - 1; i++)
        {
            string line = msgLine[i];
            DataRow dr2 = ds.Tables["DETAIL"].NewRow();
            dr2["NUMBER"] = orderNum.ToString();
            string[] temp1 = line.Split(':');
            string menu = temp1[0];
            string[] temp2 = temp1[1].Split(',');
            string amount = temp2[1];
            string price = temp2[2];
            dr2["ITEM"] = menu;
            dr2["COUNT"] = amount;
            dr2["PRICE"] = price;
            ds.Tables["DETAIL"].Rows.Add(dr2);
            ds.Tables["DETAIL"].AcceptChanges();
        }
        ds.WriteXml(Directory.GetCurrentDirectory() + @"\sales.xml");
    }
}

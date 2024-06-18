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
    public string memberPhone = "none";

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
            memberPhone = phoneNumber;
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
        bool pointAddRequired = false;
        DataTable dt = new DataTable();
        string targetPhone = "";
        if (memberPhone != "none" && memberPhone.Length == 11)
        {
            DataSet pds = new DataSet();
            pds.ReadXml(Directory.GetCurrentDirectory() + @"\members.xml");
            dt = pds.Tables["MEMBER"];
            string tel1 = memberPhone.Substring(0, 3);
            string tel2 = memberPhone.Substring(3, 4);
            string tel3 = memberPhone.Substring(7, 4);
            targetPhone = tel1+"-"+tel2+"-"+tel3;
            DataRow[] drs = dt.Select("[PHONE] = '" + targetPhone + "'");
            if(drs.Length == 0)
            {
                pointAddRequired = false;
                memberPhone = "none";
            }
            else
            {
                pointAddRequired= true;
            }
        }
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
        int totalPrice = 0;
        for (int i = 0; i < msgLine.Length - 1; i++)
        {
            string line = msgLine[i].TrimStart(',');
            DataRow dr2 = ds.Tables["DETAIL"].NewRow();
            dr2["NUMBER"] = orderNum.ToString();
            string[] temp1 = line.Split(':');
            string menu = temp1[0];
            string[] temp2 = temp1[1].Split(',');
            string amount = temp2[1];
            string price = temp2[2];
            totalPrice += int.Parse(price);
            dr2["ITEM"] = menu;
            dr2["COUNT"] = amount;
            dr2["PRICE"] = price;
            ds.Tables["DETAIL"].Rows.Add(dr2);
            ds.Tables["DETAIL"].AcceptChanges();
        }
        ds.WriteXml(Directory.GetCurrentDirectory() + @"\sales.xml");
        if (pointAddRequired)
        {
            foreach(DataRow dr in dt.Rows)
            {
                if (dr["PHONE"].ToString() == targetPhone)
                {
                    int prev = int.Parse(dr["POINT"].ToString());
                    prev += (totalPrice / 10);
                    dr["POINT"] = prev.ToString();
                    dt.WriteXml(Directory.GetCurrentDirectory() + @"\members.xml");
                }
            }
            
        }
        memberPhone = "none";
    }
}

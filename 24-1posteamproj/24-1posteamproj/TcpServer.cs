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
        UpdateServerLog("서버가 시작되었습니다. 클라이언트의 연결을 기다리는 중...");

        while (true)
        {
            try
            {
                TcpClient client = listener.AcceptTcpClient();
                UpdateServerLog("클라이언트가 연결되었습니다.");

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string orderData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                UpdateOrderLog("수신된 데이터: \r\n" + orderData);

                client.Close();
            }
            catch (Exception ex)
            {
                UpdateServerLog("서버 오류: " + ex.Message);
            }
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
        /*
        DataSet ds = new DataSet();
        ds.ReadXml(Directory.GetCurrentDirectory() + @"\sales.xml");
        */
        string[] spl = msg.Split(':');
    }
}

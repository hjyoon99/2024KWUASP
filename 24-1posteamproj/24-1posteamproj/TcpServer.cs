using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

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

    private void StokChangebyOrder(string msg)
    {
        string filePath = Directory.GetCurrentDirectory() + @"\재고관리.xlsx";
        string Ordermenu;
        string OrderCount;

        Excel.Application excelApp = new Excel.Application();
        Excel.Workbook workbook = excelApp.Workbooks.Open(filePath, ReadOnly: false, Editable: true);
        Excel.Worksheet worksheet = workbook.Worksheets[1];
        Excel.Range range = worksheet.UsedRange;


        int rowCount = range.Rows.Count;
        int colCount = range.Columns.Count;

        string[] Ordermsg = msg.Split('\n');
        for (int i = 0; i < Ordermsg.Length - 1; i++)
        {
            string line = Ordermsg[i];
            string[] Name = line.Split(':');
            Ordermenu = Name[0];
            string[] MenuAmount = Name[1].Split(',');
            OrderCount = MenuAmount[1];

            for (int j = 2; j <= rowCount; j++)
            {
                if (Ordermenu == worksheet.Cells[j, 0].Value)
                {
                    int NowCount = int.Parse(worksheet.Cells[j, 1]);
                    int Ordercount = int.Parse(OrderCount);
                    int result = NowCount - Ordercount;
                    worksheet.Cells[j, 1].Value = Convert.ToString(result);
                }
            }

        }
        workbook.Save();
        workbook.Close(false);
        excelApp.Quit();
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

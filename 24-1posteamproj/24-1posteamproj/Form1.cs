using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_1posteamproj
{
    public partial class mainForm : Form
    {
        private TcpServer server;
        private int serverPort = 12345; // 서버 포트 번호
        private bool isServerRunning = false;

        MenuForm mf=new MenuForm();
        StokForm stk=new StokForm();
        MemberForm mForm = new MemberForm();
        salesForm sForm = new salesForm();

        public mainForm()
        {
            InitializeComponent();
    }

        public void Form1_Load(object sender, EventArgs e)
        {
            timer_curTime.Start();
        }
        public void timer_curTime_Tick(object sender, EventArgs e)
        { 

            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mf.ShowDialog();
            this.Show();
            
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            stk.ShowDialog();
            this.Show();
        }
        private void btnMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            mForm.ShowDialog();
            this.Show();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            sForm.ShowDialog();
            this.Show();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (!isServerRunning)
            {
                if (server == null)
                {
                    server = new TcpServer(serverLog, orderLog, serverPort);
                    server.Start();
                    serverLog.AppendText("서버가 시작되었습니다." + Environment.NewLine);
                    btnOnOff.Text = "서버 중지";
                    isServerRunning = true;
                }
            }
            else
            {
                if (server != null)
                {
                    server.Stop();
                    serverLog.AppendText("서버가 중지되었습니다." + Environment.NewLine);
                    btnOnOff.Text = "서버 시작";
                    server = null;
                    isServerRunning = false;
                }
            }
        }
    }
}

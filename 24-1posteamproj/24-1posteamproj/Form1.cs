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
        MenuForm mf=new MenuForm();
        StokForm stk=new StokForm();
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_curTime.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void timer_curTime_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            mf.Show();
            this.Visible=false;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            stk.Show();
            this.Visible = false;
        }
    }
}

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
    public partial class MenuForm : Form
    {
        
        public MenuForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimerDate.Text = DateTime.Now.ToLongDateString();
            TimerTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        { 
            this.Close();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
        }

        private void Gimbab1_Click(object sender, EventArgs e)
        {
            MenuName.Text = Gimbab1.Text;
        }

        private void Gimbab2_Click(object sender, EventArgs e)
        {
            MenuName.Text=Gimbab2.Text;

        }

        private void Gimbab3_Click(object sender, EventArgs e)
        {
            MenuName.Text = Gimbab3.Text;
        }

        private void Gimbab4_Click(object sender, EventArgs e)
        {
            MenuName.Text = Gimbab4.Text;
        }

        private void Gimbab5_Click(object sender, EventArgs e)
        {
            MenuName.Text=Gimbab5.Text;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string name=MenuName.Text;
            if(name != null)
            {
                if (name == Gimbab1.Text)
                {
                    Gimbab1.Enabled = false;
                }
                if(name == Gimbab2.Text)
                {
                    Gimbab2.Enabled = false;
                }
                if (name == Gimbab3.Text)
                {
                  Gimbab3.Enabled = false; 
                }
                if( name == Gimbab4.Text)
                {
                    Gimbab4.Enabled = false;
                }if(name == Gimbab5.Text)
                {
                    Gimbab5.Enabled = false;
                }
            }
        }
    }
}

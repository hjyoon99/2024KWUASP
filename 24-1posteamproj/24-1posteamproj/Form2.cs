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
    }
}

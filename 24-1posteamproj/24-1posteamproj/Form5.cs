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
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void WhenItemSelected(object sender, EventArgs e)
        {
            if (lvSales.SelectedItems.Count != 0)
            {
                btnRefund.Enabled = true;
            }
            else
            {
                btnRefund.Enabled= false;
            }
        }
        private void handleDateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate.Text = calender.SelectionStart.ToShortDateString();
        }
        private void openMainForm(object sender, EventArgs e)
        {
            this.Close();
        }
        public void timer_curTime_Tick(object sender, EventArgs e)
        {

            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

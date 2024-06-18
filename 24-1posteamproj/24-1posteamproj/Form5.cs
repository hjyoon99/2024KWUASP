using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        DataSet ds = new DataSet();
        string path = Directory.GetCurrentDirectory() + @"\sales.xml";
        DateTime targetTime = DateTime.Now;
        bool salesPerDateMod = false;

        private void HandleRefundBtn(object sender, EventArgs e)
        {
            string targetNumber = lvSales.SelectedItems[0].Text;
            DataRow[] drs1 = ds.Tables["ORDER"].Select("NUMBER = " + targetNumber);
            DataRow[] drs2 = ds.Tables["DETAIL"].Select("NUMBER = " + targetNumber);
            ds.Tables["ORDER"].Rows.Remove(drs1[0]);
            foreach (DataRow dr in drs2)
            {
                ds.Tables["DETAIL"].Rows.Remove(dr);
            }
            MessageBox.Show("환불처리가 완료되었습니다.");
            ds.WriteXml(path);
            LoadXml();
        }
        private void DefaultSales(object sender, EventArgs e)
        {
            if (salesPerDateMod)
            {
                salesPerDateMod = false;
            }
            LoadXml();
        }
        private void SalesPerDate(object sender, EventArgs e)
        {
            salesPerDateMod = true;
            ShowSalesPerDate();
        }
        private void ShowSalesPerDate()
        {
            DataRow[] drs1 = ds.Tables["ORDER"].Select("[TIME] LIKE '%" + targetTime.ToShortDateString() + "%'");
            if (drs1.Length == 0)
            {
                MessageBox.Show("해당 날짜에 매출이 존재하지 않습니다.");
                return;
            }
            lvSales.BeginUpdate();
            lvSales.Items.Clear();
            int totalSales = 0;
            foreach (DataRow row in drs1)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                DataRow[] drs = ds.Tables["DETAIL"].Select("NUMBER = " + row[0].ToString());
                string items = "";
                int price = 0;
                foreach (DataRow dr in drs)
                {
                    items += dr[1] + " " + dr[2] + ",";
                    price += int.Parse(dr[3].ToString());
                }
                totalSales += price;
                item.SubItems.Add(items.Remove(items.LastIndexOf(",")));
                item.SubItems.Add(price.ToString());
                lvSales.Items.Add(item);
            }
            lvSales.EndUpdate();
            lbTotalSales.Text = totalSales.ToString();
            lbTargetDate.Text = targetTime.Year.ToString() + "년 " + targetTime.Month.ToString() + "월 " + targetTime.Day.ToString() + "일 총 매출:";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadXml();
        }
        private void WhenItemSelected(object sender, EventArgs e)
        {

        }
        private void handleDateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate.Text = calender.SelectionStart.ToShortDateString();
            targetTime = calender.SelectionStart;
            if (salesPerDateMod)
            {
                ShowSalesPerDate();
            }
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
        private void LoadXml()
        {
            DataSet dsLoad = new DataSet();
            dsLoad.ReadXml(path);
            ds = dsLoad;
            lvSales.BeginUpdate();
            lvSales.Items.Clear();
            int totalSales = 0;
            foreach(DataRow row in ds.Tables["ORDER"].Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                DataRow[] drs = ds.Tables["DETAIL"].Select("NUMBER = " + row[0].ToString());
                string items = "";
                int price = 0;
                foreach(DataRow dr in drs)
                {
                    items += dr[1] + " " + dr[2] + ",";
                    price += int.Parse(dr[3].ToString());
                    totalSales += price;
                }
                item.SubItems.Add(items.Remove(items.LastIndexOf(",")));
                item.SubItems.Add(price.ToString());
                lvSales.Items.Add(item);
            }
            lvSales.EndUpdate();
            lbTargetDate.Text = "총 매출액: ";
            lbTotalSales.Text = totalSales.ToString();
        }
    }
}

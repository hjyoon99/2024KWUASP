using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        bool salesPerTimeMod = false;
        bool salesPerMenuMod = false;

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
            salesPerDateMod = false;
            salesPerTimeMod = false;
            salesPerMenuMod = false;
            LoadXml();
        }
        private void SalesPerDate(object sender, EventArgs e)
        {
            salesPerDateMod = true;
            salesPerTimeMod = false;
            salesPerMenuMod = false;
            ShowSalesPerDate();
        }
        private void SalesPerTime(object sender, EventArgs e)
        {
            salesPerTimeMod = true;
            salesPerDateMod = false;
            salesPerMenuMod = false;
            ShowSalesPerTime();
        }
        private void SalesPerMenu(object sender, EventArgs e)
        {
            salesPerMenuMod = true;
            salesPerDateMod = false;
            salesPerTimeMod = false;
            ShowSalesPerMenu();
        }
        private void ShowSalesPerTime()
        {
            DataRow[] drs1 = ds.Tables["ORDER"].Select("[TIME] LIKE '%" + targetTime.ToShortDateString() + "%'");
            if (drs1.Length == 0)
            {
                MessageBox.Show("해당 날짜에 매출이 존재하지 않습니다.");
                return;
            }
            lvSales.BeginUpdate();
            lvSales.Items.Clear();
            DataTable orderTable = ds.Tables["ORDER"];
            DataTable detailTable = ds.Tables["DETAIL"];
            int DateSales = 0;
            DataRelation rel = new DataRelation("OrderDetail", orderTable.Columns["NUMBER"], detailTable.Columns["NUMBER"]);
            ds.Relations.Add(rel);
            Dictionary<int, decimal> hourlySales = new Dictionary<int, decimal>();
            for(int i = 0; i < 24; i++)
            {
                hourlySales[i] = 0;
            }
            foreach(DataRow row in drs1)
            {
                DateTime oTime = DateTime.Parse(row["TIME"].ToString());
                int orderHour = oTime.Hour;

                DataRow[] detailRows = row.GetChildRows(rel);
                decimal totalSales = detailRows.Sum(detailRow => decimal.Parse(detailRow["PRICE"].ToString()));
                hourlySales[orderHour] = totalSales;
                DateSales += (int)totalSales;
            }
            foreach (var entry in hourlySales)
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add($"{entry.Key}:00 ~ {entry.Key}:59");
                item.SubItems.Add(entry.Value.ToString());
                lvSales.Items.Add(item);
            }
            lvSales.EndUpdate();
            ds.Relations.Remove(rel);
            lbTargetDate.Text = targetTime.Year.ToString() + "년 " + targetTime.Month.ToString() + "월 " + targetTime.Day.ToString() + "일 총 매출:";
            lbTotalSales.Text = DateSales.ToString();
        }
        private void ShowSalesPerMenu()
        {
            DataRow[] drs = ds.Tables["ORDER"].Select("[TIME] LIKE '%"+targetTime.Year.ToString()+"-"+targetTime.ToString("MM")+"%'");
            if(drs.Length == 0)
            {
                MessageBox.Show("해당 월에 매출이 존재하지 않습니다.");
                return;
            }
            lvSales.BeginUpdate();
            lvSales.Items.Clear();
            DataTable orderTable = ds.Tables["ORDER"];
            DataTable detailTable = ds.Tables["DETAIL"];
            DataRelation rel = new DataRelation("OrderDetail", orderTable.Columns["NUMBER"], detailTable.Columns["NUMBER"]);
            ds.Relations.Add(rel);
            Dictionary<string, decimal> itemSales = new Dictionary<string, decimal>();
            foreach(DataRow row in drs)
            {
                DataRow[] drs2 = row.GetChildRows(rel);
                foreach(DataRow drow in drs2)
                {
                    string item = drow["ITEM"].ToString();
                    decimal price = decimal.Parse(drow["PRICE"].ToString());
                    if (!itemSales.ContainsKey(item))
                    {
                        itemSales[item] = 0;
                    }
                    itemSales[item] += price;
                }
            }
            foreach(var entry in itemSales)
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add("");
                item.SubItems.Add(entry.Key);
                item.SubItems.Add(entry.Value.ToString());
                lvSales.Items.Add(item);
            }
            lvSales.EndUpdate();
            ds.Relations.Remove(rel);
            lbTargetDate.Text = targetTime.Year.ToString() + "년 " + targetTime.Month.ToString() + "월 품목별 매출 현황";
            lbTotalSales.Text = "";
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
            }else if (salesPerTimeMod)
            {
                ShowSalesPerTime();
            }else if (salesPerMenuMod)
            {
                ShowSalesPerMenu();
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

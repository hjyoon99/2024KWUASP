using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace _24_1posteamproj
{
    public partial class StokForm : Form

    {
        string filePath = Directory.GetCurrentDirectory() + @"\재고관리.xlsx";

        public StokForm()
        {
            InitializeComponent();
        }


        public void LoadExcelData(string filePath, ListView listview)
        {
            Excel.Application excelApp=new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Worksheets[1];
            Excel.Range range = worksheet.UsedRange;

            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            listview.Items.Clear();

            for (int i = 2; i <= rowCount; i++)
            {
                ListViewItem item = new ListViewItem(range.Cells[i, 1].Value2.ToString());
                for (int j = 2; j <= colCount; j++)
                {
                    string cellValue=range.Cells[i, j].Value2!=null?range.Cells[i,j].Value2.ToString():string.Empty;
                    item.SubItems.Add(cellValue);
                }
                listview.Items.Add(item);
            }

            workbook.Close(false);
            excelApp.Quit();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            
            
        }

        public void SaveData(string filePath, ListView listview)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath, ReadOnly: false, Editable: true);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            excelApp.DisplayAlerts = false;


            for(int i = 0; i < listview.Items.Count; i++)
            {
                for(int j=0;j<listview.Items[i].SubItems.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =listview.Items[i].SubItems[j].Text;
                }
            }

            workbook.SaveAs(filePath);
            workbook.Close(false);
            excelApp.Quit();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
                        
            timer1.Start();
            LoadExcelData(filePath, ItemList);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer1Date.Text = DateTime.Now.ToLongDateString();
            Timer1Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            SaveData(filePath, ItemList);
            this.Close(); 

        }

        private void ItemEdit_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text != null && CountTxt.Text != null)
            {
                for (int i = 0; i < ItemList.Items.Count; i++)
                {
                    if (NameTxt.Text == ItemList.Items[i].SubItems[0].Text)
                    {
                        ItemList.Items[i].SubItems[1].Text = CountTxt.Text;
                        ItemList.Items[i].SubItems[2].Text = OtherTxt.Text;

                        break;
                    }
                    else if (i == ItemList.Items.Count - 1)
                    {
                        ListViewItem item = new ListViewItem(NameTxt.Text);
                        item.SubItems.Add(CountTxt.Text);
                        item.SubItems.Add(OtherTxt.Text);
                        ItemList.Items.Add(item);


                    }
                }

                MessageBox.Show("상품 수정이 완료되었습니다.", "수정 완료");
                NameTxt.Text = null;
                CountTxt.Text = null;
                OtherTxt.Text = null;
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if(SearchTxt.Text != null)
            {
                for(int i = 0; i < ItemList.Items.Count; i++)
                {
                    if (SearchTxt.Text == ItemList.Items[i].SubItems[0].Text)
                    {
                        NameTxt.Text = ItemList.Items[i].SubItems[0].Text;
                        CountTxt.Text = ItemList.Items[i].SubItems[1].Text;
                        OtherTxt.Text = ItemList.Items[i].SubItems[2].Text;

                        SearchTxt.Text = null;

                        return;
                    }
                }

                if (MessageBox.Show("찾으시는 상품명이 없습니다.\n상품을 추가하시겠습니까?", "검색 확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MessageBox.Show("추가할 상품의 정보 작성 후\n'재고수정' 버튼을 눌러주세요.","상품 추가");
                    NameTxt.Text = SearchTxt.Text;
                    SearchTxt.Text = null;
                }
                else
                {
                    SearchTxt.Text = null;
                }

            }
        }

        
    }

    
}

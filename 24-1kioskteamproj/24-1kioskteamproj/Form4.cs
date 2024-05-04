using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _24_1kioskteamproj
{
    public partial class Form4 : Form
    {
        System.Windows.Forms.ListView listview1;
        int table;
        int tot;
        public Form4(System.Windows.Forms.ListView listview1, int whereTable,int tot)
        {
            this.listview1 = listview1;
            InitializeComponent();
            purbox.ReadOnly = true;
            table = whereTable; 
            this.tot = tot; 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintReceipt();

        }
        private void PrintReceipt()
        {
            StringBuilder receipt = new StringBuilder();

            // 영수증 헤더
            receipt.AppendLine("===== 영수증 =====");

            // ListView의 각 항목을 반복하며 정보를 가져와서 영수증에 추가
            foreach (ListViewItem item in listview1.Items)
            {
                string start = item.SubItems[0].Text; // "start" 열의 값
                string menu = item.SubItems[1].Text; // "메뉴" 열의 값
                string quantity = item.SubItems[2].Text; // "수량" 열의 값
                string price = item.SubItems[3].Text; // "가격" 열의 값

                // 한 줄씩 영수증에 추가
                receipt.AppendLine($"{start} | {menu} | {quantity} | {price}");
            }
            receipt.AppendLine("총 금액은 " + tot + "원 입니다.");
            if (table !=0) 
            {
                receipt.AppendLine(table + "번 테이블에서 주문하였습니다.");
            }
            else
            {
                receipt.AppendLine("포장 주문입니다.");
            }

            // 영수증 하단
            receipt.AppendLine("==================");

            // TextBox에 영수증 표시
            purbox.Text = receipt.ToString();
        }
        private void purbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

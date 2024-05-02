using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_1kioskteamproj
{
    public partial class Form2 : Form
    {
        //메뉴가격
        int[] menuValue = new int[9];
        //가격 종합
        int tot;
        //label에 쓸 숫자 
        int[] count = new int[9];
        //+값에 사용할 불값
        bool[] booleanplus = new bool[9];
        bool[] booleanminus = new bool[9];
        public Form2()
        {
            //메뉴 정리
            InitializeComponent();
            InitializeMenu();
            InitializeListView();
            for(int i = 0; i < 9; i++)
            {
                count[i] = 0;
                booleanplus[i] = false;
                booleanminus[i] = false;
            }
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("start");
            listView1.Columns.Add("메뉴");
            listView1.Columns.Add("수량");
            listView1.Columns.Add("가격");
            listView1.Columns.Add("last", "last");

            listView1.Columns.RemoveByKey("last");
            listView1.Columns[0].Width = 0;
            listView1.Columns[1].Width = 200;
        }
        private void InitializeMenu()
        {
            menu6.Hide();
            menu7.Hide();
            menu8.Hide();
            menu9.Hide();
            menulabel6.Hide();
            menulabel7.Hide();
            menulabel8.Hide();
            menulabel9.Hide();
            menu1.Load(@"C:\Users\natha\g1.jpg");
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Load(@"C:\Users\natha\g2.jpg");
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Load(@"C:\Users\natha\g3.jpg");
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Load(@"C:\Users\natha\g4.jpg");
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Load(@"C:\Users\natha\g5.jpg");
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            menulabel1.Text = "일반 김밥 : 3000원";
            menulabel2.Text = "치즈 김밥 : 4000원";
            menulabel3.Text = "참치 김밥 : 4000원";
            menulabel4.Text = "날치알 김밥 : 4500원";
            menulabel5.Text = "돈가스 김밥 : 5000원";
            menuValue[0] = 3000;
            menuValue[1] = 4000;
            menuValue[2] = 4000;
            menuValue[3] = 4500;
            menuValue[4] = 5000;
            try
            {
                pictureBox1.Load(@"C:\Users\natha\gimbab.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //메뉴정리
            menu6.Hide();
            menu7.Hide();
            menu8.Hide();
            menu9.Hide();
            menulabel6.Hide();
            menulabel7.Hide();
            menulabel8.Hide();
            menulabel9.Hide();
            menu1.Load(@"C:\Users\natha\g1.jpg");
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Load(@"C:\Users\natha\g2.jpg");
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Load(@"C:\Users\natha\g3.jpg");
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Load(@"C:\Users\natha\g4.jpg");
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Load(@"C:\Users\natha\g5.jpg");
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            menulabel1.Text = "일반 김밥 : 3000원";
            menulabel2.Text = "치즈 김밥 : 4000원";
            menulabel3.Text = "참치 김밥 : 4000원";
            menulabel4.Text = "날치알 김밥 : 4500원";
            menulabel5.Text = "돈가스 김밥 : 5000원";
            menuValue[0] = 3000;
            menuValue[1] = 4000;
            menuValue[2] = 4000;
            menuValue[3] = 4500;
            menuValue[4] = 5000;

        }

        private void menu1_Click(object sender, EventArgs e)
        {
            
        }

        private void menu2_Click(object sender, EventArgs e)
        {

        }

        private void menu3_Click(object sender, EventArgs e)
        {

        }

        private void menu4_Click(object sender, EventArgs e)
        {

        }

        private void menu5_Click(object sender, EventArgs e)
        {

        }

        private void menu6_Click(object sender, EventArgs e)
        {

        }

        private void menu7_Click(object sender, EventArgs e)
        {

        }

        private void menu8_Click(object sender, EventArgs e)
        {

        }

        private void menu9_Click(object sender, EventArgs e)
        {

        }

        private void plus1_Click(object sender, EventArgs e)
        {

            count[0]++;
            count1.Text = count[0].ToString();
            ListViewItem item = new ListViewItem();

            if (booleanplus[0]==false)
            {
                item.SubItems.Add(menulabel1.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }
            else
            {
                foreach (ListViewItem itemss in listView1.Items)
                {
                    if (itemss.SubItems[1].Text == menulabel1.Text)
                    {
                        // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                        int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                        itemss.SubItems[2].Text = quantity.ToString();
                        itemss.SubItems[3].Text = (quantity * menuValue[0]).ToString();
                        
                        break;
                    }
                }
                tot += menuValue[0];
            }
            booleanplus[0] = true;
            totallabel.Text = "총 금액 : " + tot;

            
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            if(count[0] <= 0)
            {
                return;
            }
            count[0]--;
            count1.Text = count[0].ToString();
            ListViewItem item = new ListViewItem();

 
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel1.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[0]).ToString();
                    break;
                    }
                }
            tot -= menuValue[0];
            
 
            totallabel.Text = "총 금액 : " + tot;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}

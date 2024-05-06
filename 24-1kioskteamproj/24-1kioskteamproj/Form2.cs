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
        //자식폼(자리선택)
        Form3 form3 = new Form3();
        Form4 form4;
        //좌석에 앉아 먹는가?
        public bool packing = false;
        //좌석은 어디인가?
        public int whereTable = 0;
        //메뉴가격
        int[] menuValue = new int[9];
        //가격 종합
        int tot;
        //label에 쓸 숫자 
        int[] count = new int[9];
        //+값에 사용할 불값
        bool[] booleanplus = new bool[9];
        bool[] booleanminus = new bool[9];
        public Form2(bool val)
        {
            packing = val;  
            //메뉴 정리
            InitializeComponent();
            InitializeMenu();
            InitializeListView();
            form3.InformationSent += ChildForm_InformationSent;
            for (int i = 0; i < 9; i++)
            {
                count[i] = 0;
                booleanplus[i] = false;
                booleanminus[i] = false;
            }
        }

        private void ChildForm_InformationSent(object sender, int information)
        {
            whereTable = information;
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
            //best 정리
            best1.Show();
            best2.Hide();
            best3.Hide();
            best4.Hide();
            //메뉴정리
            menu1.Show();
            menu2.Show();
            menu3.Show();
            menu4.Show();
            menu5.Show();
            menu6.Hide();
            menu7.Hide();
            menu8.Hide();
            menu9.Hide();
            //메뉴라벨정리
            menulabel1.Show();
            menulabel2.Show();
            menulabel3.Show();
            menulabel4.Show();
            menulabel5.Show();
            menulabel6.Hide();
            menulabel7.Hide();
            menulabel8.Hide();
            menulabel9.Hide();
            //버튼 및 수량 정리
            plus1.Show();
            minus1.Show();

            plus2.Show();
            minus2.Show();


            plus3.Show();
            minus3.Show();


            plus4.Show();
            minus4.Show();


            plus5.Show();
            minus5.Show();

            plus6.Hide();
            minus6.Hide();


            plus7.Hide();
            minus7.Hide();


            plus8.Hide();
            minus8.Hide();


            plus9.Hide();
            minus9.Hide();

            //사진 정리
            menu1.Image = Properties.Resources.g1;
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Image = Properties.Resources.g2;
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Image = Properties.Resources.g3;
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Image = Properties.Resources.g4;
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Image = Properties.Resources.g5;
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            //메뉴정리
            menulabel1.Text = "일반 김밥 : 3000원";
            menulabel2.Text = "치즈 김밥 : 4000원";
            menulabel3.Text = "참치 김밥 : 4000원";
            menulabel4.Text = "날치알 김밥 : 4500원";
            menulabel5.Text = "돈가스 김밥 : 5000원";
            //가격 정리
            menuValue[0] = 3000;
            menuValue[1] = 4000;
            menuValue[2] = 4000;
            menuValue[3] = 4500;
            menuValue[4] = 5000;
            try
            {
                pictureBox1.Image = Properties.Resources.gimbab;
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
            //best 정리
            best1.Show();
            best2.Hide();
            best3.Hide();
            best4.Hide();
            //메뉴 정리
            menu1.Show();
            menu2.Show();
            menu3.Show();
            menu4.Show();
            menu5.Show();
            menu6.Hide();
            menu7.Hide();
            menu8.Hide();
            menu9.Hide();
            //메뉴 라벨 정리
            menulabel1.Show();
            menulabel2.Show();
            menulabel3.Show();
            menulabel4.Show();
            menulabel5.Show();
            menulabel6.Hide();
            menulabel7.Hide();
            menulabel8.Hide();
            menulabel9.Hide();
            //버튼 및 수량 정리
            plus1.Show();
            minus1.Show();


            plus2.Show();
            minus2.Show();


            plus3.Show();
            minus3.Show();


            plus4.Show();
            minus4.Show();


            plus5.Show();
            minus5.Show();


            plus6.Hide();
            minus6.Hide();


            plus7.Hide();
            minus7.Hide();


            plus8.Hide();
            minus8.Hide();


            plus9.Hide();
            minus9.Hide();

            //사진 정리
            menu1.Image = Properties.Resources.g1;
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Image = Properties.Resources.g2;
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Image = Properties.Resources.g3;
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Image = Properties.Resources.g4;
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Image = Properties.Resources.g5;
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            //메뉴정리
            menulabel1.Text = "일반 김밥 : 3000원";
            menulabel2.Text = "치즈 김밥 : 4000원";
            menulabel3.Text = "참치 김밥 : 4000원";
            menulabel4.Text = "날치알 김밥 : 4500원";
            menulabel5.Text = "돈가스 김밥 : 5000원";
            //가격 정리
            menuValue[0] = 3000;
            menuValue[1] = 4000;
            menuValue[2] = 4000;
            menuValue[3] = 4500;
            menuValue[4] = 5000;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //best 정리
            best1.Show();
            best2.Hide();
            best3.Show();
            best4.Hide();
            //메뉴 정리
            menu1.Show();
            menu2.Show();
            menu3.Show();
            menu4.Show();
            menu5.Show();
            menu6.Show();
            menu7.Show();
            menu8.Hide();
            menu9.Hide();
            //메뉴 라벨 정리
            menulabel1.Show();
            menulabel2.Show();
            menulabel3.Show();
            menulabel4.Show();
            menulabel5.Show();
            menulabel6.Show();
            menulabel7.Show();
            menulabel8.Hide();
            menulabel9.Hide();

            //버튼 및 수량 정리
            plus1.Show();
            minus1.Show();


            plus2.Show();
            minus2.Show();


            plus3.Show();
            minus3.Show();


            plus4.Show();
            minus4.Show();


            plus5.Show();
            minus5.Show();


            plus6.Show();
            minus6.Show();


            plus7.Show();
            minus7.Show();


            plus8.Hide();
            minus8.Hide();


            plus9.Hide();
            minus9.Hide();

            //사진 정리
            menu1.Image = Properties.Resources.h1;
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Image = Properties.Resources.h2;
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Image = Properties.Resources.h3;
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Image = Properties.Resources.h4;
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Image = Properties.Resources.h5;
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            menu6.Image = Properties.Resources.h6;
            menu6.SizeMode = PictureBoxSizeMode.StretchImage;
            menu7.Image = Properties.Resources.h7;
            menu7.SizeMode = PictureBoxSizeMode.StretchImage;
            //메뉴 정리
            menulabel1.Text = "제육 덮밥 : 8000원";
            menulabel2.Text = "김치 제육 덮밥 : 9000원";
            menulabel3.Text = "불고기 덮밥 : 8000원";
            menulabel4.Text = "김치 찌개 : 7000원";
            menulabel5.Text = "된장 찌개 : 7000원";
            menulabel6.Text = "뚝배기 불고기 : 8500원";
            menulabel7.Text = "낙지돌솥밥 : 9000원";
            //가격 정리
            menuValue[0] = 8000;
            menuValue[1] = 9000;
            menuValue[2] = 8000;
            menuValue[3] = 7000;
            menuValue[4] = 7000;
            menuValue[5] = 8500;
            menuValue[6] = 9000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //best 정리
            best1.Show();
            best2.Show();
            best3.Hide();
            best4.Hide();
            //메뉴 정리
            menu1.Show();
            menu2.Show();
            menu3.Show();
            menu4.Show();
            menu5.Hide();
            menu6.Hide();
            menu7.Hide();
            menu8.Hide();
            menu9.Hide();
            //메뉴 라벨 정리
            menulabel1.Show();
            menulabel2.Show();
            menulabel3.Show();
            menulabel4.Show();
            menulabel5.Hide();
            menulabel6.Hide();
            menulabel7.Hide();
            menulabel8.Hide();
            menulabel9.Hide();

            //버튼 및 수량 정리
            plus1.Show();
            minus1.Show();


            plus2.Show();
            minus2.Show();


            plus3.Show();
            minus3.Show();


            plus4.Show();
            minus4.Show();


            plus5.Hide();
            minus5.Hide();


            plus6.Hide();
            minus6.Hide();


            plus7.Hide();
            minus7.Hide();


            plus8.Hide();
            minus8.Hide();


            plus9.Hide();
            minus9.Hide();

            //사진 정리
            menu1.Image = Properties.Resources.y1;
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Image = Properties.Resources.y2;
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Image = Properties.Resources.y3;
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Image = Properties.Resources.y4;
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            //메뉴 정리
            menulabel1.Text = "오므라이스 : 8000원";
            menulabel2.Text = "돈까스 : 8000원";
            menulabel3.Text = "생선까스 : 7000원";
            menulabel4.Text = "고구마 치즈 돈까스 : 9000원";
            //가격 정리
            menuValue[0] = 8000;
            menuValue[1] = 8000;
            menuValue[2] = 7000;
            menuValue[3] = 9000;
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            //best 정리
            best1.Show();
            best2.Show();
            best3.Show();
            best4.Show();
            //메뉴 정리
            menu1.Show();
            menu2.Show();
            menu3.Show();
            menu4.Show();
            menu5.Show();
            menu6.Show();
            menu7.Show();
            menu8.Show();
            menu9.Show();
            //메뉴 라벨 정리
            menulabel1.Show();
            menulabel2.Show();
            menulabel3.Show();
            menulabel4.Show();
            menulabel5.Show();
            menulabel6.Show();
            menulabel7.Show();
            menulabel8.Show();
            menulabel9.Show();

            //버튼 및 수량 정리
            plus1.Show();
            minus1.Show();


            plus2.Show();
            minus2.Show();


            plus3.Show();
            minus3.Show();


            plus4.Show();
            minus4.Show();


            plus5.Show();
            minus5.Show();


            plus6.Show();
            minus6.Show();


            plus7.Show();
            minus7.Show();


            plus8.Show();
            minus8.Show();


            plus9.Show();
            minus9.Show();

            //사진 정리
            menu1.Image = Properties.Resources.b1;
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Image = Properties.Resources.b2;
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Image = Properties.Resources.b3;
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Image = Properties.Resources.b4;
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Image = Properties.Resources.b5;
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            menu6.Image = Properties.Resources.b6;
            menu6.SizeMode = PictureBoxSizeMode.StretchImage;
            menu7.Image = Properties.Resources.b7;
            menu7.SizeMode = PictureBoxSizeMode.StretchImage;
            menu8.Image = Properties.Resources.b8;
            menu8.SizeMode = PictureBoxSizeMode.StretchImage;
            menu9.Image = Properties.Resources.b9;
            menu9.SizeMode = PictureBoxSizeMode.StretchImage;
            //메뉴 정리
            menulabel1.Text = "떡볶이 : 5000원";
            menulabel2.Text = "라면 : 4500원";
            menulabel3.Text = "쫄면 : 7000원";
            menulabel4.Text = "만두 : 4000원";
            menulabel5.Text = "떡만두국 : 7000원";
            menulabel6.Text = "비빔국수 : 6500원";
            menulabel7.Text = "김치말이 국수 : 7500원";
            menulabel8.Text = "라볶이 : 7000원";
            menulabel9.Text = "오뎅탕 : 5000원";
            //가격 정리
            menuValue[0] = 5000;
            menuValue[1] = 4500;
            menuValue[2] = 7000;
            menuValue[3] = 4000;
            menuValue[4] = 7000;
            menuValue[5] = 6500;
            menuValue[6] = 7500;
            menuValue[7] = 7000;
            menuValue[8] = 5000;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //best 정리
            best1.Hide();
            best2.Hide();
            best3.Hide();
            best4.Hide();
            //메뉴 정리
            menu1.Show();
            menu2.Show();
            menu3.Show();
            menu4.Show();
            menu5.Show();
            menu6.Show();
            menu7.Show();
            menu8.Hide();
            menu9.Hide();
            //메뉴 라벨 정리
            menulabel1.Show();
            menulabel2.Show();
            menulabel3.Show();
            menulabel4.Show();
            menulabel5.Show();
            menulabel6.Show();
            menulabel7.Show();
            menulabel8.Hide();
            menulabel9.Hide();

            //버튼 및 수량 정리
            plus1.Show();
            minus1.Show();


            plus2.Show();
            minus2.Show();


            plus3.Show();
            minus3.Show();


            plus4.Show();
            minus4.Show();


            plus5.Show();
            minus5.Show();


            plus6.Show();
            minus6.Show();


            plus7.Show();
            minus7.Show();


            plus8.Hide();
            minus8.Hide();


            plus9.Hide();
            minus9.Hide();

            //사진 정리
            menu1.Image = Properties.Resources.s1;
            menu1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu2.Image = Properties.Resources.s2;
            menu2.SizeMode = PictureBoxSizeMode.StretchImage;
            menu3.Image = Properties.Resources.s3;
            menu3.SizeMode = PictureBoxSizeMode.StretchImage;
            menu4.Image = Properties.Resources.s4;
            menu4.SizeMode = PictureBoxSizeMode.StretchImage;
            menu5.Image = Properties.Resources.s5;
            menu5.SizeMode = PictureBoxSizeMode.StretchImage;
            menu6.Image = Properties.Resources.s6;
            menu6.SizeMode = PictureBoxSizeMode.StretchImage;
            menu7.Image = Properties.Resources.s7;
            menu7.SizeMode = PictureBoxSizeMode.StretchImage;

            //메뉴 정리
            menulabel1.Text = "공기밥 : 1000원";
            menulabel2.Text = "1/2 우동 : 2500원";
            menulabel3.Text = "계란 후라이 : 1000원";
            menulabel4.Text = "슬라이스 치즈 : 500원";
            menulabel5.Text = "콜라 : 2000원";
            menulabel6.Text = "사이다 : 2000원";
            menulabel7.Text = "환타  : 2000원";

            //가격 정리
            menuValue[0] = 1000;
            menuValue[1] = 2500;
            menuValue[2] = 1000;
            menuValue[3] = 500;
            menuValue[4] = 2000;
            menuValue[5] = 2000;
            menuValue[6] = 2000;

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
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel1.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[0]).ToString();
                    booleanplus[0] = true;
                    tot += menuValue[0];
                    break;
                }

            }

            if (booleanplus[0] == false)
            {
                count[0] = 1;
                item.SubItems.Add(menulabel1.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }

            

            totallabel.Text = "총 금액 : " + tot + "원";
            /* 실패작이긴 하지만 혹시 몰라 놔둔 것
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
                
            }
            booleanplus[0] = true;*/
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }
            count[0]--;

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


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plus2_Click(object sender, EventArgs e)
        {
            count[1]++;
            booleanplus[1] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel2.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[1]).ToString();
                    booleanplus[1] = true;
                    tot += menuValue[1];
                    break;
                }

            }

            if (booleanplus[1] == false)
            {
                count[1] = 1;
                item.SubItems.Add(menulabel2.Text);
                item.SubItems.Add(count[1].ToString());
                item.SubItems.Add((menuValue[1] * count[1]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[1];
            }

            if(menulabel2.Text == "라면 : 4500원")
            {
                DialogResult result = MessageBox.Show("슬라이스 치즈를 추가하시겠습니까?", "확인", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    bool boolcheck1 = false;
                    foreach (ListViewItem itemss in listView1.Items)
                    {
                        if (itemss.SubItems[1].Text == "슬라이스 치즈 : 500원")
                        {
                            // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                            int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                            itemss.SubItems[2].Text = quantity.ToString();
                            itemss.SubItems[3].Text = (quantity * 500).ToString();
                            boolcheck1 = true;
                            tot += 500;
                            break;
                        }

                    }
                    if (boolcheck1 == false) 
                    {
                        ListViewItem newItem = new ListViewItem();
                        newItem.SubItems.Add("슬라이스 치즈 : 500원");
                        newItem.SubItems.Add(1.ToString());
                        newItem.SubItems.Add((500).ToString());
                        listView1.Items.Add(newItem);
                        tot += 500;
                    }
                }
            }

            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void minus2_Click(object sender, EventArgs e)
        {
            if (count[1] <= 0)
            {
                return;
            }
            count[1]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel2.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[1]).ToString();
                    break;
                }
            }
            tot -= menuValue[1];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void plus3_Click(object sender, EventArgs e)
        {
            count[2]++;
            booleanplus[2] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel3.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[2]).ToString();
                    booleanplus[2] = true;
                    tot += menuValue[2];
                    break;
                }

            }

            if (booleanplus[2] == false)
            {
                count[2] = 1;
                item.SubItems.Add(menulabel3.Text);
                item.SubItems.Add(count[2].ToString());
                item.SubItems.Add((menuValue[2] * count[2]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[2];
            }
            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void minus3_Click(object sender, EventArgs e)
        {
            if (count[2] <= 0)
            {
                return;
            }
            count[2]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel3.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[2]).ToString();
                    break;
                }
            }
            tot -= menuValue[2];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void plus4_Click(object sender, EventArgs e)
        {
            count[3]++;
            booleanplus[3] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel4.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[3]).ToString();
                    booleanplus[3] = true;
                    tot += menuValue[3];
                    break;
                }

            }

            if (booleanplus[3] == false)
            {
                count[3] = 1;
                item.SubItems.Add(menulabel4.Text);
                item.SubItems.Add(count[3].ToString());
                item.SubItems.Add((menuValue[3] * count[3]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[3];
            }
            totallabel.Text = "총 금액 : " + tot + "원";

        }

        private void minus4_Click(object sender, EventArgs e)
        {
            if (count[3] <= 0)
            {
                return;
            }
            count[3]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel4.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[3]).ToString();
                    break;
                }
            }
            tot -= menuValue[3];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void plus5_Click(object sender, EventArgs e)
        {
            count[4]++;
            booleanplus[4] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel5.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[4]).ToString();
                    booleanplus[4] = true;
                    tot += menuValue[4];
                    break;
                }

            }

            if (booleanplus[4] == false)
            {
                count[4] = 1;
                item.SubItems.Add(menulabel5.Text);
                item.SubItems.Add(count[4].ToString());
                item.SubItems.Add((menuValue[4] * count[4]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[4];
            }
            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void minus5_Click(object sender, EventArgs e)
        {
            if (count[4] <= 0)
            {
                return;
            }
            count[4]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel5.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[4]).ToString();
                    break;
                }
            }
            tot -= menuValue[4];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void plus6_Click(object sender, EventArgs e)
        {
            count[5]++;
            booleanplus[5] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel6.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[5]).ToString();
                    booleanplus[5] = true;
                    tot += menuValue[5];
                    break;
                }

            }

            if (booleanplus[5] == false)
            {
                count[5] = 1;
                item.SubItems.Add(menulabel6.Text);
                item.SubItems.Add(count[5].ToString());
                item.SubItems.Add((menuValue[5] * count[5]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[5];
            }
            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void minus6_Click(object sender, EventArgs e)
        {
            if (count[5] <= 0)
            {
                return;
            }
            count[5]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel6.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[5]).ToString();
                    break;
                }
            }
            tot -= menuValue[5];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void plus7_Click(object sender, EventArgs e)
        {
            count[6]++;
            booleanplus[6] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel7.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[6]).ToString();
                    booleanplus[6] = true;
                    tot += menuValue[6];
                    break;
                }

            }

            if (booleanplus[6] == false)
            {
                count[6] = 1;
                item.SubItems.Add(menulabel7.Text);
                item.SubItems.Add(count[6].ToString());
                item.SubItems.Add((menuValue[6] * count[6]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[6];
            }
            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void minus7_Click(object sender, EventArgs e)
        {
            if (count[6] <= 0)
            {
                return;
            }
            count[6]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel7.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[6]).ToString();
                    break;
                }
            }
            tot -= menuValue[6];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void plus8_Click(object sender, EventArgs e)
        {
            count[7]++;
            booleanplus[7] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel8.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[7]).ToString();
                    booleanplus[7] = true;
                    tot += menuValue[7];
                    break;
                }

            }

            if (booleanplus[7] == false)
            {
                count[7] = 1;
                item.SubItems.Add(menulabel8.Text);
                item.SubItems.Add(count[7].ToString());
                item.SubItems.Add((menuValue[7] * count[7]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[7];
            }
            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void minus8_Click(object sender, EventArgs e)
        {
            if (count[7] <= 0)
            {
                return;
            }
            count[7]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel8.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[7]).ToString();
                    break;
                }
            }
            tot -= menuValue[7];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void plus9_Click(object sender, EventArgs e)
        {
            count[8]++;
            booleanplus[8] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel9.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[8]).ToString();
                    booleanplus[8] = true;
                    tot += menuValue[8];
                    break;
                }

            }

            if (booleanplus[8] == false)
            {
                count[8] = 1;
                item.SubItems.Add(menulabel9.Text);
                item.SubItems.Add(count[8].ToString());
                item.SubItems.Add((menuValue[8] * count[8]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[8];
            }
            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void minus9_Click(object sender, EventArgs e)
        {
            if (count[8] <= 0)
            {
                return;
            }
            count[8]--;

            ListViewItem item = new ListViewItem();


            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel9.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) - 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[8]).ToString();
                    break;
                }
            }
            tot -= menuValue[8];


            totallabel.Text = "총 금액 : " + tot + "원";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string[] ConvertListViewToStringArray(ListView listView)
        {
            List<string> items = new List<string>();

            // ListView의 모든 항목을 반복하고 각 항목의 텍스트를 추출하여 리스트에 추가
            foreach (ListViewItem item in listView.Items)
            {
                items.Add(item.Text);
            }

            // 리스트를 문자열 배열로 변환하여 반환
            return items.ToArray();
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            if(packing == false)
            {

                form3.Owner = this;
                DialogResult dREsult = form3.ShowDialog();

                form4 = new Form4(listView1,whereTable,tot);
                form4.Owner = this;
                DialogResult dResult = form4.ShowDialog();

                this.Close();
            }
            else
            {
                form4 = new Form4(listView1,whereTable,tot);
                form4.Owner = this;
                DialogResult dResult = form4.ShowDialog();
                this.Close();
            }
        }

       
    }
}
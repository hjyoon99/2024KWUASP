using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        //각 메뉴별 옵션
        private Dictionary<string, List<string>> menuOptions;
        // 토핑 가격 정보를 저장하는 Dictionary
        private Dictionary<string, double> toppingPrices;
        public Form2(bool val)
        {
            packing = val;  
            //메뉴 정리
            InitializeComponent();
            InitializeMenu();
            InitializeListView();
            SetUpMenuOptions();
            SetUpToppingPrices();

            //BEST 라벨의 부모컨트롤 변경 (메뉴사진 클릭 시 토핑 텍스트에 해당 메뉴 이름이 표시되기 위함)

            best1.Parent = this;
            best2.Parent = this;
            best3.Parent = this;
            best4.Parent = this;

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

        private void SetUpMenuOptions()
        {
            menuOptions = new Dictionary<string, List<string>>
            {
                {"menu1", new List<string> {"현미밥 변경", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요"} },
                {"menu2", new List<string> {"현미밥 변경","치즈 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } },
                {"menu3", new List<string> {"현미밥 변경","참치 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } },
                {"menu4", new List<string> {"현미밥 변경","날치알 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } },
                {"menu5", new List<string> {"현미밥 변경","돈가스 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } }
            };

            
        }

        private void SetUpToppingPrices()
        {
            // 토핑 가격 정리
            toppingPrices = new Dictionary<string, double>
            {
                {"현미밥 변경", 1000},
                {"치즈 추가", 1000},
                {"당근 빼주세요", 0},
                {"오이 빼주세요", 0},
                {"단무지 빼주세요", 0},
                {"참치 추가", 1000},
                {"날치알 추가", 1500},
                {"돈가스 추가", 1500}

            };
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

            menuOptions = new Dictionary<string, List<string>>
            {
                {"menu1", new List<string> {"현미밥 변경","당근 빼주세요", "오이 빼주세요", "단무지 빼주세요"} },
                {"menu2", new List<string> {"현미밥 변경","치즈 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } },
                {"menu3", new List<string> {"현미밥 변경","참치 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } },
                {"menu4", new List<string> {"현미밥 변경","날치알 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } },
                {"menu5", new List<string> {"현미밥 변경","돈가스 추가", "당근 빼주세요", "오이 빼주세요", "단무지 빼주세요" } }              
            };

            // 토핑 가격 정리
            toppingPrices = new Dictionary<string, double>
            {
                {"현미밥 변경", 1000},
                {"치즈 추가", 1000},
                {"당근 빼주세요", 0},
                {"오이 빼주세요", 0},
                {"단무지 빼주세요", 0},
                {"참치 추가", 1000},
                {"날치알 추가", 1500},
                {"돈가스 추가", 1500}            

            };

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

            //토핑 정리
            menuOptions = new Dictionary<string, List<string>>
            {
                {"menu1", new List<string> {"고기 추가", "밥 추가", "대파 추가", "고추 추가"} },
                {"menu2", new List<string> {"김치 추가", "밥 추가", "고기 추가", "고추 추가"} },
                {"menu3", new List<string> {"고기 추가", "밥 추가", "당면 추가" } },
                {"menu4", new List<string> {"고기 추가", "김치 추가", "밥 추가", "떡사리 추가", "두부 추가", "계란후라이 추가" } },
                {"menu5", new List<string> {"두부 추가", "밥 추가", "계란후라이 추가" } },
                {"menu6", new List<string> {"고기 추가", "밥 추가", "당면 추가", "계란후라이 추가" } },
                {"menu7", new List<string> {"낙지 추가", "밥 추가", "계란후라이 추가" } }
            };

            // 토핑 가격 정리
            toppingPrices = new Dictionary<string, double>
            {
                {"고기 추가", 4000},
                {"밥 추가", 2000},
                {"대파 추가", 1000},
                {"고추 추가", 1000},
                {"김치 추가", 1000},
                {"당면 추가", 1500},
                {"떡사리 추가", 1000},
                {"두부 추가", 1500},
                {"계란후라이 추가", 1000},
                {"낙지 추가", 5000}
                
            };
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

            menuOptions = new Dictionary<string, List<string>>
            {
                {"menu1", new List<string> {"밥 추가", "계란 추가", "당근 빼주세요", "소스 추가"} },
                {"menu2", new List<string> {"돈까스 추가", "밥 추가", "소스 추가"} },
                {"menu3", new List<string> {"생선까스 추가", "밥 추가", "타르타르소스 추가" } },
                {"menu4", new List<string> {"고구마 치즈 돈까스 추가", "밥 추가", "소스 추가", "고구마토핑 추가" } }
                
            };

            // 토핑 가격 정리
            toppingPrices = new Dictionary<string, double>
            {
                {"계란 추가", 1000},
                {"밥 추가", 2000},
                {"당근 빼주세요", 0},
                {"소스 추가", 500},
                {"돈까스 추가", 4000},
                {"생선까스 추가", 4000},
                {"고구마 치즈 돈까스 추가", 5000},
                {"타르타르소스 추가", 500},
                {"고구마토핑 추가", 1000}

            };



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

            menuOptions = new Dictionary<string, List<string>>
            {
                {"menu1", new List<string> {"떡 추가", "라면사리 추가", "소세지 추가", "당면 추가"} },
                {"menu2", new List<string> {"떡 추가", "만두 추가", "고추 추가", "콩나물 추가", "계란 추가"} },
                {"menu3", new List<string> {"야채 추가", "면 추가", "삶은계란 추가" } },
                {"menu4", new List<string> {"단무지 추가"} },
                {"menu5", new List<string> {"떡 추가", "만두 추가" } },
                {"menu6", new List<string> {"면 추가", "삶은계란 추가", "오이 추가"} },
                {"menu7", new List<string> {"면 추가", "김치 추가", "삶은계란 추가" } },
                {"menu8", new List<string> {"면 추가", "떡 추가", "삶은계란 추가" } },
                {"menu9", new List<string> {"오뎅 추가", "곤약 추가", "유부주머니 추가" } }
            };

            // 토핑 가격 정리
            toppingPrices = new Dictionary<string, double>
            {
                {"떡 추가", 1000},
                {"라면사리 추가", 1000},
                {"소세지 추가", 1000},
                {"당면 추가", 1500},
                {"만두 추가", 1500},
                {"고추 추가", 500},
                {"콩나물 추가", 500},
                {"계란 추가", 500},
                {"야채 추가", 500},
                {"면 추가", 1000},
                {"삶은계란 추가", 500},
                {"오이 추가", 500},
                {"김치 추가", 500},
                {"오뎅 추가", 2000},
                {"곤약 추가", 2000},
                {"유부주머니 추가", 3000},
                {"단무지 추가", 500}

            };
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

            //토핑 메뉴 정리
            menuOptions = new Dictionary<string, List<string>>
            {
                {"menu1", new List<string> {} },
                {"menu2", new List<string> {} },
                {"menu3", new List<string> {} },
                {"menu4", new List<string> {} },
                {"menu5", new List<string> {} },
                {"menu6", new List<string> {} },
                {"menu7", new List<string> {} }
            };

            // 토핑 가격 정리
            toppingPrices = new Dictionary<string, double>
            { };

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



            totallabel.Text = "총 금액 : " + tot + "원"; ;

            //토핑박스에 추가

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach(Control control in parentPanel.Controls)
                    {
                        if(control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if(realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option ;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }
                   
                }
            }



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

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel1.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[0]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[0];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }


        private void plus2_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel2.Text)
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
                item.SubItems.Add(menulabel2.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus2_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel2.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[1]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[1];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }

        private void plus3_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel3.Text)
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
                item.SubItems.Add(menulabel3.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus3_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel3.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[2]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[2];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시

        }

        private void plus4_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel4.Text)
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
                item.SubItems.Add(menulabel4.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus4_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel4.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[3]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[3];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }

        private void plus5_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel5.Text)
                {
                    // 동일한 메뉴를 찾으면 해당 항목의 수량과 가격을 업데이트
                    int quantity = int.Parse(itemss.SubItems[2].Text) + 1;
                    itemss.SubItems[2].Text = quantity.ToString();
                    itemss.SubItems[3].Text = (quantity * menuValue[4]).ToString();
                    booleanplus[0] = true;
                    tot += menuValue[4];
                    break;
                }

            }

            if (booleanplus[0] == false)
            {
                count[0] = 1;
                item.SubItems.Add(menulabel5.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[4] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[4];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus5_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel5.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[4]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[4];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }

        private void plus6_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel6.Text)
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
                item.SubItems.Add(menulabel6.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus6_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel6.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[5]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[5];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }

        private void plus7_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel7.Text)
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
                item.SubItems.Add(menulabel7.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus7_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel7.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[6]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[6];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }

        private void plus8_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel8.Text)
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
                item.SubItems.Add(menulabel8.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus8_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel8.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[7]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[7];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }

        private void plus9_Click(object sender, EventArgs e)
        {
            count[0]++;
            booleanplus[0] = false;
            ListViewItem item = new ListViewItem();
            foreach (ListViewItem itemss in listView1.Items)
            {
                if (itemss.SubItems[1].Text == menulabel9.Text)
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
                item.SubItems.Add(menulabel9.Text);
                item.SubItems.Add(count[0].ToString());
                item.SubItems.Add((menuValue[0] * count[0]).ToString());
                listView1.Items.Add(item);
                tot += menuValue[0];
            }



            totallabel.Text = "총 금액 : " + tot + "원";

            if (sender is System.Windows.Forms.Button button)
            {

                Panel parentPanel = button.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;
                PictureBox realatedPictureBox = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)

                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is PictureBox pictureBox)
                        {
                            realatedPictureBox = pictureBox;
                            break;
                        }
                    }

                    if (realatedPictureBox != null)
                    {
                        if (menuOptions.ContainsKey(realatedPictureBox.Name))
                        {
                            checkedListBox1.Items.Clear();
                            var options = menuOptions[realatedPictureBox.Name];
                            string[] labelParts = labelText.Split(':');
                            string labelMenu = labelParts[0].Trim();
                            string menuName = $"{labelMenu} -> ";
                            foreach (var option in options)
                            {
                                string topOp = menuName + option;
                                checkedListBox1.Items.Add(topOp);
                            }
                        }
                    }

                }
            }
        }

        private void minus9_Click(object sender, EventArgs e)
        {
            if (count[0] <= 0)
            {
                return;
            }

            count[0]--;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == menulabel9.Text)  // 메뉴 이름이 같은지 확인
                {
                    int quantity = int.Parse(item.SubItems[2].Text) - 1;  // 수량을 1 감소

                    if (quantity <= 0)
                    {
                        // 수량이 0 이하이면 해당 항목을 ListView에서 제거
                        listView1.Items.Remove(item);
                    }
                    else
                    {
                        // 수량이 0이 아니면 업데이트
                        item.SubItems[2].Text = quantity.ToString();  // 수량 업데이트
                        item.SubItems[3].Text = (quantity * menuValue[8]).ToString();  // 가격 업데이트
                    }

                    break;  // 항목을 찾았으므로 루프를 중단
                }
            }

            tot -= menuValue[8];  // 총 가격을 업데이트
            totallabel.Text = "총 금액 : " + tot + "원";  // 총 금액을 다시 표시
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string[] ConvertListViewToStringArray(System.Windows.Forms.ListView listView)
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

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        
        //토핑 추가 버튼
        private void button9_Click(object sender, EventArgs e) 
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.");
                return;
            }

            foreach (var checkedItem in checkedListBox1.CheckedItems)
            {
                string toppingName = checkedItem.ToString();
                string[] parts = toppingName.Split('>');
                string option = parts[1].Trim();
                int quantityToAdd = 1;  // 추가할 수량
                double pricePerUnit = toppingPrices[option];   // 토핑의 단위당 가격

               

                // 리스트뷰에서 같은 이름을 가진 항목 찾기
                var existingItem = listView1.Items.Cast<ListViewItem>()
                    .FirstOrDefault(item => item.SubItems[1].Text.Trim().Equals(toppingName, StringComparison.OrdinalIgnoreCase));
                

                if (existingItem != null)
                {
                    // 이미 같은 토핑이 있으면 수량과 가격을 업데이트
                    int currentQuantity = Convert.ToInt32(existingItem.SubItems[2].Text);  // 현재 수량
                    double currentPrice = Convert.ToDouble(existingItem.SubItems[3].Text);  // 현재 가격
                    existingItem.SubItems[2].Text = (currentQuantity + quantityToAdd).ToString();
                    existingItem.SubItems[3].Text = (currentPrice + (pricePerUnit * quantityToAdd)).ToString();
                    tot +=(int) pricePerUnit;
                    totallabel.Text = "총 금액 : " + tot + "원";

                }
                else
                {
                    // 동일한 토핑이 없으면 새로운 항목을 추가
                    var newItem = new ListViewItem();
                    newItem.SubItems.Add(toppingName);  // 토핑 이름
                    newItem.SubItems.Add(quantityToAdd.ToString());  // 수량
                    newItem.SubItems.Add((pricePerUnit * quantityToAdd).ToString());  // 가격
                    listView1.Items.Add(newItem);
                    tot += (int)pricePerUnit;
                    totallabel.Text = "총 금액 : " + tot + "원";
                }

                totallabel.Text = "총 금액 : " + tot + "원";


            }
        }

        //토핑 삭제 버튼
        private void button10_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("선택된 항목이 없습니다.");
                return;
            }

            foreach (var checkedItem in checkedListBox1.CheckedItems)
            {
                string toppingName = checkedItem.ToString();
                string[] parts = toppingName.Split('>');
                string option = parts[1].Trim();
                int quantityToAdd = 1;  // 삭제할 수량
                double pricePerUnit = toppingPrices[option];   // 토핑의 단위당 가격



                // 리스트뷰에서 같은 이름을 가진 항목 찾기
                var existingItem = listView1.Items.Cast<ListViewItem>()
                    .FirstOrDefault(item => item.SubItems[1].Text.Trim().Equals(toppingName, StringComparison.OrdinalIgnoreCase));


                if (existingItem != null)
                {
                    
                    // 이미 같은 토핑이 있으면 수량과 가격을 업데이트
                    int currentQuantity = Convert.ToInt32(existingItem.SubItems[2].Text);  // 현재 수량
                    existingItem.SubItems[2].Text= (currentQuantity - quantityToAdd).ToString();

                    double currentPrice = Convert.ToDouble(existingItem.SubItems[3].Text);  // 현재 가격
                    existingItem.SubItems[3].Text = (currentPrice - (pricePerUnit * quantityToAdd)).ToString();

                    tot -= (int)pricePerUnit;
                    totallabel.Text = "총 금액 : " + tot + "원";

                    if (currentQuantity <= 1) //현재 수량이 1보다 작으면 리스트에서 삭제. 
                    {
                        listView1.Items.Remove(existingItem);
                    }

                }
                else
                {
                    MessageBox.Show("체크된 토핑은 장바구니에 없습니다.");
                }

                
                totallabel.Text = "총 금액 : " + tot + "원";
            }

        }

        private void menu1_Click(object sender, EventArgs e)
        {
            /*if(sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel이 아니면 null 반환 (그룹박스는 테두리가 생겨서..패널로 바꿨어요..)

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기 (라벨이 두개 이상이어서 찾을 라벨 제외 타 라벨의 부모를 폼으로 변경해줌)


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':'); 
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }



        private void menu2_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
            /*if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel가 아니면 null 반환

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }

        private void menu3_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
            /*if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel이 아니면 null 반환 

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/

        }

        private void menu4_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
           /* if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel가 아니면 null 반환

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }

        private void menu5_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
            /*if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel가 아니면 null 반환

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }

        private void menu6_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
            /*if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel가 아니면 null 반환

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }

        private void menu7_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
            /*if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel가 아니면 null 반환

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }

        private void menu8_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
            /*if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel가 아니면 null 반환

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }

        private void menu9_Click(object sender, EventArgs e) // picturebox누르면 토핑옵션
        {
            /*if (sender is PictureBox pictureBox)
            {

                Panel parentPanel = pictureBox.Parent as Panel; // parent가 Panel가 아니면 null 반환

                Label relatedLabel = null;

                if (parentPanel != null)
                {
                    foreach (Control control in parentPanel.Controls)
                    {
                        if (control is Label label)
                        {
                            relatedLabel = label;
                            break; // 찾았으면 종료
                        }
                    }
                }

                if (relatedLabel != null)
                {
                    string labelText = relatedLabel.Text; // Label의 텍스트 가져오기


                    if (menuOptions.ContainsKey(pictureBox.Name))
                    {
                        checkedListBox1.Items.Clear();
                        var options = menuOptions[pictureBox.Name];
                        string[] labelParts = labelText.Split(':');
                        string labelMenu = labelParts[0].Trim();
                        string menuName = $"{labelMenu} -> ";
                        foreach (var option in options)
                        {
                            string topOp = menuName + option;
                            checkedListBox1.Items.Add(topOp);
                        }
                    }
                }
            }*/
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
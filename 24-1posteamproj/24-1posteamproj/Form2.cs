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

namespace _24_1posteamproj
{
    public partial class MenuForm : Form
    {   
        string path = Directory.GetCurrentDirectory() + @"\MenuStatus.xml";
        public DataSet MenuData = new DataSet();
        public Button[] btn;

        public MenuForm()
        {
            InitializeComponent();
           // CreateDataSet();
            MenuData.ReadXml(path);
            btn = new Button[]{Gimbab1,Gimbab2, Gimbab3,Gimbab3,Gimbab4, Gimbab5,
                Hansik1, Hansik2,Hansik3,Hansik4,Hansik5,Hansik6,Hansik7,
                Wf1,Wf2,Wf3,Wf4,
                Bunsik1,Bunsik2,Bunsik3,Bunsik4,Bunsik5,Bunsik6,Bunsik7,Bunsik8,Bunsik9,
                Side1,Side2,Side3,Side4,Drink1,Drink2,Drink3
            };
            for(int i = 1; i < btn.Length; i++)
            {
                btn[i].Enabled = Convert.ToBoolean(MenuData.Tables[0].Rows[i-1][1]);
            }
            
            for(int i = 0; i < MenuData.Tables[0].Rows.Count; i++)
            { 
                MenuData.Tables[0].Rows[i].BeginEdit();
            }
            
        }

        
        private void MenuForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimerDate.Text = DateTime.Now.ToLongDateString();
            TimerTime.Text = DateTime.Now.ToLongTimeString();
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

        private void Hansik1_Click(object sender, EventArgs e)
        {
            MenuName.Text=Hansik1.Text;
        }

        private void Hansik2_Click(object sender, EventArgs e)
        {
            MenuName.Text = Hansik2.Text;
        }

        private void Hansik3_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Hansik3.Text);
        }

        private void Hansik4_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Hansik4.Text);
        }

        private void Hansik5_Click(object sender, EventArgs e)
        {
            MenuName.Text = Hansik5.Text;
        }

        private void Hansik6_Click(object sender, EventArgs e)
        {
            MenuName.Text =(Hansik6.Text);
        }

        private void Hansik7_Click(object sender, EventArgs e)
        {
            MenuName.Text = Hansik7.Text;
        }

        private void Wf1_Click(object sender, EventArgs e)
        {
            MenuName.Text=Wf1.Text;
        }

        private void Wf2_Click(object sender, EventArgs e)
        {
            MenuName.Text = Wf2.Text;
        }

        private void Wf3_Click(object sender, EventArgs e)
        {
            MenuName.Text=Wf3.Text;
        }

        private void Wf4_Click(object sender, EventArgs e)
        {
            MenuName.Text=Wf4.Text;
        }

        private void Bunsik1_Click(object sender, EventArgs e)
        {
            MenuName.Text=Bunsik1.Text;
        }

        private void Bunsik2_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Bunsik2.Text);
        }

        private void Bunsik3_Click(object sender, EventArgs e)
        {
            MenuName.Text = Bunsik3.Text;
        }

        private void Bunsik4_Click(object sender, EventArgs e)
        {
            MenuName.Text =(Bunsik4.Text);
        }

        private void Bunsik5_Click(object sender, EventArgs e)
        {
            MenuName.Text = (Bunsik5.Text);
        }

        private void Bunsik6_Click(object sender, EventArgs e)
        {
            MenuName.Text = Bunsik6.Text;
        }

        private void Bunsik7_Click(object sender, EventArgs e)
        {
            MenuName.Text = Bunsik7.Text;
        }

        private void Bunsik8_Click(object sender, EventArgs e)
        {
            MenuName.Text= (Bunsik8.Text);
        }

        private void Bunsik9_Click(object sender, EventArgs e)
        {MenuName.Text= (Bunsik9.Text);

        }

        private void Side1_Click(object sender, EventArgs e)
        {
            MenuName.Text= Side1.Text;
        }

        private void Side2_Click(object sender, EventArgs e)
        {
            MenuName.Text=(Side2.Text);
        }

        private void Side3_Click(object sender, EventArgs e)
        {
            MenuName.Text=Side3.Text;
        }

        private void Side4_Click(object sender, EventArgs e)
        {
            MenuName.Text=Side4.Text;
        }

        private void Drink1_Click(object sender, EventArgs e)
        {
            MenuName.Text= Drink1.Text;
        }

        private void Drink2_Click(object sender, EventArgs e)
        {
            MenuName.Text=Drink2.Text;
        }

        private void Drink3_Click(object sender, EventArgs e)
        {
            MenuName.Text = Drink3.Text;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string name = MenuName.Text;
            if (name != null)
            {
                if (name == Gimbab1.Text) { Gimbab1.Enabled = false;
                    MenuData.Tables[0].Rows[0][1] = "false";
                }
                if (name == Gimbab2.Text) { Gimbab2.Enabled = false;
                    MenuData.Tables[0].Rows[1]["상품상태"] = "false";
                }
                if (name == Gimbab3.Text) { Gimbab3.Enabled = false;
                    MenuData.Tables[0].Rows[2]["상품상태"] = "false";
                }
                if (name == Gimbab4.Text) { Gimbab4.Enabled = false;
                    MenuData.Tables[0].Rows[3][1] = "false";
                }
                if (name == Gimbab5.Text) { Gimbab5.Enabled = false;
                    MenuData.Tables[0].Rows[4][1] = "false";
                }

                if (name == Hansik1.Text) { Hansik1.Enabled = false;
                    MenuData.Tables[0].Rows[5][1] = "false";
                }
                if (name == Hansik2.Text) { Hansik2.Enabled = false;
                    MenuData.Tables[0].Rows[6][1] = "false";
                }
                if (name == Hansik3.Text) { Hansik3.Enabled = false;
                    MenuData.Tables[0].Rows[7][1] = "false";
                }
                if (name == Hansik4.Text) { Hansik4.Enabled = false;
                    MenuData.Tables[0].Rows[8][1] = "false";
                }
                if (name == Hansik5.Text) { Hansik5.Enabled = false;
                    MenuData.Tables[0].Rows[9][1] = "false";
                }
                if (name == Hansik6.Text) { Hansik6.Enabled = false;
                    MenuData.Tables[0].Rows[10][1] = "false";
                }
                if (name == Hansik7.Text) { Hansik7.Enabled = false;
                    MenuData.Tables[0].Rows[11][1] = "false";
                }

                if (name == Wf1.Text) { Wf1.Enabled = false;
                    MenuData.Tables[0].Rows[12][1] = "false";
                }
                if (name == Wf2.Text) { Wf2.Enabled = false;
                    MenuData.Tables[0].Rows[13][1] = "false";
                }
                if (name == Wf3.Text) { Wf3.Enabled = false;
                    MenuData.Tables[0].Rows[14][1] = "false";
                }
                if (name == Wf4.Text) { Wf4.Enabled = false;
                    MenuData.Tables[0].Rows[15][1] = "false";
                }

                if (name == Bunsik1.Text) { Bunsik1.Enabled = false;
                    MenuData.Tables[0].Rows[16][1] = "false";
                }
                if (name == Bunsik2.Text) { Bunsik2.Enabled = false;
                    MenuData.Tables[0].Rows[17][1] = "false";
                }
                if (name == Bunsik3.Text) { Bunsik3.Enabled = false;
                    MenuData.Tables[0].Rows[18][1] = "false";
                }
                if (name == Bunsik4.Text) { Bunsik4.Enabled = false;
                    MenuData.Tables[0].Rows[19][1] = "false";
                }
                if (name == Bunsik5.Text) { Bunsik5.Enabled = false;
                    MenuData.Tables[0].Rows[20][1] = "false";
                }
                if (name == Bunsik6.Text) { Bunsik6.Enabled = false;
                    MenuData.Tables[0].Rows[21][1] = "false";
                }
                if (name == Bunsik7.Text) { Bunsik7.Enabled = false;
                    MenuData.Tables[0].Rows[22][1] = "false";
                }
                if (name == Bunsik8.Text) { Bunsik8.Enabled = false;
                    MenuData.Tables[0].Rows[23][1] = "false";
                }
                if (name == Bunsik9.Text) { Bunsik9.Enabled = false;
                    MenuData.Tables[0].Rows[24][1] = "false";
                }

                if (name == Side1.Text) { Side1.Enabled = false;
                    MenuData.Tables[0].Rows[25][1] = "false";
                }
                if (name == Side2.Text) { Side2.Enabled = false;
                    MenuData.Tables[0].Rows[26][1] = "false";
                }
                if (name == Side3.Text) { Side3.Enabled = false;
                    MenuData.Tables[0].Rows[27][1] = "false";
                }
                if (name == Side4.Text) { Side4.Enabled = false;
                    MenuData.Tables[0].Rows[28][1] = "false";
                }

                if (name == Drink1.Text) { Drink1.Enabled = false;
                    MenuData.Tables[0].Rows[29][1] = "false";
                }
                if (name == Drink2.Text) { Drink2.Enabled = false;
                    MenuData.Tables[0].Rows[30][1] = "false";
                }
                if (name == Drink3.Text) { Drink3.Enabled = false;
                    MenuData.Tables[0].Rows[31][1] = "false";
                }

                MenuData.Tables[0].AcceptChanges();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = MenuName.Text;

            if (name == Gimbab1.Text) { Gimbab1.Enabled = true;
                MenuData.Tables[0].Rows[0][1] = "true";
            }
            if (name == Gimbab2.Text) { Gimbab2.Enabled = true;
                MenuData.Tables[0].Rows[1][1] = "true";
            }
            if (name == Gimbab3.Text) { Gimbab3.Enabled = true;
                MenuData.Tables[0].Rows[2][1] = "true";
            }
            if (name == Gimbab4.Text) { Gimbab4.Enabled = true;
                MenuData.Tables[0].Rows[3][1] = "true";
            }
            if (name == Gimbab5.Text) { Gimbab5.Enabled = true;
                MenuData.Tables[0].Rows[4][1] = "true";
            }
            
            if(name==Hansik1.Text) { Hansik1.Enabled = true;
                MenuData.Tables[0].Rows[5][1] = "true";
            }
            if(name==Hansik2.Text) { Hansik2.Enabled = true;
                MenuData.Tables[0].Rows[6][1] = "true";
            }
            if(name== Hansik3.Text) { Hansik3.Enabled = true;
                MenuData.Tables[0].Rows[7][1] = "true";
            } 
            if(name == Hansik4.Text) { Hansik4.Enabled = true;
                MenuData.Tables[0].Rows[8][1] = "true";
            }
            if(name==Hansik5.Text) { Hansik5.Enabled = true;
                MenuData.Tables[0].Rows[9][1] = "true";
            }
            if(name==Hansik6.Text) { Hansik6.Enabled = true;
                MenuData.Tables[0].Rows[10][1] = "true";
            }
            if(name==Hansik7.Text) { Hansik7.Enabled = true;
                MenuData.Tables[0].Rows[11][1] = "true";
            }
            
            if(name==Wf1.Text) { Wf1.Enabled = true;
                MenuData.Tables[0].Rows[12][1] = "true";
            }
            if(name==Wf2.Text) { Wf2.Enabled = true;
                MenuData.Tables[0].Rows[13][1] = "true";
            }
            if(name==Wf3.Text) { Wf3.Enabled = true;
                MenuData.Tables[0].Rows[14][1] = "true";
            }
            if(name==Wf4.Text) { Wf4.Enabled = true;
                MenuData.Tables[0].Rows[15][1] = "true";
            }

            if (name == Bunsik1.Text) { Bunsik1.Enabled = true;
                MenuData.Tables[0].Rows[16][1] = "true";
            }
            if(name==Bunsik2.Text) { Bunsik2.Enabled = true;
                MenuData.Tables[0].Rows[17][1] = "true";
            }
            if (name == Bunsik3.Text) { Bunsik3.Enabled = true;
                MenuData.Tables[0].Rows[18][1] = "true";
            }
            if (name == Bunsik4.Text) { Bunsik4.Enabled = true;
                MenuData.Tables[0].Rows[19][1] = "true";
            }
            if(name==Bunsik5.Text) { Bunsik5.Enabled = true;
                MenuData.Tables[0].Rows[20][1] = "true";
            }
            if(name == Bunsik6.Text) { Bunsik6.Enabled = true;
                MenuData.Tables[0].Rows[21][1] = "true";
            }
            if (name == Bunsik7.Text) { Bunsik7.Enabled = true;
                MenuData.Tables[0].Rows[22][1] = "true";
            }
            if (name == Bunsik8.Text) { Bunsik8.Enabled = true;
                MenuData.Tables[0].Rows[23][1] = "true";
            }
            if(name==Bunsik9.Text) { Bunsik9.Enabled = true;
                MenuData.Tables[0].Rows[24][1] = "true";
            }

            if(name==Side1.Text) { Side1.Enabled = true;
                MenuData.Tables[0].Rows[25][1] = "true";
            }
            if(name==Side2.Text) { Side2.Enabled = true;
                MenuData.Tables[0].Rows[26][1] = "true";
            }
            if (name == Side3.Text) { Side3.Enabled = true;
                MenuData.Tables[0].Rows[27][1] = "true";
            }
            if(name==Side4.Text) { Side4.Enabled = true;
                MenuData.Tables[0].Rows[28][1] = "true";
            }
            
            if(name==Drink1.Text) { Drink1.Enabled = true;
                MenuData.Tables[0].Rows[29][1] = "true";
            }
            if(name==Drink2.Text) { Drink2.Enabled = true;
                MenuData.Tables[0].Rows[30][1] = "true";
            }
            if (name == Drink3.Text) { Drink3.Enabled = true;
                MenuData.Tables[0].Rows[31][1] = "true";
            }
            MenuName.Text = null;
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MenuData.Tables[0].Rows.Count; i++)
            {
                MenuData.Tables[0].Rows[i].BeginEdit();
            }
            //MenuData.Tables[0].AcceptChanges();
            MenuData.WriteXml(path);
            this.Close();
        }
    }
}

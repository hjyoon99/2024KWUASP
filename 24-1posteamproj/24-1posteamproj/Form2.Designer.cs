namespace _24_1posteamproj
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndBtn = new System.Windows.Forms.Button();
            this.menuTab = new System.Windows.Forms.TabControl();
            this.Kimbab = new System.Windows.Forms.TabPage();
            this.Gimbab5 = new System.Windows.Forms.Button();
            this.Gimbab4 = new System.Windows.Forms.Button();
            this.Gimbab3 = new System.Windows.Forms.Button();
            this.Gimbab2 = new System.Windows.Forms.Button();
            this.Gimbab1 = new System.Windows.Forms.Button();
            this.KoreanFood = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.WesternFood = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.Bunsik = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.Side = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TimerDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerTime = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.MenuPic = new System.Windows.Forms.PictureBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.MenuName = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuTab.SuspendLayout();
            this.Kimbab.SuspendLayout();
            this.KoreanFood.SuspendLayout();
            this.WesternFood.SuspendLayout();
            this.Bunsik.SuspendLayout();
            this.Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "응소실 POS 메뉴 관리";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.MenuName);
            this.groupBox1.Controls.Add(this.DelBtn);
            this.groupBox1.Controls.Add(this.MenuPic);
            this.groupBox1.Controls.Add(this.menuTab);
            this.groupBox1.Location = new System.Drawing.Point(20, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 309);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴";
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(679, 410);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 0;
            this.EndBtn.Text = "수정완료";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // menuTab
            // 
            this.menuTab.Controls.Add(this.Kimbab);
            this.menuTab.Controls.Add(this.KoreanFood);
            this.menuTab.Controls.Add(this.WesternFood);
            this.menuTab.Controls.Add(this.Bunsik);
            this.menuTab.Controls.Add(this.Side);
            this.menuTab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTab.Location = new System.Drawing.Point(11, 17);
            this.menuTab.Name = "menuTab";
            this.menuTab.SelectedIndex = 0;
            this.menuTab.Size = new System.Drawing.Size(346, 274);
            this.menuTab.TabIndex = 0;
            // 
            // Kimbab
            // 
            this.Kimbab.Controls.Add(this.Gimbab5);
            this.Kimbab.Controls.Add(this.Gimbab4);
            this.Kimbab.Controls.Add(this.Gimbab3);
            this.Kimbab.Controls.Add(this.Gimbab2);
            this.Kimbab.Controls.Add(this.Gimbab1);
            this.Kimbab.Location = new System.Drawing.Point(4, 27);
            this.Kimbab.Name = "Kimbab";
            this.Kimbab.Padding = new System.Windows.Forms.Padding(3);
            this.Kimbab.Size = new System.Drawing.Size(338, 243);
            this.Kimbab.TabIndex = 0;
            this.Kimbab.Text = "김밥";
            this.Kimbab.UseVisualStyleBackColor = true;
            // 
            // Gimbab5
            // 
            this.Gimbab5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gimbab5.Location = new System.Drawing.Point(119, 86);
            this.Gimbab5.Name = "Gimbab5";
            this.Gimbab5.Size = new System.Drawing.Size(94, 49);
            this.Gimbab5.TabIndex = 4;
            this.Gimbab5.Text = "돈까스김밥";
            this.Gimbab5.UseVisualStyleBackColor = true;
            this.Gimbab5.Click += new System.EventHandler(this.Gimbab5_Click);
            // 
            // Gimbab4
            // 
            this.Gimbab4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gimbab4.Location = new System.Drawing.Point(15, 86);
            this.Gimbab4.Name = "Gimbab4";
            this.Gimbab4.Size = new System.Drawing.Size(94, 49);
            this.Gimbab4.TabIndex = 3;
            this.Gimbab4.Text = "날치알김밥";
            this.Gimbab4.UseVisualStyleBackColor = true;
            this.Gimbab4.Click += new System.EventHandler(this.Gimbab4_Click);
            // 
            // Gimbab3
            // 
            this.Gimbab3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gimbab3.Location = new System.Drawing.Point(226, 19);
            this.Gimbab3.Name = "Gimbab3";
            this.Gimbab3.Size = new System.Drawing.Size(94, 49);
            this.Gimbab3.TabIndex = 2;
            this.Gimbab3.Text = "참치김밥";
            this.Gimbab3.UseVisualStyleBackColor = true;
            this.Gimbab3.Click += new System.EventHandler(this.Gimbab3_Click);
            // 
            // Gimbab2
            // 
            this.Gimbab2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gimbab2.Location = new System.Drawing.Point(119, 19);
            this.Gimbab2.Name = "Gimbab2";
            this.Gimbab2.Size = new System.Drawing.Size(94, 49);
            this.Gimbab2.TabIndex = 1;
            this.Gimbab2.Text = "치즈김밥";
            this.Gimbab2.UseVisualStyleBackColor = true;
            this.Gimbab2.Click += new System.EventHandler(this.Gimbab2_Click);
            // 
            // Gimbab1
            // 
            this.Gimbab1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gimbab1.Location = new System.Drawing.Point(15, 19);
            this.Gimbab1.Name = "Gimbab1";
            this.Gimbab1.Size = new System.Drawing.Size(94, 49);
            this.Gimbab1.TabIndex = 0;
            this.Gimbab1.Text = "일반김밥";
            this.Gimbab1.UseVisualStyleBackColor = true;
            this.Gimbab1.Click += new System.EventHandler(this.Gimbab1_Click);
            // 
            // KoreanFood
            // 
            this.KoreanFood.Controls.Add(this.button12);
            this.KoreanFood.Controls.Add(this.button11);
            this.KoreanFood.Controls.Add(this.button6);
            this.KoreanFood.Controls.Add(this.button7);
            this.KoreanFood.Controls.Add(this.button8);
            this.KoreanFood.Controls.Add(this.button9);
            this.KoreanFood.Controls.Add(this.button10);
            this.KoreanFood.Location = new System.Drawing.Point(4, 27);
            this.KoreanFood.Name = "KoreanFood";
            this.KoreanFood.Padding = new System.Windows.Forms.Padding(3);
            this.KoreanFood.Size = new System.Drawing.Size(338, 243);
            this.KoreanFood.TabIndex = 1;
            this.KoreanFood.Text = "한식";
            this.KoreanFood.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(15, 151);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 49);
            this.button12.TabIndex = 11;
            this.button12.Text = "낙지돌솥밥";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(226, 86);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 49);
            this.button11.TabIndex = 10;
            this.button11.Text = "뚝배기불고기";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(119, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 49);
            this.button6.TabIndex = 9;
            this.button6.Text = "된장찌개";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(15, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 49);
            this.button7.TabIndex = 8;
            this.button7.Text = "김치찌개";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(226, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 49);
            this.button8.TabIndex = 7;
            this.button8.Text = "불고기덮밥";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(119, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 49);
            this.button9.TabIndex = 6;
            this.button9.Text = "김치제육덮밥";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(15, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 49);
            this.button10.TabIndex = 5;
            this.button10.Text = "제육덮밥";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // WesternFood
            // 
            this.WesternFood.Controls.Add(this.button14);
            this.WesternFood.Controls.Add(this.button15);
            this.WesternFood.Controls.Add(this.button16);
            this.WesternFood.Controls.Add(this.button17);
            this.WesternFood.Location = new System.Drawing.Point(4, 27);
            this.WesternFood.Name = "WesternFood";
            this.WesternFood.Size = new System.Drawing.Size(338, 243);
            this.WesternFood.TabIndex = 2;
            this.WesternFood.Text = "양식";
            this.WesternFood.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(16, 87);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 49);
            this.button14.TabIndex = 8;
            this.button14.Text = "고구마치즈\r\n돈까스";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(227, 20);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 49);
            this.button15.TabIndex = 7;
            this.button15.Text = "생선까스";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(120, 20);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(94, 49);
            this.button16.TabIndex = 6;
            this.button16.Text = "돈까스";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(16, 20);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(94, 49);
            this.button17.TabIndex = 5;
            this.button17.Text = "오므라이스";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // Bunsik
            // 
            this.Bunsik.Controls.Add(this.button23);
            this.Bunsik.Controls.Add(this.button24);
            this.Bunsik.Controls.Add(this.button25);
            this.Bunsik.Controls.Add(this.button13);
            this.Bunsik.Controls.Add(this.button18);
            this.Bunsik.Controls.Add(this.button19);
            this.Bunsik.Controls.Add(this.button20);
            this.Bunsik.Controls.Add(this.button21);
            this.Bunsik.Controls.Add(this.button22);
            this.Bunsik.Location = new System.Drawing.Point(4, 27);
            this.Bunsik.Name = "Bunsik";
            this.Bunsik.Size = new System.Drawing.Size(338, 243);
            this.Bunsik.TabIndex = 3;
            this.Bunsik.Text = "분식";
            this.Bunsik.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(227, 85);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 49);
            this.button13.TabIndex = 16;
            this.button13.Text = "비빔국수";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(120, 85);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(94, 49);
            this.button18.TabIndex = 15;
            this.button18.Text = "떡만두국";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(16, 85);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(94, 49);
            this.button19.TabIndex = 14;
            this.button19.Text = "만두";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(227, 18);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(94, 49);
            this.button20.TabIndex = 13;
            this.button20.Text = "쫄면";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(120, 18);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(94, 49);
            this.button21.TabIndex = 12;
            this.button21.Text = "라면";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(16, 18);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(94, 49);
            this.button22.TabIndex = 11;
            this.button22.Text = "떡볶이";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // Side
            // 
            this.Side.Controls.Add(this.button26);
            this.Side.Controls.Add(this.button27);
            this.Side.Controls.Add(this.button28);
            this.Side.Controls.Add(this.button29);
            this.Side.Controls.Add(this.button30);
            this.Side.Controls.Add(this.button31);
            this.Side.Controls.Add(this.button32);
            this.Side.Location = new System.Drawing.Point(4, 27);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(338, 243);
            this.Side.TabIndex = 4;
            this.Side.Text = "사이드 및 음료";
            this.Side.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TimerDate
            // 
            this.TimerDate.AutoSize = true;
            this.TimerDate.Location = new System.Drawing.Point(644, 31);
            this.TimerDate.Name = "TimerDate";
            this.TimerDate.Size = new System.Drawing.Size(131, 12);
            this.TimerDate.TabIndex = 15;
            this.TimerDate.Text = "2024년 6월 12일 수요일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 시간:";
            // 
            // TimerTime
            // 
            this.TimerTime.AutoSize = true;
            this.TimerTime.Location = new System.Drawing.Point(698, 59);
            this.TimerTime.Name = "TimerTime";
            this.TimerTime.Size = new System.Drawing.Size(75, 12);
            this.TimerTime.TabIndex = 16;
            this.TimerTime.Text = "오후 2:00::00";
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(227, 152);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(94, 49);
            this.button23.TabIndex = 19;
            this.button23.Text = "오뎅탕";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(120, 152);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(94, 49);
            this.button24.TabIndex = 18;
            this.button24.Text = "라볶이";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(16, 152);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(94, 49);
            this.button25.TabIndex = 17;
            this.button25.Text = "김치말이";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(16, 151);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(94, 49);
            this.button26.TabIndex = 18;
            this.button26.Text = "환타";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(227, 86);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(94, 49);
            this.button27.TabIndex = 17;
            this.button27.Text = "사이다";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(120, 86);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(94, 49);
            this.button28.TabIndex = 16;
            this.button28.Text = "콜라";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(16, 86);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(94, 49);
            this.button29.TabIndex = 15;
            this.button29.Text = "슬라이스치즈";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(227, 19);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(94, 49);
            this.button30.TabIndex = 14;
            this.button30.Text = "계란후라이";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button31.Location = new System.Drawing.Point(120, 19);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(94, 49);
            this.button31.TabIndex = 13;
            this.button31.Text = "1/2 우동";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(16, 19);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(94, 49);
            this.button32.TabIndex = 12;
            this.button32.Text = "공기밥";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // MenuPic
            // 
            this.MenuPic.Location = new System.Drawing.Point(385, 44);
            this.MenuPic.Name = "MenuPic";
            this.MenuPic.Size = new System.Drawing.Size(313, 178);
            this.MenuPic.TabIndex = 5;
            this.MenuPic.TabStop = false;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(626, 240);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(72, 29);
            this.DelBtn.TabIndex = 5;
            this.DelBtn.Text = "메뉴삭제";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // MenuName
            // 
            this.MenuName.Location = new System.Drawing.Point(385, 248);
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(146, 21);
            this.MenuName.TabIndex = 6;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(546, 240);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(72, 29);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "메뉴추가";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimerTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.label3);
            this.Name = "MenuForm";
            this.Text = "메뉴관리";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuTab.ResumeLayout(false);
            this.Kimbab.ResumeLayout(false);
            this.KoreanFood.ResumeLayout(false);
            this.WesternFood.ResumeLayout(false);
            this.Bunsik.ResumeLayout(false);
            this.Side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl menuTab;
        private System.Windows.Forms.TabPage Kimbab;
        private System.Windows.Forms.TabPage KoreanFood;
        private System.Windows.Forms.TabPage WesternFood;
        private System.Windows.Forms.TabPage Bunsik;
        private System.Windows.Forms.TabPage Side;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label TimerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimerTime;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button Gimbab5;
        private System.Windows.Forms.Button Gimbab4;
        private System.Windows.Forms.Button Gimbab3;
        private System.Windows.Forms.Button Gimbab2;
        private System.Windows.Forms.Button Gimbab1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox MenuName;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.PictureBox MenuPic;
    }
}
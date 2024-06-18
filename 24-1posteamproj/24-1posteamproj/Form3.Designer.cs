namespace _24_1posteamproj
{
    partial class StokForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "김밥",
            "100",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "치즈",
            "500",
            "매주 월요일 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "캔참치",
            "100",
            "매월 둘째주 월요일에 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "날치알",
            "2",
            "매월 둘째주 월요일에 5개 발주 "}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "제육",
            "200",
            "매월 둘째주, 넷째주 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "불고기",
            "97",
            "59인분 이하 시 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "낙지",
            "39",
            "재고 10인분 이하, 발주 넣기"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "돈까스",
            "512",
            "50장 미만일 경우 발주 넣기"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "생선까스",
            "25",
            "재고 10인분 이하시 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "고치돈",
            "152",
            "매주 월요일 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "라면",
            "55",
            "매주 월요일 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "떡볶이",
            "67",
            "6/12 발주 신청 완료"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "쫄면",
            "29",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "만두",
            "280",
            "6/15 추가 발주 도착"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "소면",
            "80",
            "매월에 1번 발주 신청"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "어묵",
            "9",
            "발주 신청 필요"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "사이다",
            "12",
            "재고 10개 이하 발주"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "콜라",
            "120",
            "80미만일 시 발주 신청"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "환타",
            "180",
            "80개 미만일 시 발주 신청"}, -1);
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer1Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer1Date = new System.Windows.Forms.Label();
            this.ItemGroup = new System.Windows.Forms.GroupBox();
            this.ItemEdit = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OtherTxt = new System.Windows.Forms.TextBox();
            this.ItemList = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemOthers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EndBtn = new System.Windows.Forms.Button();
            this.ItemGroup.SuspendLayout();
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
            this.label3.Text = "응소실 POS 재고 관리";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer1Time
            // 
            this.Timer1Time.AutoSize = true;
            this.Timer1Time.Location = new System.Drawing.Point(698, 59);
            this.Timer1Time.Name = "Timer1Time";
            this.Timer1Time.Size = new System.Drawing.Size(75, 12);
            this.Timer1Time.TabIndex = 19;
            this.Timer1Time.Text = "오후 2:00::00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "현재 시간:";
            // 
            // Timer1Date
            // 
            this.Timer1Date.AutoSize = true;
            this.Timer1Date.Location = new System.Drawing.Point(644, 31);
            this.Timer1Date.Name = "Timer1Date";
            this.Timer1Date.Size = new System.Drawing.Size(131, 12);
            this.Timer1Date.TabIndex = 18;
            this.Timer1Date.Text = "2024년 6월 12일 수요일";
            // 
            // ItemGroup
            // 
            this.ItemGroup.Controls.Add(this.ItemEdit);
            this.ItemGroup.Controls.Add(this.SearchBtn);
            this.ItemGroup.Controls.Add(this.SearchTxt);
            this.ItemGroup.Controls.Add(this.label6);
            this.ItemGroup.Controls.Add(this.OtherTxt);
            this.ItemGroup.Controls.Add(this.ItemList);
            this.ItemGroup.Controls.Add(this.CountTxt);
            this.ItemGroup.Controls.Add(this.label4);
            this.ItemGroup.Controls.Add(this.label2);
            this.ItemGroup.Controls.Add(this.NameTxt);
            this.ItemGroup.Controls.Add(this.label5);
            this.ItemGroup.Location = new System.Drawing.Point(16, 84);
            this.ItemGroup.Name = "ItemGroup";
            this.ItemGroup.Size = new System.Drawing.Size(759, 316);
            this.ItemGroup.TabIndex = 20;
            this.ItemGroup.TabStop = false;
            this.ItemGroup.Text = "재고 관리";
            // 
            // ItemEdit
            // 
            this.ItemEdit.Location = new System.Drawing.Point(640, 50);
            this.ItemEdit.Name = "ItemEdit";
            this.ItemEdit.Size = new System.Drawing.Size(95, 23);
            this.ItemEdit.TabIndex = 31;
            this.ItemEdit.Text = "재고 수정";
            this.ItemEdit.UseVisualStyleBackColor = true;
            this.ItemEdit.Click += new System.EventHandler(this.ItemEdit_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(640, 19);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(95, 23);
            this.SearchBtn.TabIndex = 30;
            this.SearchBtn.Text = "재고 검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(74, 21);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(548, 21);
            this.SearchTxt.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F);
            this.label6.Location = new System.Drawing.Point(26, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "검색: ";
            // 
            // OtherTxt
            // 
            this.OtherTxt.Location = new System.Drawing.Point(397, 52);
            this.OtherTxt.Name = "OtherTxt";
            this.OtherTxt.Size = new System.Drawing.Size(225, 21);
            this.OtherTxt.TabIndex = 27;
            // 
            // ItemList
            // 
            this.ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemCount,
            this.ItemOthers});
            this.ItemList.Font = new System.Drawing.Font("굴림", 10F);
            this.ItemList.FullRowSelect = true;
            this.ItemList.GridLines = true;
            this.ItemList.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            this.ItemList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19});
            this.ItemList.Location = new System.Drawing.Point(8, 79);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(743, 231);
            this.ItemList.TabIndex = 21;
            this.ItemList.UseCompatibleStateImageBehavior = false;
            this.ItemList.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "재고 이름";
            this.ItemName.Width = 194;
            // 
            // ItemCount
            // 
            this.ItemCount.Text = "재고 수량";
            this.ItemCount.Width = 143;
            // 
            // ItemOthers
            // 
            this.ItemOthers.Text = "비고";
            this.ItemOthers.Width = 368;
            // 
            // CountTxt
            // 
            this.CountTxt.Location = new System.Drawing.Point(258, 52);
            this.CountTxt.Name = "CountTxt";
            this.CountTxt.Size = new System.Drawing.Size(84, 21);
            this.CountTxt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(211, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "수량:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "재고명:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(74, 52);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(130, 21);
            this.NameTxt.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(350, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "비고";
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(681, 409);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(108, 29);
            this.EndBtn.TabIndex = 1;
            this.EndBtn.Text = "완료";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.ItemGroup);
            this.Controls.Add(this.Timer1Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Timer1Date);
            this.Controls.Add(this.label3);
            this.Name = "StokForm";
            this.Text = "재고관리";
            this.Load += new System.EventHandler(this.StokForm_Load);
            this.ItemGroup.ResumeLayout(false);
            this.ItemGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Timer1Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Timer1Date;
        private System.Windows.Forms.GroupBox ItemGroup;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.ListView ItemList;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemCount;
        private System.Windows.Forms.ColumnHeader ItemOthers;
        private System.Windows.Forms.Button ItemEdit;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OtherTxt;
        private System.Windows.Forms.TextBox CountTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
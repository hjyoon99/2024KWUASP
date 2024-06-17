namespace _24_1posteamproj
{
    partial class MemberForm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "홍길동",
            "010-1234-1234",
            "1,320"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "02",
            "가나다",
            "010-1234-5678",
            "970"}, -1);
            this.labelTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.lvMember = new System.Windows.Forms.ListView();
            this.memberNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.Location = new System.Drawing.Point(12, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 19);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "응소실 POS 회원 관리";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 97);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "이름";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(207, 97);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(53, 12);
            this.lbPhone.TabIndex = 16;
            this.lbPhone.Text = "전화번호";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(49, 92);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(129, 21);
            this.nameInput.TabIndex = 17;
            this.nameInput.TextChanged += new System.EventHandler(this.WhenTextChanged);
            this.nameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_OnlyString);
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(266, 92);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(176, 21);
            this.phoneInput.TabIndex = 18;
            this.phoneInput.TextChanged += new System.EventHandler(this.WhenTextChanged);
            this.phoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_OnlyNumber);
            this.phoneInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Phone_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(496, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(719, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.HandleDeletBtn);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(646, 92);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.HandleEditBtn);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(569, 92);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(57, 23);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "생성";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(644, 31);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(131, 12);
            this.txtDate.TabIndex = 23;
            this.txtDate.Text = "2024년 6월 12일 수요일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "현재 시간:";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Location = new System.Drawing.Point(698, 59);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(75, 12);
            this.txtTime.TabIndex = 25;
            this.txtTime.Text = "오후 2:00::00";
            // 
            // lvMember
            // 
            this.lvMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.memberNum,
            this.memberName,
            this.memberPhone,
            this.memberPoint});
            this.lvMember.FullRowSelect = true;
            this.lvMember.HideSelection = false;
            this.lvMember.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvMember.Location = new System.Drawing.Point(16, 137);
            this.lvMember.Name = "lvMember";
            this.lvMember.Size = new System.Drawing.Size(757, 281);
            this.lvMember.TabIndex = 26;
            this.lvMember.UseCompatibleStateImageBehavior = false;
            this.lvMember.View = System.Windows.Forms.View.Details;
            this.lvMember.SelectedIndexChanged += new System.EventHandler(this.WhenItemSelected);
            // 
            // memberNum
            // 
            this.memberNum.Text = "회원번호";
            this.memberNum.Width = 152;
            // 
            // memberName
            // 
            this.memberName.Text = "이름";
            this.memberName.Width = 148;
            // 
            // memberPhone
            // 
            this.memberPhone.Text = "전화번호";
            this.memberPhone.Width = 253;
            // 
            // memberPoint
            // 
            this.memberPoint.Text = "적립내역";
            this.memberPoint.Width = 195;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_curTime_Tick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(683, 424);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "돌아가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.openMainForm);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvMember);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.labelTitle);
            this.Name = "MemberForm";
            this.Text = "회원 관리";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.ListView lvMember;
        private System.Windows.Forms.ColumnHeader memberNum;
        private System.Windows.Forms.ColumnHeader memberName;
        private System.Windows.Forms.ColumnHeader memberPhone;
        private System.Windows.Forms.ColumnHeader memberPoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBack;
    }
}
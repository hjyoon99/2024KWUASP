namespace _24_1posteamproj
{
    partial class salesForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "17",
            "2024-06-17 15:32",
            "김밥 1, 라면 1, 우동 1",
            "16,500"}, -1);
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.lvSales = new System.Windows.Forms.ListView();
            this.salesNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAllSales = new System.Windows.Forms.Button();
            this.btnSalesOfItem = new System.Windows.Forms.Button();
            this.btnSalesOfTime = new System.Windows.Forms.Button();
            this.btnSalesOfDate = new System.Windows.Forms.Button();
            this.lbTargetDate = new System.Windows.Forms.Label();
            this.lbTotalSales = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.selectedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(18, 56);
            this.calender.MaxSelectionCount = 1;
            this.calender.Name = "calender";
            this.calender.TabIndex = 0;
            this.calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.handleDateSelected);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.Location = new System.Drawing.Point(12, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 19);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "응소실 POS 매출 관리";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(644, 31);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(131, 12);
            this.txtDate.TabIndex = 24;
            this.txtDate.Text = "2024년 6월 12일 수요일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "현재 시간:";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Location = new System.Drawing.Point(698, 59);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(75, 12);
            this.txtTime.TabIndex = 26;
            this.txtTime.Text = "오후 2:00::00";
            // 
            // lvSales
            // 
            this.lvSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.salesNum,
            this.salesDate,
            this.salesItem,
            this.salesPrice});
            this.lvSales.FullRowSelect = true;
            this.lvSales.HideSelection = false;
            this.lvSales.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvSales.Location = new System.Drawing.Point(250, 118);
            this.lvSales.Name = "lvSales";
            this.lvSales.Size = new System.Drawing.Size(525, 275);
            this.lvSales.TabIndex = 27;
            this.lvSales.UseCompatibleStateImageBehavior = false;
            this.lvSales.View = System.Windows.Forms.View.Details;
            // 
            // salesNum
            // 
            this.salesNum.Text = "No.";
            this.salesNum.Width = 47;
            // 
            // salesDate
            // 
            this.salesDate.Text = "일시";
            this.salesDate.Width = 118;
            // 
            // salesItem
            // 
            this.salesItem.Text = "품목 및 수량";
            this.salesItem.Width = 277;
            // 
            // salesPrice
            // 
            this.salesPrice.Text = "매출";
            this.salesPrice.Width = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 21);
            this.textBox1.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(473, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAllSales
            // 
            this.btnAllSales.Location = new System.Drawing.Point(18, 252);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Size = new System.Drawing.Size(220, 36);
            this.btnAllSales.TabIndex = 30;
            this.btnAllSales.Text = "전체 매출 세부내역";
            this.btnAllSales.UseVisualStyleBackColor = true;
            this.btnAllSales.Click += new System.EventHandler(this.DefaultSales);
            // 
            // btnSalesOfItem
            // 
            this.btnSalesOfItem.Location = new System.Drawing.Point(18, 378);
            this.btnSalesOfItem.Name = "btnSalesOfItem";
            this.btnSalesOfItem.Size = new System.Drawing.Size(220, 36);
            this.btnSalesOfItem.TabIndex = 31;
            this.btnSalesOfItem.Text = "품목별 매출 통계";
            this.btnSalesOfItem.UseVisualStyleBackColor = true;
            this.btnSalesOfItem.Click += new System.EventHandler(this.SalesPerMenu);
            // 
            // btnSalesOfTime
            // 
            this.btnSalesOfTime.Location = new System.Drawing.Point(18, 336);
            this.btnSalesOfTime.Name = "btnSalesOfTime";
            this.btnSalesOfTime.Size = new System.Drawing.Size(220, 36);
            this.btnSalesOfTime.TabIndex = 32;
            this.btnSalesOfTime.Text = "시간대별 매출 통계";
            this.btnSalesOfTime.UseVisualStyleBackColor = true;
            this.btnSalesOfTime.Click += new System.EventHandler(this.SalesPerTime);
            // 
            // btnSalesOfDate
            // 
            this.btnSalesOfDate.Location = new System.Drawing.Point(18, 294);
            this.btnSalesOfDate.Name = "btnSalesOfDate";
            this.btnSalesOfDate.Size = new System.Drawing.Size(220, 36);
            this.btnSalesOfDate.TabIndex = 33;
            this.btnSalesOfDate.Text = "날짜별 매출";
            this.btnSalesOfDate.UseVisualStyleBackColor = true;
            this.btnSalesOfDate.Click += new System.EventHandler(this.SalesPerDate);
            // 
            // lbTargetDate
            // 
            this.lbTargetDate.AutoSize = true;
            this.lbTargetDate.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTargetDate.Location = new System.Drawing.Point(271, 403);
            this.lbTargetDate.Name = "lbTargetDate";
            this.lbTargetDate.Size = new System.Drawing.Size(196, 15);
            this.lbTargetDate.TabIndex = 34;
            this.lbTargetDate.Text = "2024년 6월 17일 총 매출:";
            // 
            // lbTotalSales
            // 
            this.lbTotalSales.AutoSize = true;
            this.lbTotalSales.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTotalSales.Location = new System.Drawing.Point(473, 403);
            this.lbTotalSales.Name = "lbTotalSales";
            this.lbTotalSales.Size = new System.Drawing.Size(58, 15);
            this.lbTotalSales.TabIndex = 35;
            this.lbTotalSales.Text = "16,500";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(682, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 23);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "돌아가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.openMainForm);
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(682, 89);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(93, 23);
            this.btnRefund.TabIndex = 37;
            this.btnRefund.Text = "환불처리";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.HandleRefundBtn);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_curTime_Tick);
            // 
            // selectedDate
            // 
            this.selectedDate.AutoSize = true;
            this.selectedDate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectedDate.Location = new System.Drawing.Point(91, 226);
            this.selectedDate.Name = "selectedDate";
            this.selectedDate.Size = new System.Drawing.Size(87, 13);
            this.selectedDate.TabIndex = 39;
            this.selectedDate.Text = "2024-16-17";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "선택 날짜:";
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedDate);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTotalSales);
            this.Controls.Add(this.lbTargetDate);
            this.Controls.Add(this.btnSalesOfDate);
            this.Controls.Add(this.btnSalesOfTime);
            this.Controls.Add(this.btnSalesOfItem);
            this.Controls.Add(this.btnAllSales);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvSales);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.calender);
            this.Name = "salesForm";
            this.Text = "매출 관리";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.ListView lvSales;
        private System.Windows.Forms.ColumnHeader salesNum;
        private System.Windows.Forms.ColumnHeader salesDate;
        private System.Windows.Forms.ColumnHeader salesItem;
        private System.Windows.Forms.ColumnHeader salesPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAllSales;
        private System.Windows.Forms.Button btnSalesOfItem;
        private System.Windows.Forms.Button btnSalesOfTime;
        private System.Windows.Forms.Button btnSalesOfDate;
        private System.Windows.Forms.Label lbTargetDate;
        private System.Windows.Forms.Label lbTotalSales;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label selectedDate;
        private System.Windows.Forms.Label label3;
    }
}
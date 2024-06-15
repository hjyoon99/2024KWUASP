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
            this.menuTab = new System.Windows.Forms.TabControl();
            this.Kimbab = new System.Windows.Forms.TabPage();
            this.KoreanFood = new System.Windows.Forms.TabPage();
            this.WesternFood = new System.Windows.Forms.TabPage();
            this.Bunsik = new System.Windows.Forms.TabPage();
            this.Side = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TimerDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerTime = new System.Windows.Forms.Label();
            this.EndBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuTab.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.EndBtn);
            this.groupBox1.Controls.Add(this.menuTab);
            this.groupBox1.Location = new System.Drawing.Point(20, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 362);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴";
            // 
            // menuTab
            // 
            this.menuTab.Controls.Add(this.Kimbab);
            this.menuTab.Controls.Add(this.KoreanFood);
            this.menuTab.Controls.Add(this.WesternFood);
            this.menuTab.Controls.Add(this.Bunsik);
            this.menuTab.Controls.Add(this.Side);
            this.menuTab.Location = new System.Drawing.Point(11, 17);
            this.menuTab.Name = "menuTab";
            this.menuTab.SelectedIndex = 0;
            this.menuTab.Size = new System.Drawing.Size(435, 339);
            this.menuTab.TabIndex = 0;
            // 
            // Kimbab
            // 
            this.Kimbab.Location = new System.Drawing.Point(4, 22);
            this.Kimbab.Name = "Kimbab";
            this.Kimbab.Padding = new System.Windows.Forms.Padding(3);
            this.Kimbab.Size = new System.Drawing.Size(427, 313);
            this.Kimbab.TabIndex = 0;
            this.Kimbab.Text = "김밥";
            this.Kimbab.UseVisualStyleBackColor = true;
            // 
            // KoreanFood
            // 
            this.KoreanFood.Location = new System.Drawing.Point(4, 22);
            this.KoreanFood.Name = "KoreanFood";
            this.KoreanFood.Padding = new System.Windows.Forms.Padding(3);
            this.KoreanFood.Size = new System.Drawing.Size(427, 313);
            this.KoreanFood.TabIndex = 1;
            this.KoreanFood.Text = "한식";
            this.KoreanFood.UseVisualStyleBackColor = true;
            // 
            // WesternFood
            // 
            this.WesternFood.Location = new System.Drawing.Point(4, 22);
            this.WesternFood.Name = "WesternFood";
            this.WesternFood.Size = new System.Drawing.Size(427, 313);
            this.WesternFood.TabIndex = 2;
            this.WesternFood.Text = "양식";
            this.WesternFood.UseVisualStyleBackColor = true;
            // 
            // Bunsik
            // 
            this.Bunsik.Location = new System.Drawing.Point(4, 22);
            this.Bunsik.Name = "Bunsik";
            this.Bunsik.Size = new System.Drawing.Size(427, 313);
            this.Bunsik.TabIndex = 3;
            this.Bunsik.Text = "분식";
            this.Bunsik.UseVisualStyleBackColor = true;
            // 
            // Side
            // 
            this.Side.Location = new System.Drawing.Point(4, 22);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(427, 313);
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
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(652, 329);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 0;
            this.EndBtn.Text = "완료";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
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
            this.Controls.Add(this.label3);
            this.Name = "MenuForm";
            this.Text = "메뉴관리";
            this.groupBox1.ResumeLayout(false);
            this.menuTab.ResumeLayout(false);
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
    }
}
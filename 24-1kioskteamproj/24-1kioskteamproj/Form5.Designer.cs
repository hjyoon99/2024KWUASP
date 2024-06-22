namespace _24_1kioskteamproj
{
    partial class Form5
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
            this.InitialPoint = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMemberButton = new System.Windows.Forms.Button();
            this.PointLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InitialPoint
            // 
            this.InitialPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialPoint.AutoSize = true;
            this.InitialPoint.Font = new System.Drawing.Font("맑은 고딕", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InitialPoint.Location = new System.Drawing.Point(296, 57);
            this.InitialPoint.Name = "InitialPoint";
            this.InitialPoint.Size = new System.Drawing.Size(349, 78);
            this.InitialPoint.TabIndex = 0;
            this.InitialPoint.Text = "포인트 적립";
            this.InitialPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(170, 249);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(517, 35);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "전화번호 :";
            // 
            // checkMemberButton
            // 
            this.checkMemberButton.Location = new System.Drawing.Point(737, 243);
            this.checkMemberButton.Name = "checkMemberButton";
            this.checkMemberButton.Size = new System.Drawing.Size(141, 43);
            this.checkMemberButton.TabIndex = 4;
            this.checkMemberButton.Text = "조회하기";
            this.checkMemberButton.UseVisualStyleBackColor = true;
            this.checkMemberButton.Click += new System.EventHandler(this.checkMemberButton_Click);
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Font = new System.Drawing.Font("굴림", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PointLabel.Location = new System.Drawing.Point(220, 472);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(467, 29);
            this.PointLabel.TabIndex = 5;
            this.PointLabel.Text = "이름 :            포인트 :            점";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 713);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.checkMemberButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.InitialPoint);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InitialPoint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkMemberButton;
        private System.Windows.Forms.Label PointLabel;
    }
}
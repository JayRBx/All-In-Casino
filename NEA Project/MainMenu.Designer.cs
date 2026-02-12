namespace NEA_Project
{
    partial class MainMenu
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
            this.gameSelectorBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.accountBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountStatusTxt = new System.Windows.Forms.Label();
            this.balancePnl = new System.Windows.Forms.Panel();
            this.balanceTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.balancePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameSelectorBtn
            // 
            this.gameSelectorBtn.BackColor = System.Drawing.Color.DarkRed;
            this.gameSelectorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gameSelectorBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.gameSelectorBtn.FlatAppearance.BorderSize = 0;
            this.gameSelectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameSelectorBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSelectorBtn.ForeColor = System.Drawing.Color.Black;
            this.gameSelectorBtn.Location = new System.Drawing.Point(62, 275);
            this.gameSelectorBtn.Name = "gameSelectorBtn";
            this.gameSelectorBtn.Size = new System.Drawing.Size(350, 100);
            this.gameSelectorBtn.TabIndex = 0;
            this.gameSelectorBtn.Text = "Game Selector";
            this.gameSelectorBtn.UseVisualStyleBackColor = false;
            this.gameSelectorBtn.Click += new System.EventHandler(this.gameSelectorClk);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Black;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.settingsBtn.Location = new System.Drawing.Point(62, 415);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(350, 100);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsClk);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.quitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(1204, 12);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(48, 50);
            this.quitBtn.TabIndex = 0;
            this.quitBtn.Text = "X";
            this.quitBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitClk);
            // 
            // accountBtn
            // 
            this.accountBtn.BackColor = System.Drawing.Color.DarkRed;
            this.accountBtn.FlatAppearance.BorderSize = 0;
            this.accountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBtn.ForeColor = System.Drawing.Color.Black;
            this.accountBtn.Location = new System.Drawing.Point(62, 553);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(350, 100);
            this.accountBtn.TabIndex = 0;
            this.accountBtn.Text = "Account Management";
            this.accountBtn.UseVisualStyleBackColor = false;
            this.accountBtn.Click += new System.EventHandler(this.accountsClk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NEA_Project.Properties.Resources._99cd96d0_fb10_4b4c_b92b_be256ddc6e662;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 270);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // accountStatusTxt
            // 
            this.accountStatusTxt.AutoSize = true;
            this.accountStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.accountStatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountStatusTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.accountStatusTxt.Location = new System.Drawing.Point(12, 656);
            this.accountStatusTxt.Name = "accountStatusTxt";
            this.accountStatusTxt.Size = new System.Drawing.Size(177, 18);
            this.accountStatusTxt.TabIndex = 3;
            this.accountStatusTxt.Text = "Currently not signed in";
            // 
            // balancePnl
            // 
            this.balancePnl.BackColor = System.Drawing.Color.Gold;
            this.balancePnl.Controls.Add(this.balanceTxt);
            this.balancePnl.Location = new System.Drawing.Point(1073, 623);
            this.balancePnl.Name = "balancePnl";
            this.balancePnl.Size = new System.Drawing.Size(179, 46);
            this.balancePnl.TabIndex = 4;
            // 
            // balanceTxt
            // 
            this.balanceTxt.AutoSize = true;
            this.balanceTxt.BackColor = System.Drawing.Color.Transparent;
            this.balanceTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTxt.Location = new System.Drawing.Point(14, 13);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.Size = new System.Drawing.Size(115, 22);
            this.balanceTxt.TabIndex = 0;
            this.balanceTxt.Text = "Balance: N/A";
            this.balanceTxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::NEA_Project.Properties.Resources.mainmenu_bg_1_;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.balancePnl);
            this.Controls.Add(this.accountStatusTxt);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.gameSelectorBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.balancePnl.ResumeLayout(false);
            this.balancePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameSelectorBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button accountBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel balancePnl;
        public System.Windows.Forms.Label accountStatusTxt;
        public System.Windows.Forms.Label balanceTxt;
    }
}


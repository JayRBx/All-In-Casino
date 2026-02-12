namespace NEA_Project
{
    partial class BlackJack
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
            this.balancePnl = new System.Windows.Forms.Panel();
            this.balanceTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountStatusTxt = new System.Windows.Forms.Label();
            this.pcnt75Btn = new System.Windows.Forms.Button();
            this.pcnt10Btn = new System.Windows.Forms.Button();
            this.pcnt25Btn = new System.Windows.Forms.Button();
            this.allInBtn = new System.Windows.Forms.Button();
            this.gambleAmountPnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bettingAmountBox = new System.Windows.Forms.TextBox();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.pcnt50Btn = new System.Windows.Forms.Button();
            this.betBtn = new System.Windows.Forms.Button();
            this.bettingPnl = new System.Windows.Forms.Panel();
            this.betPnl = new System.Windows.Forms.Panel();
            this.betDisplayPnl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.betAmountLbl = new System.Windows.Forms.Label();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.balancePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gambleAmountPnl.SuspendLayout();
            this.bettingPnl.SuspendLayout();
            this.betPnl.SuspendLayout();
            this.betDisplayPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // balancePnl
            // 
            this.balancePnl.BackColor = System.Drawing.Color.Gold;
            this.balancePnl.Controls.Add(this.balanceTxt);
            this.balancePnl.Location = new System.Drawing.Point(1073, 623);
            this.balancePnl.Name = "balancePnl";
            this.balancePnl.Size = new System.Drawing.Size(179, 46);
            this.balancePnl.TabIndex = 5;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::NEA_Project.Properties.Resources.blackjacklogo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 186);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // accountStatusTxt
            // 
            this.accountStatusTxt.AutoSize = true;
            this.accountStatusTxt.BackColor = System.Drawing.Color.Transparent;
            this.accountStatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountStatusTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.accountStatusTxt.Location = new System.Drawing.Point(12, 654);
            this.accountStatusTxt.Name = "accountStatusTxt";
            this.accountStatusTxt.Size = new System.Drawing.Size(177, 18);
            this.accountStatusTxt.TabIndex = 8;
            this.accountStatusTxt.Text = "Currently not signed in";
            // 
            // pcnt75Btn
            // 
            this.pcnt75Btn.BackColor = System.Drawing.Color.Black;
            this.pcnt75Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcnt75Btn.FlatAppearance.BorderSize = 0;
            this.pcnt75Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcnt75Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcnt75Btn.ForeColor = System.Drawing.Color.DarkRed;
            this.pcnt75Btn.Location = new System.Drawing.Point(20, 102);
            this.pcnt75Btn.Name = "pcnt75Btn";
            this.pcnt75Btn.Size = new System.Drawing.Size(56, 24);
            this.pcnt75Btn.TabIndex = 10;
            this.pcnt75Btn.Text = "75%";
            this.pcnt75Btn.UseVisualStyleBackColor = false;
            this.pcnt75Btn.Click += new System.EventHandler(this.pcnt75Btn_Click);
            // 
            // pcnt10Btn
            // 
            this.pcnt10Btn.BackColor = System.Drawing.Color.Black;
            this.pcnt10Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcnt10Btn.FlatAppearance.BorderSize = 0;
            this.pcnt10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcnt10Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcnt10Btn.ForeColor = System.Drawing.Color.DarkRed;
            this.pcnt10Btn.Location = new System.Drawing.Point(20, 72);
            this.pcnt10Btn.Name = "pcnt10Btn";
            this.pcnt10Btn.Size = new System.Drawing.Size(56, 24);
            this.pcnt10Btn.TabIndex = 10;
            this.pcnt10Btn.Text = "10%";
            this.pcnt10Btn.UseVisualStyleBackColor = false;
            this.pcnt10Btn.Click += new System.EventHandler(this.pcnt10Btn_Click);
            // 
            // pcnt25Btn
            // 
            this.pcnt25Btn.BackColor = System.Drawing.Color.Black;
            this.pcnt25Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcnt25Btn.FlatAppearance.BorderSize = 0;
            this.pcnt25Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcnt25Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcnt25Btn.ForeColor = System.Drawing.Color.DarkRed;
            this.pcnt25Btn.Location = new System.Drawing.Point(82, 72);
            this.pcnt25Btn.Name = "pcnt25Btn";
            this.pcnt25Btn.Size = new System.Drawing.Size(56, 24);
            this.pcnt25Btn.TabIndex = 10;
            this.pcnt25Btn.Text = "25%";
            this.pcnt25Btn.UseVisualStyleBackColor = false;
            this.pcnt25Btn.Click += new System.EventHandler(this.pcnt25Btn_Click);
            // 
            // allInBtn
            // 
            this.allInBtn.BackColor = System.Drawing.Color.Black;
            this.allInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allInBtn.FlatAppearance.BorderSize = 0;
            this.allInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allInBtn.ForeColor = System.Drawing.Color.Gold;
            this.allInBtn.Location = new System.Drawing.Point(82, 102);
            this.allInBtn.Name = "allInBtn";
            this.allInBtn.Size = new System.Drawing.Size(118, 24);
            this.allInBtn.TabIndex = 10;
            this.allInBtn.Text = "ALL IN";
            this.allInBtn.UseVisualStyleBackColor = false;
            this.allInBtn.Click += new System.EventHandler(this.allInBtn_Click);
            // 
            // gambleAmountPnl
            // 
            this.gambleAmountPnl.BackColor = System.Drawing.Color.DarkRed;
            this.gambleAmountPnl.Controls.Add(this.panel2);
            this.gambleAmountPnl.Controls.Add(this.bettingAmountBox);
            this.gambleAmountPnl.Controls.Add(this.currencyLbl);
            this.gambleAmountPnl.Location = new System.Drawing.Point(20, 19);
            this.gambleAmountPnl.Name = "gambleAmountPnl";
            this.gambleAmountPnl.Size = new System.Drawing.Size(180, 47);
            this.gambleAmountPnl.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(-17, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 186);
            this.panel2.TabIndex = 11;
            // 
            // bettingAmountBox
            // 
            this.bettingAmountBox.BackColor = System.Drawing.Color.DarkRed;
            this.bettingAmountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bettingAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettingAmountBox.ForeColor = System.Drawing.Color.Black;
            this.bettingAmountBox.Location = new System.Drawing.Point(38, 8);
            this.bettingAmountBox.Name = "bettingAmountBox";
            this.bettingAmountBox.Size = new System.Drawing.Size(152, 31);
            this.bettingAmountBox.TabIndex = 3;
            this.bettingAmountBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bettingAmountBox_KeyPress);
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.BackColor = System.Drawing.Color.Transparent;
            this.currencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLbl.Location = new System.Drawing.Point(12, 8);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(29, 31);
            this.currencyLbl.TabIndex = 10;
            this.currencyLbl.Text = "£";
            // 
            // pcnt50Btn
            // 
            this.pcnt50Btn.BackColor = System.Drawing.Color.Black;
            this.pcnt50Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcnt50Btn.FlatAppearance.BorderSize = 0;
            this.pcnt50Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcnt50Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcnt50Btn.ForeColor = System.Drawing.Color.DarkRed;
            this.pcnt50Btn.Location = new System.Drawing.Point(144, 72);
            this.pcnt50Btn.Name = "pcnt50Btn";
            this.pcnt50Btn.Size = new System.Drawing.Size(56, 24);
            this.pcnt50Btn.TabIndex = 10;
            this.pcnt50Btn.Text = "50%";
            this.pcnt50Btn.UseVisualStyleBackColor = false;
            this.pcnt50Btn.Click += new System.EventHandler(this.pcnt50Btn_Click);
            // 
            // betBtn
            // 
            this.betBtn.BackColor = System.Drawing.Color.DarkRed;
            this.betBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.betBtn.FlatAppearance.BorderSize = 0;
            this.betBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.betBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betBtn.ForeColor = System.Drawing.Color.Black;
            this.betBtn.Location = new System.Drawing.Point(20, 132);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(180, 47);
            this.betBtn.TabIndex = 10;
            this.betBtn.Text = "Bet";
            this.betBtn.UseVisualStyleBackColor = false;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // bettingPnl
            // 
            this.bettingPnl.BackColor = System.Drawing.Color.Transparent;
            this.bettingPnl.Controls.Add(this.betBtn);
            this.bettingPnl.Controls.Add(this.pcnt50Btn);
            this.bettingPnl.Controls.Add(this.gambleAmountPnl);
            this.bettingPnl.Controls.Add(this.allInBtn);
            this.bettingPnl.Controls.Add(this.pcnt25Btn);
            this.bettingPnl.Controls.Add(this.pcnt10Btn);
            this.bettingPnl.Controls.Add(this.pcnt75Btn);
            this.bettingPnl.Location = new System.Drawing.Point(369, 13);
            this.bettingPnl.Name = "bettingPnl";
            this.bettingPnl.Size = new System.Drawing.Size(220, 186);
            this.bettingPnl.TabIndex = 11;
            // 
            // betPnl
            // 
            this.betPnl.BackColor = System.Drawing.Color.Transparent;
            this.betPnl.Controls.Add(this.betDisplayPnl);
            this.betPnl.Location = new System.Drawing.Point(369, 13);
            this.betPnl.Name = "betPnl";
            this.betPnl.Size = new System.Drawing.Size(220, 186);
            this.betPnl.TabIndex = 11;
            // 
            // betDisplayPnl
            // 
            this.betDisplayPnl.BackColor = System.Drawing.Color.DarkRed;
            this.betDisplayPnl.Controls.Add(this.panel4);
            this.betDisplayPnl.Controls.Add(this.betAmountLbl);
            this.betDisplayPnl.Location = new System.Drawing.Point(20, 19);
            this.betDisplayPnl.Name = "betDisplayPnl";
            this.betDisplayPnl.Size = new System.Drawing.Size(180, 47);
            this.betDisplayPnl.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(-17, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 186);
            this.panel4.TabIndex = 11;
            // 
            // betAmountLbl
            // 
            this.betAmountLbl.AutoSize = true;
            this.betAmountLbl.BackColor = System.Drawing.Color.Transparent;
            this.betAmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAmountLbl.Location = new System.Drawing.Point(12, 8);
            this.betAmountLbl.Name = "betAmountLbl";
            this.betAmountLbl.Size = new System.Drawing.Size(29, 31);
            this.betAmountLbl.TabIndex = 10;
            this.betAmountLbl.Text = "£";
            // 
            // playerCard1
            // 
            this.playerCard1.BackColor = System.Drawing.Color.Transparent;
            this.playerCard1.Location = new System.Drawing.Point(370, 461);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(136, 193);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard1.TabIndex = 12;
            this.playerCard1.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEA_Project.Properties.Resources.bjbg;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.bettingPnl);
            this.Controls.Add(this.accountStatusTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.balancePnl);
            this.Controls.Add(this.betPnl);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.balancePnl.ResumeLayout(false);
            this.balancePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gambleAmountPnl.ResumeLayout(false);
            this.gambleAmountPnl.PerformLayout();
            this.bettingPnl.ResumeLayout(false);
            this.betPnl.ResumeLayout(false);
            this.betDisplayPnl.ResumeLayout(false);
            this.betDisplayPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel balancePnl;
        public System.Windows.Forms.Label balanceTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label accountStatusTxt;
        private System.Windows.Forms.Button pcnt75Btn;
        private System.Windows.Forms.Button pcnt10Btn;
        private System.Windows.Forms.Button pcnt25Btn;
        private System.Windows.Forms.Button allInBtn;
        private System.Windows.Forms.Panel gambleAmountPnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox bettingAmountBox;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.Button pcnt50Btn;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.Panel bettingPnl;
        private System.Windows.Forms.Panel betPnl;
        private System.Windows.Forms.Panel betDisplayPnl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label betAmountLbl;
        private System.Windows.Forms.PictureBox playerCard1;
    }
}
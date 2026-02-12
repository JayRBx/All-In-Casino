namespace NEA_Project
{
    partial class GameSelection
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
            this.minesBtn = new System.Windows.Forms.Panel();
            this.bjBtn = new System.Windows.Forms.Panel();
            this.slotsBtn = new System.Windows.Forms.Panel();
            this.returnImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).BeginInit();
            this.SuspendLayout();
            // 
            // minesBtn
            // 
            this.minesBtn.BackColor = System.Drawing.Color.Transparent;
            this.minesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minesBtn.Location = new System.Drawing.Point(69, 588);
            this.minesBtn.Name = "minesBtn";
            this.minesBtn.Size = new System.Drawing.Size(281, 81);
            this.minesBtn.TabIndex = 0;
            this.minesBtn.Click += new System.EventHandler(this.minesBtn_Click);
            // 
            // bjBtn
            // 
            this.bjBtn.BackColor = System.Drawing.Color.Transparent;
            this.bjBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bjBtn.Location = new System.Drawing.Point(489, 588);
            this.bjBtn.Name = "bjBtn";
            this.bjBtn.Size = new System.Drawing.Size(323, 81);
            this.bjBtn.TabIndex = 0;
            this.bjBtn.Click += new System.EventHandler(this.blackJackBtn_Click);
            this.bjBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.bjPnl_Paint);
            // 
            // slotsBtn
            // 
            this.slotsBtn.BackColor = System.Drawing.Color.Transparent;
            this.slotsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slotsBtn.Location = new System.Drawing.Point(948, 588);
            this.slotsBtn.Name = "slotsBtn";
            this.slotsBtn.Size = new System.Drawing.Size(277, 81);
            this.slotsBtn.TabIndex = 0;
            this.slotsBtn.Click += new System.EventHandler(this.slotsBtn_Click);
            // 
            // returnImg
            // 
            this.returnImg.BackColor = System.Drawing.Color.Transparent;
            this.returnImg.BackgroundImage = global::NEA_Project.Properties.Resources._61449;
            this.returnImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnImg.Location = new System.Drawing.Point(1202, 12);
            this.returnImg.Name = "returnImg";
            this.returnImg.Size = new System.Drawing.Size(50, 50);
            this.returnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnImg.TabIndex = 12;
            this.returnImg.TabStop = false;
            this.returnImg.Click += new System.EventHandler(this.returnImg_Click);
            this.returnImg.MouseEnter += new System.EventHandler(this.returnImg_MouseEnter);
            // 
            // GameSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEA_Project.Properties.Resources.gameselection_bg;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.returnImg);
            this.Controls.Add(this.slotsBtn);
            this.Controls.Add(this.bjBtn);
            this.Controls.Add(this.minesBtn);
            this.Name = "GameSelection";
            this.Text = "GameSelection";
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel minesBtn;
        private System.Windows.Forms.Panel bjBtn;
        private System.Windows.Forms.Panel slotsBtn;
        private System.Windows.Forms.PictureBox returnImg;
    }
}
namespace NEA_Project
{
    partial class Register
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
            this.returnImg = new System.Windows.Forms.PictureBox();
            this.SignInTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.pinPnl = new System.Windows.Forms.Panel();
            this.pinTxtBox = new System.Windows.Forms.TextBox();
            this.usernamePnl = new System.Windows.Forms.Panel();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).BeginInit();
            this.pinPnl.SuspendLayout();
            this.usernamePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnImg
            // 
            this.returnImg.BackColor = System.Drawing.Color.Transparent;
            this.returnImg.BackgroundImage = global::NEA_Project.Properties.Resources._61449;
            this.returnImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnImg.Location = new System.Drawing.Point(722, 349);
            this.returnImg.Name = "returnImg";
            this.returnImg.Size = new System.Drawing.Size(50, 50);
            this.returnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnImg.TabIndex = 20;
            this.returnImg.TabStop = false;
            this.returnImg.MouseEnter += new System.EventHandler(this.returnImg_MouseEnter);
            // 
            // SignInTxt
            // 
            this.SignInTxt.AutoSize = true;
            this.SignInTxt.BackColor = System.Drawing.Color.Transparent;
            this.SignInTxt.ForeColor = System.Drawing.Color.Turquoise;
            this.SignInTxt.Location = new System.Drawing.Point(625, 352);
            this.SignInTxt.Name = "SignInTxt";
            this.SignInTxt.Size = new System.Drawing.Size(56, 13);
            this.SignInTxt.TabIndex = 19;
            this.SignInTxt.Text = "Click Here";
            this.SignInTxt.Click += new System.EventHandler(this.SignInTxt_Click);
            this.SignInTxt.MouseEnter += new System.EventHandler(this.SignInTxt_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(497, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Already have an account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(520, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(520, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.DarkRed;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(497, 298);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(200, 47);
            this.RegisterBtn.TabIndex = 14;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // pinPnl
            // 
            this.pinPnl.BackColor = System.Drawing.Color.Black;
            this.pinPnl.Controls.Add(this.pinTxtBox);
            this.pinPnl.Location = new System.Drawing.Point(497, 232);
            this.pinPnl.Name = "pinPnl";
            this.pinPnl.Size = new System.Drawing.Size(200, 47);
            this.pinPnl.TabIndex = 13;
            // 
            // pinTxtBox
            // 
            this.pinTxtBox.BackColor = System.Drawing.Color.Black;
            this.pinTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTxtBox.ForeColor = System.Drawing.Color.White;
            this.pinTxtBox.Location = new System.Drawing.Point(16, 8);
            this.pinTxtBox.MaxLength = 4;
            this.pinTxtBox.Name = "pinTxtBox";
            this.pinTxtBox.Size = new System.Drawing.Size(174, 31);
            this.pinTxtBox.TabIndex = 3;
            this.pinTxtBox.UseSystemPasswordChar = true;
            // 
            // usernamePnl
            // 
            this.usernamePnl.BackColor = System.Drawing.Color.DarkRed;
            this.usernamePnl.Controls.Add(this.usernameTxtBox);
            this.usernamePnl.Location = new System.Drawing.Point(497, 157);
            this.usernamePnl.Name = "usernamePnl";
            this.usernamePnl.Size = new System.Drawing.Size(200, 47);
            this.usernamePnl.TabIndex = 12;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.BackColor = System.Drawing.Color.DarkRed;
            this.usernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtBox.ForeColor = System.Drawing.Color.White;
            this.usernameTxtBox.Location = new System.Drawing.Point(16, 8);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(174, 31);
            this.usernameTxtBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NEA_Project.Properties.Resources._99cd96d0_fb10_4b4c_b92b_be256ddc6e662;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(467, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 134);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEA_Project.Properties.Resources.gambling_addiction_poker__1_3;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.returnImg);
            this.Controls.Add(this.SignInTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.pinPnl);
            this.Controls.Add(this.usernamePnl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).EndInit();
            this.pinPnl.ResumeLayout(false);
            this.pinPnl.PerformLayout();
            this.usernamePnl.ResumeLayout(false);
            this.usernamePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox returnImg;
        private System.Windows.Forms.Label SignInTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel pinPnl;
        private System.Windows.Forms.TextBox pinTxtBox;
        private System.Windows.Forms.Panel usernamePnl;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
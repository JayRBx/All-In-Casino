namespace NEA_Project
{
    partial class Signin
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
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.usernamePnl = new System.Windows.Forms.Panel();
            this.pinPnl = new System.Windows.Forms.Panel();
            this.pinTxtBox = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerTxt = new System.Windows.Forms.Label();
            this.returnImg = new System.Windows.Forms.PictureBox();
            this.usernamePnl.SuspendLayout();
            this.pinPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).BeginInit();
            this.SuspendLayout();
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
            // usernamePnl
            // 
            this.usernamePnl.BackColor = System.Drawing.Color.DarkRed;
            this.usernamePnl.Controls.Add(this.usernameTxtBox);
            this.usernamePnl.Location = new System.Drawing.Point(497, 157);
            this.usernamePnl.Name = "usernamePnl";
            this.usernamePnl.Size = new System.Drawing.Size(200, 47);
            this.usernamePnl.TabIndex = 4;
            // 
            // pinPnl
            // 
            this.pinPnl.BackColor = System.Drawing.Color.Black;
            this.pinPnl.Controls.Add(this.pinTxtBox);
            this.pinPnl.Location = new System.Drawing.Point(497, 232);
            this.pinPnl.Name = "pinPnl";
            this.pinPnl.Size = new System.Drawing.Size(200, 47);
            this.pinPnl.TabIndex = 5;
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
            this.pinTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pinTxtBox_KeyPress);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.DarkRed;
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Location = new System.Drawing.Point(497, 298);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(200, 47);
            this.signInBtn.TabIndex = 6;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(520, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(520, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NEA_Project.Properties.Resources._99cd96d0_fb10_4b4c_b92b_be256ddc6e662;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(467, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 134);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(497, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Don\'t have an account?";
            // 
            // registerTxt
            // 
            this.registerTxt.AutoSize = true;
            this.registerTxt.BackColor = System.Drawing.Color.Transparent;
            this.registerTxt.ForeColor = System.Drawing.Color.Turquoise;
            this.registerTxt.Location = new System.Drawing.Point(625, 352);
            this.registerTxt.Name = "registerTxt";
            this.registerTxt.Size = new System.Drawing.Size(56, 13);
            this.registerTxt.TabIndex = 10;
            this.registerTxt.Text = "Click Here";
            this.registerTxt.Click += new System.EventHandler(this.label4_Click);
            this.registerTxt.MouseEnter += new System.EventHandler(this.registerTxt_MouseEnter);
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
            this.returnImg.TabIndex = 11;
            this.returnImg.TabStop = false;
            this.returnImg.Click += new System.EventHandler(this.returnImg_Click);
            this.returnImg.MouseEnter += new System.EventHandler(this.returnImg_MouseEnter);
            this.returnImg.MouseLeave += new System.EventHandler(this.returnImg_MouseLeave);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NEA_Project.Properties.Resources.gambling_addiction_poker__1_3;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.returnImg);
            this.Controls.Add(this.registerTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.pinPnl);
            this.Controls.Add(this.usernamePnl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Signin";
            this.Text = "AccountSystem";
            this.Load += new System.EventHandler(this.Signin_Load);
            this.usernamePnl.ResumeLayout(false);
            this.usernamePnl.PerformLayout();
            this.pinPnl.ResumeLayout(false);
            this.pinPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Panel usernamePnl;
        private System.Windows.Forms.Panel pinPnl;
        private System.Windows.Forms.TextBox pinTxtBox;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label registerTxt;
        private System.Windows.Forms.PictureBox returnImg;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace NEA_Project
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();

            appData.RoundControl(usernamePnl, 50);

            appData.RoundControl(pinPnl, 50);

            appData.RoundControl(signInBtn, 50);
            appData.SetupButton(signInBtn);

        }

        string filePath = "C:\\Users\\JayRB\\source\\repos\\JayRBx\\Virtual-Casino\\NEA Project\\userLogs.txt";

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string tempUsername = usernameTxtBox.Text.Trim();
            string tempPassword = pinTxtBox.Text.Trim();

            bool loginSuccess = false;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');

                string storedUsername = parts[0];
                string storedPassword = parts[1];

                if (tempUsername == storedUsername && tempPassword == storedPassword)
                {
                    loginSuccess = true;
                    appData.username = storedUsername;
                    appData.balance = (float)Convert.ToDouble(parts[2]);
                    break;
                }
            }

            if (loginSuccess)
            {
                MessageBox.Show("Login successful! Welcome, " + appData.username + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                mainMenu.accountStatusTxt.Text = $"Signed in as, {appData.username}!";
                mainMenu.balanceTxt.Text = $"Balance: {appData.currency}{appData.balance}";
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account not found. \n\nPlease check your username and password and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register signUp = new Register();
            signUp.Show();
            this.Hide();
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void returnImg_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide(); 
        }

        private void returnImg_MouseEnter(object sender, EventArgs e)
        {
            Cursor hand = Cursors.Hand;
            returnImg.Cursor = hand;
        }

        private void returnImg_MouseLeave(object sender, EventArgs e)
        {
            Cursor hand = Cursors.Default;
            returnImg.Cursor = default;
        }

        private void registerTxt_MouseEnter(object sender, EventArgs e)
        {
            Cursor hand = Cursors.Hand;
            registerTxt.Cursor = hand;
        }

        private void pinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NEA_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            appData.RoundControl(usernamePnl, 50);

            appData.RoundControl(pinPnl, 50);

            appData.RoundControl(RegisterBtn, 50);
            appData.SetupButton(RegisterBtn);
        }

        private void SignInTxt_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
            this.Close();
        }

        private void SignInTxt_MouseEnter(object sender, EventArgs e)
        {
            Cursor hand = Cursors.Hand;
            SignInTxt.Cursor = hand;
        }

        private void returnImg_MouseEnter(object sender, EventArgs e)
        {
            Cursor hand = Cursors.Hand;
            returnImg.Cursor = hand;
        }


        string filePath = "C:\\Users\\JayRB\\source\\repos\\JayRBx\\Virtual-Casino\\NEA Project\\userLogs.txt";

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string tempUsername = usernameTxtBox.Text.Trim();

            bool registerSuccess = true;

            string errorMessage = "";

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');

                string storedUsername = parts[0];
                string storedPassword = parts[1];

                if (tempUsername == storedUsername)
                {
                    registerSuccess = false;
                    errorMessage += " • Username already exists. Please choose a different username.\n";
                }
            }

            if (tempUsername == "")
            {
                registerSuccess = false;
                errorMessage += " • Username cannot be empty.\n";
            }

            if (pinTxtBox.Text.Length != 4)
            {
                registerSuccess = false;
                errorMessage += " • Pin must be 4 digits.\n";
            }

            if (registerSuccess)
            {
                string newUserData = $"{tempUsername}:{pinTxtBox.Text}:1000.0";
                File.AppendAllText(filePath, newUserData + Environment.NewLine);
                MessageBox.Show("Registration successful! You can now sign in with your new account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Signin signin = new Signin();
                signin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed due to the following reasons:\n\n" + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace NEA_Project
{
    public partial class BlackJack: Form
    {
        float gambleAmount;

        public BlackJack()
        {
            InitializeComponent();

            betDisplayPnl.Visible = false;

            balanceTxt.Text = appData.balance.ToString();
            appData.RoundControl(balancePnl, 50);

            if (appData.username != null)
            {
                accountStatusTxt.Text = $"Logged in as: {appData.username}!";
            }
            else
            {
                accountStatusTxt.Text = "Not logged in";
            }

            if (appData.balance != -1)
            {
                balanceTxt.Text = $"Balance: {appData.currency}{appData.balance}";
            }
            else
            {
                balanceTxt.Text = "Balance: N/A";
            }

            appData.RoundControl(gambleAmountPnl, 50);

            appData.RoundControl(pcnt10Btn, 15);
            appData.SetupButton(pcnt10Btn);

            appData.RoundControl(pcnt25Btn, 15);
            appData.SetupButton(pcnt25Btn);

            appData.RoundControl(pcnt50Btn, 15);
            appData.SetupButton(pcnt50Btn);

            appData.RoundControl(pcnt75Btn, 15);
            appData.SetupButton(pcnt75Btn);

            appData.RoundControl(allInBtn, 15);
            appData.SetupButton(allInBtn);

            appData.RoundControl(betBtn, 50);
            appData.SetupButton(betBtn);

            appData.RoundControl(bettingPnl, 50);

            appData.RoundControl(betDisplayPnl, 50);

        }

        private void bettingAmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void pcnt10Btn_Click(object sender, EventArgs e)
        {
            bettingAmountBox.Text = (appData.balance * 0.10).ToString("F2");
        }

        private void pcnt25Btn_Click(object sender, EventArgs e)
        {
            bettingAmountBox.Text = (appData.balance * 0.25).ToString("F2");
        }

        private void pcnt50Btn_Click(object sender, EventArgs e)
        {
            bettingAmountBox.Text = (appData.balance * 0.50).ToString("F2");
        }

        private void pcnt75Btn_Click(object sender, EventArgs e)
        {
            bettingAmountBox.Text = (appData.balance * 0.75).ToString("F2");
        }

        private void allInBtn_Click(object sender, EventArgs e)
        {
            bettingAmountBox.Text = appData.balance.ToString("F2");
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(bettingAmountBox.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("Enter a valid bet amount (e.g. 10, 10.0, 10.00)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if ((float)Convert.ToDouble(bettingAmountBox.Text) > appData.balance)
            {
                MessageBox.Show("You cannot bet more than your current balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                gambleAmount = bettingAmountBox.Text == "" ? 0 : (float)Convert.ToDouble(bettingAmountBox.Text);
                appData.balance -= gambleAmount;
                balanceTxt.Text = $"Balance: {appData.currency}{appData.balance}";
                BlackJack_GameStart();
            }
                
        }

        private void BlackJack_GameStart()
        {
            bettingPnl.Visible = false;
            betDisplayPnl.BringToFront();
            betDisplayPnl.Visible = true;
            betAmountLbl.Text = $"Bet: {appData.currency}{gambleAmount}";

            playerCard1.Image = Properties.Resources._10_of_clubs;
        }
    }
}

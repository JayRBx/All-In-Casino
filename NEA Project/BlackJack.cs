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
using NEA_Project.Properties;

namespace NEA_Project
{
    public partial class BlackJack: Form
    {
        float gambleAmount;

        public BlackJack()
        {
            InitializeComponent();

            betPnl.Visible = false;

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

            appData.RoundControl(hitBtn, 25);
            appData.SetupButton(hitBtn);

            appData.RoundControl(standBtn, 25);
            appData.SetupButton(standBtn);

            appData.RoundControl(doubleBtn, 25);
            appData.SetupButton(doubleBtn);

            appData.RoundControl(splitBtn, 25);
            appData.SetupButton(splitBtn);

            appData.RoundControl(surrenderBtn, 50);
            appData.SetupButton(surrenderBtn);

            splitCardsPnl.Visible = false;
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
            Random rnd = new Random();
            bettingPnl.Visible = false;
            betPnl.Visible = true;
            betAmountLbl.Text = $"Bet: {appData.currency}{gambleAmount}";


            //Player Init

            string[] playerCardsImg = new string[5];
            int playerCardValues = 0;
            int playerCardCount = 0;

            for(int i = 0; i < 2; i++)
            {
                int cardSuitIndex = rnd.Next(0, 4);
                int cardValueIndex = rnd.Next(0, 13);

                playerCardsImg[i] = $"_{appData.cardValue[cardValueIndex]}_of_{appData.cardSuits[cardSuitIndex]}";

                if (cardValueIndex == 12) // Jack, Queen, King
                {
                    playerCardValues += 11;
                }
                else if (cardValueIndex >= 9) // Ace
                {
                    playerCardValues += 10; // Will handle Ace value adjustment later
                }
                else
                {
                    playerCardValues += cardValueIndex + 2; // cardValueIndex starts at 0 for "2"
                }


                playerCardCount++;
            }

            playerCard1.BackgroundImage = Resources.ResourceManager.GetObject(playerCardsImg[0]) as Image;
            playerCard2.BackgroundImage = Resources.ResourceManager.GetObject(playerCardsImg[1]) as Image;


            //Dealer Init

            while (dealerCardCount < 2)
            {
                int cardSuitIndex = rnd.Next(0, 4);
                int cardValueIndex = rnd.Next(0, 13);

                dealerCardsImg[dealerCardCount] = $"_{appData.cardValue[cardValueIndex]}_of_{appData.cardSuits[cardSuitIndex]}";

                if (cardValueIndex == 12) // Jack, Queen, King
                {
                    dealerCardValues += 11;
                }
                else if (cardValueIndex >= 9) // Ace
                {
                    dealerCardValues += 10; // Will handle Ace value adjustment later
                }
                else
                {
                    dealerCardValues += cardValueIndex + 2; // cardValueIndex starts at 0 for "2"
                }


                dealerCardCount++;
            }

            dealerCard1.BackgroundImage = Resources.ResourceManager.GetObject(dealerCardsImg[0]) as Image;
            dealerCard2.BackgroundImage = Resources.ResourceManager.GetObject(dealerCardsImg[1]) as Image;
        }

        private void returnImg_Click(object sender, EventArgs e)
        {
            GameSelection gameSelection = new GameSelection();
            gameSelection.Show();
            this.Close();
        }
    }
}

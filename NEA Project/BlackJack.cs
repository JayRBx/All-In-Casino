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
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace NEA_Project
{
    public partial class BlackJack: Form
    {
        float gambleAmount;
        bool surrender;
        bool aceCountAs11 = false;


        public string[] playerCardsImg = new string[5];
        int playerCardValues = 0;
        int playerCardCount = 0;

        string[] dealerCardsImg = new string[5];
        int dealerCardValues = 0;
        int dealerCardCount = 0;

        bool playerHasSplit = false;
        bool isFirstHand = true;
        bool gameOver = false;

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
            surrender = false;
            playerHasSplit = false;
            isFirstHand = true;

            playerCardsImg = new string[5];
            playerCardValues = 0;
            playerCardCount = 0;

            dealerCardsImg = new string[5];
            dealerCardValues = 0;
            dealerCardCount = 0;



            Random rnd = new Random();
            bettingPnl.Visible = false;
            betPnl.Visible = true;

            defaultCardPnl.Visible = true;
            betAmountLbl.Text = $"Bet: {appData.currency}{gambleAmount}";

            PlayerCard3.Visible = false;
            PlayerCard4.Visible = false;
            PlayerCard5.Visible = false;

            dealerCard3.Visible = false;
            dealerCard4.Visible = false;
            dealerCard5.Visible = false;

            //Player Init
            for(int i = 0; i < 2; i++)
            {
                int cardSuitIndex = rnd.Next(0, 4);
                int cardValueIndex = rnd.Next(0, 13);

                playerCardsImg[i] = $"_{appData.cardValue[cardValueIndex]}_of_{appData.cardSuits[cardSuitIndex]}";

                if (cardValueIndex == 12) // Jack, Queen, King
                {
                    if(playerCardValues + 11 > 21)
                    {
                        playerCardValues += 1; // Count Ace as 1 if counting as 11 would bust
                    }
                    else
                    {
                        playerCardValues += 11;
                        aceCountAs11 = true;
                    }
                }
                else if (cardValueIndex >= 9) // Ace
                {
                    playerCardValues += 10; // Will handle Ace value adjustment later
                }
                else
                {
                    playerCardValues += cardValueIndex + 2; // cardValueIndex starts at 0 for "2"
                }
                if(aceCountAs11 && playerCardValues > 21)
                {
                    playerCardValues -= 10; // Adjust Ace from 11 to 1 if it causes a bust
                    aceCountAs11 = false;
                }

                playerCardCount++;
            }

            playerCard1.Image = Resources.ResourceManager.GetObject(playerCardsImg[0]) as Image;
            playerCard2.Image = Resources.ResourceManager.GetObject(playerCardsImg[1]) as Image;
            cardValuesLbl.Text = $"Player: {playerCardValues}";


            //Dealer Init

            int tempDealerValue = 0;

            while (dealerCardCount < 2)
            {
                int cardSuitIndex = rnd.Next(0, 4);
                int cardValueIndex = rnd.Next(0, 13);

                dealerCardsImg[dealerCardCount] = $"_{appData.cardValue[cardValueIndex]}_of_{appData.cardSuits[cardSuitIndex]}";

                if (cardValueIndex == 12) // Ace
                {
                    dealerCardValues += 11; //Will handle Ace value adjustment later
                    tempDealerValue = 11;
                }
                else if (cardValueIndex >= 9) // Jack, Queen, King
                {
                    dealerCardValues += 10;
                    tempDealerValue = 10;
                }
                else
                {
                    dealerCardValues += cardValueIndex + 2; // cardValueIndex starts at 0 for "2"
                    tempDealerValue = cardValueIndex + 2;
                }


                dealerCardCount++;
            }

            dealerCard1.Image = Resources.ResourceManager.GetObject("back_of_card") as Image;
            dealerCard2.Image = Resources.ResourceManager.GetObject(dealerCardsImg[1]) as Image;
            dealerCardValuesLbl.Text = $"Dealer: {tempDealerValue}";

            if(playerCardValues == 21)
            {
                CheckPlayerWin();
            }
        }

        private void CheckPlayerWin()
        {
            if (surrender)
            {
                MessageBox.Show("You surrendered. You lose half your bet.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                appData.balance += gambleAmount / 2; // Return half the bet
            }
            if (playerCardValues <= 21)
            {
                DealerTurn();
            }
            else
            {
                if (playerCardValues == 21 && dealerCardValues != 21 && isFirstHand)
                {
                    MessageBox.Show("Blackjack! You win!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    appData.balance += gambleAmount * 2.5f; // Blackjack pays 3:2
                    gameOver = true;
                }
                else if ((playerCardValues > dealerCardValues && playerCardValues <= 21) || dealerCardValues > 21)
                {
                    MessageBox.Show("You win!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    appData.balance += gambleAmount * 2; // Regular win pays 1:1
                    gameOver = true;
                }
                else if (playerCardValues == dealerCardValues)
                {
                    MessageBox.Show("Push! Your bet has been returned.", "Push", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    appData.balance += gambleAmount; // Return the bet
                    gameOver = true;
                }
                else if (playerCardValues > 21)
                {
                    MessageBox.Show("You went bust! Dealer wins.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dealerCard1.Image = Resources.ResourceManager.GetObject(dealerCardsImg[0]) as Image;
                    dealerCardValuesLbl.Text = $"Dealer: {dealerCardValues}";
                    gameOver = true;
                }
                else if (playerCardValues < dealerCardValues)
                {
                    MessageBox.Show("Dealer wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dealerCard1.Image = Resources.ResourceManager.GetObject(dealerCardsImg[0]) as Image;
                    dealerCardValuesLbl.Text = $"Dealer: {dealerCardValues}";
                    gameOver = true;
                }
            }

            if (gameOver)
            {
                betPnl.Visible = false;
                bettingPnl.Visible = true;
                balanceTxt.Text = $"Balance: {appData.currency}{appData.balance}";
            }
        }

        private void DealerTurn()
        {
            Random rnd = new Random();
            while (dealerCardValues < 17)
            {
                dealerCard1.Image = Resources.ResourceManager.GetObject(dealerCardsImg[0]) as Image;
                int cardSuitIndex = rnd.Next(0, 4);
                int cardValueIndex = rnd.Next(0, 13);
                dealerCardsImg[dealerCardCount] = $"_{appData.cardValue[cardValueIndex]}_of_{appData.cardSuits[cardSuitIndex]}";
                if (cardValueIndex == 12) // Ace
                {
                    if(dealerCardValues + 11 > 21)
                    {
                        dealerCardValues += 1; // Count Ace as 1 if counting as 11 would bust
                    }
                    else
                    {
                        dealerCardValues += 11;
                        aceCountAs11 = true;
                    }
                }
                else if (cardValueIndex >= 9) // Jack, Queen, King
                {
                    dealerCardValues += 10; // Will handle Ace value adjustment later
                }
                else
                {
                    dealerCardValues += cardValueIndex + 2; // cardValueIndex starts at 0 for "2"
                }
                switch (dealerCardCount)
                {
                    case 2:
                        dealerCard3.Image = Resources.ResourceManager.GetObject(dealerCardsImg[2]) as Image;
                        dealerCard3.Visible = true;
                        break;
                    case 3:
                        dealerCard4.Image = Resources.ResourceManager.GetObject(dealerCardsImg[3]) as Image;
                        dealerCard4.Visible = true;
                        break;
                    case 4:
                        dealerCard5.Image = Resources.ResourceManager.GetObject(dealerCardsImg[4]) as Image;
                        dealerCard5.Visible = true;
                        break;
                }
                dealerCardCount++;
                if (aceCountAs11 && dealerCardValues > 21)
                {
                    dealerCardValues -= 10; // Adjust Ace from 11 to 1 if it causes a bust
                    aceCountAs11 = false;
                }
                dealerCardValuesLbl.Text = $"Dealer: {dealerCardValues}";
            }
        }

        private void returnImg_Click(object sender, EventArgs e)
        {
            GameSelection gameSelection = new GameSelection();
            gameSelection.Show();
            this.Close();
        }

        private void hitBtn_Click(object sender, EventArgs e)
        {
            isFirstHand = false;

            Random rnd = new Random();
            if (playerCardCount < 5)
            {
                int cardSuitIndex = rnd.Next(0, 4);
                int cardValueIndex = rnd.Next(0, 13);
                playerCardsImg[playerCardCount] = $"_{appData.cardValue[cardValueIndex]}_of_{appData.cardSuits[cardSuitIndex]}";
                if (cardValueIndex == 12) // Jack, Queen, King
                {
                    if (playerCardValues + 11 > 21)
                    {
                        playerCardValues += 1; // Count Ace as 1 if counting as 11 would bust
                    }
                    else
                    {
                        playerCardValues += 11;
                        aceCountAs11 = true;
                    }
                }
                else if (cardValueIndex >= 9) // Ace
                {
                    playerCardValues += 10; // Will handle Ace value adjustment later
                }
                else
                {
                    playerCardValues += cardValueIndex + 2; // cardValueIndex starts at 0 for "2"
                }
                switch (playerCardCount)
                {
                    case 2:
                        PlayerCard3.Image = Resources.ResourceManager.GetObject(playerCardsImg[2]) as Image;
                        PlayerCard3.Visible = true;
                        break;
                    case 3:
                        PlayerCard4.Image = Resources.ResourceManager.GetObject(playerCardsImg[3]) as Image;
                        PlayerCard4.Visible = true;
                        break;
                    case 4:
                        PlayerCard5.Image = Resources.ResourceManager.GetObject(playerCardsImg[4]) as Image;
                        PlayerCard5.Visible = true;
                        break;
                }
                if(aceCountAs11 && playerCardValues > 21)
                {
                    playerCardValues -= 10; // Adjust Ace from 11 to 1 if it causes a bust
                    aceCountAs11 = false;
                }
                cardValuesLbl.Text = $"Player: {playerCardValues}";
                if (playerCardValues > 21)
                {
                    CheckPlayerWin();
                }
                playerCardCount++;
            }
        }

        private void standBtn_Click(object sender, EventArgs e)
        {
            CheckPlayerWin();
        }

        private void surrenderBtn_Click(object sender, EventArgs e)
        {
            if (!isFirstHand)
            {
                return;
            }
            surrender = true;
            CheckPlayerWin();
        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            if (!isFirstHand || gameOver)
            {
                return;
            }
            else if (appData.balance < gambleAmount)
            {
                MessageBox.Show("You don't have enough balance to double down.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                appData.balance -= gambleAmount;
                gambleAmount *= 2;
                balanceTxt.Text = $"Balance: {appData.currency}{appData.balance}";
                betAmountLbl.Text = $"Bet: {appData.currency}{gambleAmount}";
                hitBtn_Click(sender, e);
                CheckPlayerWin();
            }
            
        }
    }
}

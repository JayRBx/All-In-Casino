using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            appData.SetupButton(gameSelectorBtn);
            appData.RoundControl(gameSelectorBtn, 50);

            appData.SetupButton(settingsBtn);
            appData.RoundControl(settingsBtn, 50);

            appData.SetupButton(accountBtn);
            appData.RoundControl(accountBtn, 50);

            appData.SetupButton(quitBtn);
            appData.RoundControl(quitBtn, 50);

            appData.RoundControl(balancePnl, 50);

            if(appData.username != null)
            {
                accountStatusTxt.Text = $"Logged in as: {appData.username}!";
            }
            else
            {
                accountStatusTxt.Text = "Not logged in";
            }

            if(appData.balance != -1)
            {
                balanceTxt.Text = $"Balance: {appData.currency}{appData.balance}";
            }
            else
            {
                balanceTxt.Text = "Balance: N/A";
            }

        }

        private void settingsClk(object sender, EventArgs e)
        {

        }

        private void gameSelectorClk(object sender, EventArgs e)
        {
            GameSelection gameSelection = new GameSelection();           
            gameSelection.Show();
            this.Hide();
        }

        private void accountsClk(object sender, EventArgs e)
        {
            Signin accountSystem = new Signin();
            accountSystem.Show();
            this.Hide();
        }

        private void quitClk(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

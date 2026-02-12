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
    public partial class GameSelection: Form
    {
        public GameSelection()
        {
            InitializeComponent();
        }

        private void blackJackBtn_Click(object sender, EventArgs e)
        {
            BlackJack blackJack = new BlackJack();
            blackJack.Show();
            this.Hide();
        }

        private void minesBtn_Click(object sender, EventArgs e)
        {
            Mines mines = new Mines();
            mines.Show();
            this.Hide();
        }

        private void slotsBtn_Click(object sender, EventArgs e)
        {
            Slots slots = new Slots();
            slots.Show();
            this.Hide();
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

        private void bjPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

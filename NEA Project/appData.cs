using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Project
{
    public static class appData
    {
        public static string username;
        public static float balance = 1000;
        public static char currency = '£';

        public static string[] cardSuits = { "hearts", "diamonds", "clubs", "spades" };
        public static string[] cardValue = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };

        public static void RoundControl(Control c, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(c.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(c.Width - radius, c.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, c.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }

        public static Color Darken(Color c, int amount = 15)
        {
            return Color.FromArgb(
                c.A,
                Math.Max(0, c.R - amount),
                Math.Max(0, c.G - amount),
                Math.Max(0, c.B - amount)
            );
        }


        public static void SetupButton(Button btn)
        {
            btn.UseVisualStyleBackColor = false;
            btn.FlatStyle = FlatStyle.Flat;

            btn.Tag = btn.BackColor; // store original

            btn.MouseEnter += (s, e) =>
            {
                Button b = (Button)s;
                b.BackColor = Darken((Color)b.Tag, -20);
            };

            btn.MouseLeave += (s, e) =>
            {
                Button b = (Button)s;
                b.BackColor = (Color)b.Tag;
            };

            Cursor hand = Cursors.Hand;
            btn.Cursor = hand;

            


        }

        private static void Button_MouseEnter(object sender, EventArgs e)
            {
            Button btn = (Button)sender;
            btn.Cursor = Cursors.Hand;
            btn.BackColor = Color.FromArgb(70, 0, 0, 0);
            }

            private static void Button_MouseLeave(object sender, EventArgs e)
            {
                Button btn = (Button)sender;
                btn.BackColor = (Color)btn.Tag;
            }

    }
}

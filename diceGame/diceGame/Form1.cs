using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace diceGame
{
    public partial class Form1 : Form
    {
        private Random rand;
        private Bitmap dice;
        private Rectangle r;
        private int sum;
        public Form1()
        {
            InitializeComponent();
            dice = Properties.Resources.dices;
            rand = new Random();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userDice2_Click(object sender, EventArgs e)
        {

        }

        private void userDice1_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            Computer.Visible = true;
            rollsLabel.Visible = true;
            rolls.Text = "10";
            rolls.Visible = true;
            roll.Enabled = true;
            play.Enabled = false;
            int i = rand.Next(1, 7);
            sum += i;
            r = new Rectangle(160 * (i - 1), 0, 160, dice.Height);
            computerDice1.Image = dice.Clone(r, dice.PixelFormat);
            i = rand.Next(1, 7);
            r = new Rectangle(160 * (i - 1), 0, 160, dice.Height);
            computerDice2.Image = dice.Clone(r, dice.PixelFormat);
            sum += i;
        }

        private void roll_Click(object sender, EventArgs e)
        {
            rolls.Text = (Convert.ToInt16(rolls.Text)-1).ToString();
            userDice1.Visible = true;
            userDice2.Visible = true;
            int i = rand.Next(1, 7);
            int UserSum = i;
            r = new Rectangle(160 * (i - 1), 0, 160, dice.Height);
            userDice1.Image= dice.Clone(r, dice.PixelFormat);
            i = rand.Next(1, 7);
            UserSum += i;
            r = new Rectangle(160 * (i - 1), 0, 160, dice.Height);
            userDice2.Image = dice.Clone(r, dice.PixelFormat);
            if (UserSum == sum)
            {
                tryAgain.Text = "(((You Win!!)))";
                tryAgain.Visible = true;
                roll.Enabled = false;
                delayTimer.Start();
            }
            else if(0 == Convert.ToInt16(rolls.Text))
            {
                tryAgain.Text = "))) Game Over!(((";
                tryAgain.Visible = true;
                roll.Enabled = false;
                delayTimer.Start();
            }
            else tryAgain.Visible = true;

        }

        private void delayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop();
            Application.Restart();
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DSED_Project1_RandomGame
{


    public partial class Form1 : Form
    {
        public int counter = 6;
        public int win = 0;
        public int lose = 0;
        public int dice;
        public int ProtectJacket = 2;
        public bool IsFiringThisTurn = false;


        //  bug fix - If dice number = 6 you never reach it so stuck in an infinite loop - Closeed
        // bug fix - If the ProtectJacket is sleceted - player is stuck in an infinite loop - Closed

        public Form1()
        {
            InitializeComponent();
            ptbDead.Visible = false;
            ptbAlive.Visible = false;
            btnPlayAgainLose.Visible = false;
            btnPlayAgainWin.Visible = false;
        }


        private void btnLoad_Click(object sender, EventArgs e)

        // generate a random number and add random number result to both lblButtetFire label, and this.Text string. Comment out before handing project in.

        {
            Random rnd = new Random();
            dice = rnd.Next(1, 7); // Random Number between 1 and <7

            lblBulletFire.Text = dice.ToString();

            Debug();

            btnLoad.Visible = false;
        }

        private void btnFIRE_Click(object sender, EventArgs e)
        // if the count down equals the rnd AND fireaway equals false - you lose
        // create  count down code under fire button to count down from 6 to 1
        // create a button click to count down the fireaway

        {

            bool isSafeToFire = true;

            //if counter does not = random generated number and it is still safe to fire - contiune the game
            if ((counter == dice) && IsFiringThisTurn == true)
            {
                ptbAlive.Visible = true;
                ptbAlive.BringToFront();
                btnPlayAgainWin.Visible = true;
                btnPlayAgainWin.BringToFront();
                win++;
                lblWins.Text = win.ToString();
                SoundPlayer splayer = new SoundPlayer(Resource1.SMALL_CROWD_APPLAUSE);
                splayer.Play();
            }
            if ((counter == dice) && IsFiringThisTurn == false)
            //otherwise it is not safe to fire, and you have now been shot.
            {
                isSafeToFire = false;
                btnPlayAgainLose.BringToFront();
                btnPlayAgainLose.Visible = true;
                ptbDead.BringToFront();
                ptbDead.Visible = true;
                lose++;
                lblLoses.Text = lose.ToString();
                SoundPlayer splayer = new SoundPlayer(Resource1.Winchester12_Fire);
                splayer.Play();

            }
            //Counter reduces by 1 each click ( Counter orignally 6 )
            counter--;

            Debug();

            IsFiringThisTurn = false;
        }

        private void btnTurnAway_Click(object sender, EventArgs e)
        //todo create  fire away code where you can fire away for two times only. Use a boolean to say when you cannot fire away any more

        //todo must say when you ARE actually firing away, so you can see if the peson lives.
        {
            Debug();

            TurnAway();

            Debug();
        }

        private void TurnAway()
        {
            if (ProtectJacket > 1)
            {
                //Decrease ProtectJacket by 1 and reduce counter by 1
                IsFiringThisTurn = true;
                ProtectJacket--;
                // counter--;
                //ProtectJacket is currently Visable
                btnTurnAway.Visible = true;
            }
            else
            {
                IsFiringThisTurn = false;
                //ProtectJacket is now hidden (has been clicked 2 times)
                btnTurnAway.Visible = false;
            }
        }

        private void Debug()
        {
            this.Text = dice.ToString() + " Counter " + counter.ToString() + "  Firing " + IsFiringThisTurn + "  Protect jacket " + ProtectJacket;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        //Add one to the Lose total and reply the game
        //reset counter back to 6
        //remove the play again and dead image

        {
            PlayAgainLose();
        }

        private void PlayAgainLose()
        {
            ptbDead.Visible = false;
            btnPlayAgainLose.Visible = false;
            counter = 6;
            ProtectJacket = 2;
            btnLoad.Visible = true;
            btnTurnAway.Visible = true;
            btnFIRE.Visible = true;
        }

        private void btnPlayAgainWin_Click(object sender, EventArgs e)
        {
            PlayAgainWin();
        }

        private void PlayAgainWin()
        // if the count down equals the rnd AND fireaway equals true - you win 
        {
            ptbAlive.Visible = false;
            btnPlayAgainWin.Visible = false;
            counter = 6;
            ProtectJacket = 2;
            btnLoad.Visible = true;
            btnTurnAway.Visible = true;
            btnFIRE.Visible = true;
        }
    }
}

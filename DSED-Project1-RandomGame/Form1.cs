﻿using System;
using System.CodeDom;
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
    // What your project needs.
    // At least one class - Complete
    // At least two Unit Tests of major parts - Complete
    // At least one sound - Complete
    // At least one image - Complete
    // Sound and image should be loaded from the resource folder. - Complete
    // All significant code to be commented - Complete
    // Project to be hosted on Github (include your url) - Complete
    // No variables in the code – all in the classes - ?? Ask Gary
    // Include WIN / LOSE and Total scores - Complete


    public partial class Form1 : Form
    {
        //Leaving these integer variables commented out to show initial code development
        //public int counter = 6;
        //public int win = 0;
        //public int lose = 0;
        //public int dice;
        //public int ProtectJacket = 2;
        //public bool IsFiringThisTurn = false;

        readonly Data myData = new Data();

        // BUG FIX Headline
        //  bug fix - If dice number = 6 you never reach it so stuck in an infinite loop - Closeed 23-8
        // bug fix - If the ProtectJacket is selected - player is stuck in an infinite loop - Closed 23-8
        // bug fix - Debug displays incorrect info after creating Data Class - bug fixed 23-8
        // bug fix - Random number not generated anymore  - Bug Fixed 23-8
        //bug fix - if jacket is @ 1 - I lose - Fixed 28-8



        public Form1()
        {
            InitializeComponent();
            ptbDead.Visible = false;
            ptbAlive.Visible = false;
            btnPlayAgainLose.Visible = false;
            btnPlayAgainWin.Visible = false;
            btnLetsPlay.Visible = false;
        }


        private void btnLoad_Click(object sender, EventArgs e)

        // generate a random number and add random number result to both lblButtetFire label, and this.Text string. Comment out before handing project in.

        {
            myData.RNDGenerator();
            Debug();
            //bool isSafeToFire = false;
            btnLoad.Visible = false;

            // Comment out this line now - not needed as it was my early label text to show random number 
            //lblBulletFire.Text = myData.Dice.ToString();


        }


        private void btnFIRE_Click(object sender, EventArgs e)
        // if the count down equals the rnd AND fireaway equals false - you lose
        // create count down code under fire button to count down from 6 to 1
        // create a button click to count down the fireaway

        {

            bool isSafeToFire = true;


            //if counter does not = random generated number and it is still safe to fire - contiune the game
            if ((myData.Counter == myData.Dice) && myData.IsFiringThisTurn == true)
            {
                ptbAlive.Visible = true;
                ptbAlive.BringToFront();
                btnPlayAgainWin.Visible = true;
                btnPlayAgainWin.BringToFront();
                myData.Win++;
                lblWins.Text = myData.Win.ToString();
                SoundPlayer splayer = new SoundPlayer(Resource1.SMALL_CROWD_APPLAUSE);
                splayer.Play();
            }
            if ((myData.Counter == myData.Dice) && myData.IsFiringThisTurn == false)
            //otherwise it is not safe to fire, and you have now been shot.
            {
                isSafeToFire = false;
                btnPlayAgainLose.BringToFront();
                btnPlayAgainLose.Visible = true;
                ptbDead.BringToFront();
                ptbDead.Visible = true;
                myData.Lose++;
                lblLoses2.Text = myData.Lose.ToString();
                SoundPlayer splayer = new SoundPlayer(Resource1.Winchester12_Fire);
                splayer.Play();

            }
            //Counter reduces by 1 each click ( Counter orignally 6 )
            //myData.Counter--;
            myData.Countdown();
            Debug();
            myData.IsFiringThisTurn = false;
            TotaGamesPlayed();
        }

        private void btnTurnAway_Click(object sender, EventArgs e)
        //todo create  fire away code where you can fire away for two times only. Use a bool to say when you cannot fire away any more - complete 28-8

        //todo must say when you ARE actually firing away, so you can see if the person lives. - Complete - 28-8
        {
            Debug();

            TurnAway();

            TurnAwayCounter();

            Debug();
        }

        private void TurnAway()
        {
            if (myData.ProtectJacket > 0) //Changed value from 1 to 0 (was only allowing 1 safe jacket protection.
            {
                //Decrease ProtectJacket by 1 and reduce counter by 1
                myData.IsFiringThisTurn = true;
                myData.ProtectJacket--;
                // counter--;
                //ProtectJacket is currently Visable
                //btnTurnAway.Visible = true;
            }
            else
            {
                myData.IsFiringThisTurn = false;
                //ProtectJacket is now hidden (has been clicked 2 times)
                //btnTurnAway.Visible = false;
            }
        }

        private void TurnAwayCounter()
        {
            if (myData.ProtectJacket == 0)
            {
                btnTurnAway.Visible = false;
            }
            else
            {
                btnTurnAway.Visible = true;
            }
        }

        public void Debug()
        {
            this.Text = myData.Dice.ToString() + " Counter " + myData.Counter.ToString() + "  Firing " + myData.IsFiringThisTurn + "  Protect jacket " + myData.ProtectJacket;
        }

        public void btnPlayAgain_Click(object sender, EventArgs e)
        //Add one to the Lose total and reply the game
        //reset counter back to 6
        //remove the play again and dead image

        {
            PlayAgainLose();
        }

        public void PlayAgainLose()
        {
            ptbDead.Visible = false;
            btnPlayAgainLose.Visible = false;
            myData.Counter = 6;
            myData.ProtectJacket = 2;
            btnLoad.Visible = true;
            btnTurnAway.Visible = true;
            btnFIRE.Visible = true;
        }

        public void btnPlayAgainWin_Click(object sender, EventArgs e)
        {
            PlayAgainWin();
        }

        public void PlayAgainWin()
        // if the count down equals the rnd AND fireaway equals true - you win 
        {
            ptbAlive.Visible = false;
            btnPlayAgainWin.Visible = false;
            myData.Counter = 6;
            myData.ProtectJacket = 2;
            btnLoad.Visible = true;
            btnTurnAway.Visible = true;
            btnFIRE.Visible = true;
        }

        //This code creates a Total Score value by converting both wins and losses to an interger, and parsing this info into the total wins (again) label.
        public void TotaGamesPlayed()
        {
            TotalScores();
        }

        private void TotalScores()
        {
            int total;
            total = Convert.ToInt16(lblLoses2.Text) + Convert.ToInt16(lblWins.Text);
            lblTotalWinsAgain.Text = total.ToString();
        }

        //Created a help file / text box for users new to playing this game.
        //the help file expalins the rules for this game, and advises how to play the game.
        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            HelpButtonClick();
        }

        private void HelpButtonClick()
        {
            rtbHelpScreen.Visible = true;
            btnHelp.Visible = false;
            btnLetsPlay.Visible = true;
        }

        //Creates a lets play button.  Afer a user has checked the how to play button, this option shows, allowing the user to go back and play the game.
        private void btnLetsPlay_Click(object sender, EventArgs e)
        {
            LetsPlayButtonClick();
        }

        private void LetsPlayButtonClick()
        {
            rtbHelpScreen.Visible = false;
            btnLetsPlay.Visible = false;
            btnHelp.Visible = true;
        }


        //this code closes the application.
        private void btnCloseGame_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

namespace DSED_Project1_RandomGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblBulletFire = new System.Windows.Forms.Label();
            this.btnPlayAgainLose = new System.Windows.Forms.Button();
            this.btnPlayAgainWin = new System.Windows.Forms.Button();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblTotalWinsAgain = new System.Windows.Forms.Label();
            this.lblLoses2 = new System.Windows.Forms.Label();
            this.rtbHelpScreen = new System.Windows.Forms.RichTextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.btnCloseGame = new System.Windows.Forms.Button();
            this.btnTurnAway = new System.Windows.Forms.Button();
            this.btnFIRE = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ptbAlive = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbDead = new System.Windows.Forms.PictureBox();
            this.ptbSafe = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSafe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWins
            // 
            this.lblWins.Location = new System.Drawing.Point(163, 59);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(112, 49);
            this.lblWins.TabIndex = 5;
            this.lblWins.Text = "0";
            this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoses
            // 
            this.lblLoses.Location = new System.Drawing.Point(0, 0);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(100, 23);
            this.lblLoses.TabIndex = 0;
            // 
            // lblBulletFire
            // 
            this.lblBulletFire.AllowDrop = true;
            this.lblBulletFire.Location = new System.Drawing.Point(743, 57);
            this.lblBulletFire.Name = "lblBulletFire";
            this.lblBulletFire.Size = new System.Drawing.Size(150, 49);
            this.lblBulletFire.TabIndex = 7;
            this.lblBulletFire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgainLose
            // 
            this.btnPlayAgainLose.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlayAgainLose.Location = new System.Drawing.Point(989, 376);
            this.btnPlayAgainLose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayAgainLose.Name = "btnPlayAgainLose";
            this.btnPlayAgainLose.Size = new System.Drawing.Size(135, 81);
            this.btnPlayAgainLose.TabIndex = 9;
            this.btnPlayAgainLose.Text = "PlayAgain";
            this.btnPlayAgainLose.UseVisualStyleBackColor = false;
            this.btnPlayAgainLose.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnPlayAgainWin
            // 
            this.btnPlayAgainWin.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPlayAgainWin.Location = new System.Drawing.Point(989, 376);
            this.btnPlayAgainWin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayAgainWin.Name = "btnPlayAgainWin";
            this.btnPlayAgainWin.Size = new System.Drawing.Size(135, 81);
            this.btnPlayAgainWin.TabIndex = 11;
            this.btnPlayAgainWin.Text = "PlayAgain";
            this.btnPlayAgainWin.UseVisualStyleBackColor = false;
            this.btnPlayAgainWin.Click += new System.EventHandler(this.btnPlayAgainWin_Click);
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.Location = new System.Drawing.Point(755, 60);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(112, 49);
            this.lblTotalGames.TabIndex = 13;
            this.lblTotalGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalWinsAgain
            // 
            this.lblTotalWinsAgain.Location = new System.Drawing.Point(755, 60);
            this.lblTotalWinsAgain.Name = "lblTotalWinsAgain";
            this.lblTotalWinsAgain.Size = new System.Drawing.Size(112, 49);
            this.lblTotalWinsAgain.TabIndex = 14;
            this.lblTotalWinsAgain.Text = "0";
            this.lblTotalWinsAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoses2
            // 
            this.lblLoses2.Location = new System.Drawing.Point(449, 58);
            this.lblLoses2.Name = "lblLoses2";
            this.lblLoses2.Size = new System.Drawing.Size(112, 49);
            this.lblLoses2.TabIndex = 15;
            this.lblLoses2.Text = "0";
            this.lblLoses2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbHelpScreen
            // 
            this.rtbHelpScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbHelpScreen.Location = new System.Drawing.Point(52, 43);
            this.rtbHelpScreen.Name = "rtbHelpScreen";
            this.rtbHelpScreen.Size = new System.Drawing.Size(971, 770);
            this.rtbHelpScreen.TabIndex = 17;
            this.rtbHelpScreen.Text = resources.GetString("rtbHelpScreen.Text");
            this.rtbHelpScreen.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.GreenYellow;
            this.btnHelp.Location = new System.Drawing.Point(1136, 154);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(135, 81);
            this.btnHelp.TabIndex = 18;
            this.btnHelp.Text = "Help Button";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click_1);
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.BackColor = System.Drawing.Color.Lime;
            this.btnLetsPlay.Location = new System.Drawing.Point(1136, 154);
            this.btnLetsPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(135, 81);
            this.btnLetsPlay.TabIndex = 19;
            this.btnLetsPlay.Text = "Lets Play the Game";
            this.btnLetsPlay.UseVisualStyleBackColor = false;
            this.btnLetsPlay.Click += new System.EventHandler(this.btnLetsPlay_Click);
            // 
            // btnCloseGame
            // 
            this.btnCloseGame.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseGame.Image = global::DSED_Project1_RandomGame.Properties.Resources.power_circular_button;
            this.btnCloseGame.Location = new System.Drawing.Point(1161, 35);
            this.btnCloseGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseGame.Name = "btnCloseGame";
            this.btnCloseGame.Size = new System.Drawing.Size(110, 93);
            this.btnCloseGame.TabIndex = 16;
            this.btnCloseGame.UseVisualStyleBackColor = false;
            this.btnCloseGame.Click += new System.EventHandler(this.btnCloseGame_Click_1);
            // 
            // btnTurnAway
            // 
            this.btnTurnAway.Image = global::DSED_Project1_RandomGame.Properties.Resources.bulletproof_vest1;
            this.btnTurnAway.Location = new System.Drawing.Point(804, 616);
            this.btnTurnAway.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTurnAway.Name = "btnTurnAway";
            this.btnTurnAway.Size = new System.Drawing.Size(161, 200);
            this.btnTurnAway.TabIndex = 2;
            this.btnTurnAway.UseVisualStyleBackColor = true;
            this.btnTurnAway.Click += new System.EventHandler(this.btnTurnAway_Click);
            // 
            // btnFIRE
            // 
            this.btnFIRE.Image = global::DSED_Project1_RandomGame.Properties.Resources.bullet;
            this.btnFIRE.Location = new System.Drawing.Point(432, 666);
            this.btnFIRE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFIRE.Name = "btnFIRE";
            this.btnFIRE.Size = new System.Drawing.Size(231, 101);
            this.btnFIRE.TabIndex = 1;
            this.btnFIRE.UseVisualStyleBackColor = true;
            this.btnFIRE.Click += new System.EventHandler(this.btnFIRE_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::DSED_Project1_RandomGame.Properties.Resources.revolver;
            this.btnLoad.Location = new System.Drawing.Point(45, 644);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(286, 145);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ptbAlive
            // 
            this.ptbAlive.Image = global::DSED_Project1_RandomGame.Properties.Resources.joyful;
            this.ptbAlive.Location = new System.Drawing.Point(46, 35);
            this.ptbAlive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbAlive.Name = "ptbAlive";
            this.ptbAlive.Size = new System.Drawing.Size(986, 781);
            this.ptbAlive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbAlive.TabIndex = 10;
            this.ptbAlive.TabStop = false;
            // 
            // label3
            // 
            this.label3.Image = global::DSED_Project1_RandomGame.Properties.Resources.right__1_;
            this.label3.Location = new System.Drawing.Point(624, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 64);
            this.label3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Image = global::DSED_Project1_RandomGame.Properties.Resources.game_over__1_;
            this.label2.Location = new System.Drawing.Point(282, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 79);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = global::DSED_Project1_RandomGame.Properties.Resources.win_64;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 82);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbDead
            // 
            this.ptbDead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbDead.Image = global::DSED_Project1_RandomGame.Properties.Resources.dead;
            this.ptbDead.Location = new System.Drawing.Point(44, 35);
            this.ptbDead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbDead.Name = "ptbDead";
            this.ptbDead.Size = new System.Drawing.Size(937, 775);
            this.ptbDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbDead.TabIndex = 8;
            this.ptbDead.TabStop = false;
            // 
            // ptbSafe
            // 
            this.ptbSafe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbSafe.BackColor = System.Drawing.Color.Transparent;
            this.ptbSafe.Image = global::DSED_Project1_RandomGame.Properties.Resources.smiling__1_;
            this.ptbSafe.Location = new System.Drawing.Point(299, 743);
            this.ptbSafe.Name = "ptbSafe";
            this.ptbSafe.Size = new System.Drawing.Size(986, 716);
            this.ptbSafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbSafe.TabIndex = 20;
            this.ptbSafe.TabStop = false;
            this.ptbSafe.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFIRE);
            this.panel1.Controls.Add(this.lblWins);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBulletFire);
            this.panel1.Controls.Add(this.lblTotalGames);
            this.panel1.Controls.Add(this.ptbDead);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalWinsAgain);
            this.panel1.Controls.Add(this.lblLoses2);
            this.panel1.Controls.Add(this.rtbHelpScreen);
            this.panel1.Controls.Add(this.btnTurnAway);
            this.panel1.Controls.Add(this.btnPlayAgainWin);
            this.panel1.Controls.Add(this.btnPlayAgainLose);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnCloseGame);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.ptbAlive);
            this.panel1.Controls.Add(this.ptbSafe);
            this.panel1.Controls.Add(this.btnLetsPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 921);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSafe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnFIRE;
        private System.Windows.Forms.Button btnTurnAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label lblBulletFire;
        private System.Windows.Forms.PictureBox ptbDead;
        private System.Windows.Forms.Button btnPlayAgainLose;
        private System.Windows.Forms.PictureBox ptbAlive;
        private System.Windows.Forms.Button btnPlayAgainWin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label lblTotalWinsAgain;
        private System.Windows.Forms.Label lblLoses2;
        private System.Windows.Forms.Button btnCloseGame;
        private System.Windows.Forms.RichTextBox rtbHelpScreen;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.PictureBox ptbSafe;
        private System.Windows.Forms.Panel panel1;
    }
}


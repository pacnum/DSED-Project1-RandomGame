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
            this.components = new System.ComponentModel.Container();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblBulletFire = new System.Windows.Forms.Label();
            this.btnPlayAgainLose = new System.Windows.Forms.Button();
            this.btnPlayAgainWin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTurnAway = new System.Windows.Forms.Button();
            this.btnFIRE = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ptbDead = new System.Windows.Forms.PictureBox();
            this.ptbAlive = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlive)).BeginInit();
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
            this.lblLoses.Location = new System.Drawing.Point(450, 60);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(112, 49);
            this.lblLoses.TabIndex = 6;
            this.lblLoses.Text = "0";
            this.lblLoses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBulletFire
            // 
            this.lblBulletFire.AllowDrop = true;
            this.lblBulletFire.Location = new System.Drawing.Point(844, 59);
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
            // btnTurnAway
            // 
            this.btnTurnAway.Image = global::DSED_Project1_RandomGame.Properties.Resources.bulletproof_vest1;
            this.btnTurnAway.Location = new System.Drawing.Point(804, 616);
            this.btnTurnAway.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTurnAway.Name = "btnTurnAway";
            this.btnTurnAway.Size = new System.Drawing.Size(161, 200);
            this.btnTurnAway.TabIndex = 2;
            this.btnTurnAway.Text = "Turn Away";
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
            this.btnFIRE.Text = "FIRE";
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


            this.ptbDead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbDead.Image = global::DSED_Project1_RandomGame.Properties.Resources.dead;
            this.ptbDead.Location = new System.Drawing.Point(45, 41);
            this.ptbDead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbDead.Name = "ptbDead";
            this.ptbDead.Size = new System.Drawing.Size(937, 775);
            this.ptbDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbDead.TabIndex = 8;
            this.ptbDead.TabStop = false;
            this.ptbAlive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbAlive.Image = global::DSED_Project1_RandomGame.Properties.Resources.joyful;
            this.ptbAlive.Location = new System.Drawing.Point(27, 35);
            this.ptbAlive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbAlive.Name = "ptbAlive";
            this.ptbAlive.Size = new System.Drawing.Size(954, 780);
            this.ptbAlive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbAlive.TabIndex = 10;
            this.ptbAlive.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "This is a tool tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 924);
            this.Controls.Add(this.btnPlayAgainWin);
            this.Controls.Add(this.btnPlayAgainLose);
            this.Controls.Add(this.lblBulletFire);
            this.Controls.Add(this.lblLoses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTurnAway);
            this.Controls.Add(this.btnFIRE);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.ptbDead);
            this.Controls.Add(this.ptbAlive);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlive)).EndInit();
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}


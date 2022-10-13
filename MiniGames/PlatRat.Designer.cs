using System.ComponentModel;

namespace MiniGames
{
    partial class PlatRat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.timerGame = new System.Timers.Timer();
            this.background = new System.Windows.Forms.PictureBox();
            this.blocSimple1 = new System.Windows.Forms.PictureBox();
            this.blocSimple2 = new System.Windows.Forms.PictureBox();
            this.blocThin1 = new System.Windows.Forms.PictureBox();
            this.blocSimple3 = new System.Windows.Forms.PictureBox();
            this.blocSimple4 = new System.Windows.Forms.PictureBox();
            this.blocSimple5 = new System.Windows.Forms.PictureBox();
            this.blocSimple6 = new System.Windows.Forms.PictureBox();
            this.blocSimple7 = new System.Windows.Forms.PictureBox();
            this.blocSpecial1 = new System.Windows.Forms.PictureBox();
            this.blocSimple8 = new System.Windows.Forms.PictureBox();
            this.blocSimple9 = new System.Windows.Forms.PictureBox();
            this.blocThin2 = new System.Windows.Forms.PictureBox();
            this.blocThin3 = new System.Windows.Forms.PictureBox();
            this.blocThin4 = new System.Windows.Forms.PictureBox();
            this.blocMoving1 = new System.Windows.Forms.PictureBox();
            this.blocMoving2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSpecial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20D;
            this.timerGame.SynchronizingObject = this;
            this.timerGame.Elapsed += new System.Timers.ElapsedEventHandler(this.timerGame_Elapsed);
            // 
            // background
            // 
            this.background.Image = global::MiniGames.Properties.Resources.NNZthjY;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(834, 593);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // blocSimple1
            // 
            this.blocSimple1.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple1.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple1.Location = new System.Drawing.Point(0, 346);
            this.blocSimple1.Name = "blocSimple1";
            this.blocSimple1.Size = new System.Drawing.Size(80, 80);
            this.blocSimple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple1.TabIndex = 1;
            this.blocSimple1.TabStop = false;
            this.blocSimple1.Tag = "bloc";
            // 
            // blocSimple2
            // 
            this.blocSimple2.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple2.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple2.Location = new System.Drawing.Point(80, 346);
            this.blocSimple2.Name = "blocSimple2";
            this.blocSimple2.Size = new System.Drawing.Size(80, 80);
            this.blocSimple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple2.TabIndex = 2;
            this.blocSimple2.TabStop = false;
            this.blocSimple2.Tag = "bloc";
            // 
            // blocThin1
            // 
            this.blocThin1.BackColor = System.Drawing.Color.Transparent;
            this.blocThin1.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocThin1.Location = new System.Drawing.Point(0, 554);
            this.blocThin1.Name = "blocThin1";
            this.blocThin1.Size = new System.Drawing.Size(160, 25);
            this.blocThin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocThin1.TabIndex = 3;
            this.blocThin1.TabStop = false;
            this.blocThin1.Tag = "bloc";
            // 
            // blocSimple3
            // 
            this.blocSimple3.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple3.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple3.Location = new System.Drawing.Point(246, 473);
            this.blocSimple3.Name = "blocSimple3";
            this.blocSimple3.Size = new System.Drawing.Size(80, 80);
            this.blocSimple3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple3.TabIndex = 4;
            this.blocSimple3.TabStop = false;
            this.blocSimple3.Tag = "bloc";
            // 
            // blocSimple4
            // 
            this.blocSimple4.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple4.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple4.Location = new System.Drawing.Point(0, 82);
            this.blocSimple4.Name = "blocSimple4";
            this.blocSimple4.Size = new System.Drawing.Size(80, 80);
            this.blocSimple4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple4.TabIndex = 5;
            this.blocSimple4.TabStop = false;
            this.blocSimple4.Tag = "bloc";
            // 
            // blocSimple5
            // 
            this.blocSimple5.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple5.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple5.Location = new System.Drawing.Point(290, 246);
            this.blocSimple5.Name = "blocSimple5";
            this.blocSimple5.Size = new System.Drawing.Size(80, 80);
            this.blocSimple5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple5.TabIndex = 6;
            this.blocSimple5.TabStop = false;
            this.blocSimple5.Tag = "bloc";
            // 
            // blocSimple6
            // 
            this.blocSimple6.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple6.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple6.Location = new System.Drawing.Point(367, 246);
            this.blocSimple6.Name = "blocSimple6";
            this.blocSimple6.Size = new System.Drawing.Size(80, 80);
            this.blocSimple6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple6.TabIndex = 7;
            this.blocSimple6.TabStop = false;
            this.blocSimple6.Tag = "bloc";
            // 
            // blocSimple7
            // 
            this.blocSimple7.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple7.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple7.Location = new System.Drawing.Point(367, 82);
            this.blocSimple7.Name = "blocSimple7";
            this.blocSimple7.Size = new System.Drawing.Size(80, 80);
            this.blocSimple7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple7.TabIndex = 8;
            this.blocSimple7.TabStop = false;
            this.blocSimple7.Tag = "bloc";
            // 
            // blocSpecial1
            // 
            this.blocSpecial1.BackColor = System.Drawing.Color.Transparent;
            this.blocSpecial1.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSpecial1.Location = new System.Drawing.Point(443, 82);
            this.blocSpecial1.Name = "blocSpecial1";
            this.blocSpecial1.Size = new System.Drawing.Size(80, 80);
            this.blocSpecial1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSpecial1.TabIndex = 9;
            this.blocSpecial1.TabStop = false;
            this.blocSpecial1.Tag = "bloc";
            // 
            // blocSimple8
            // 
            this.blocSimple8.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple8.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple8.Location = new System.Drawing.Point(754, 246);
            this.blocSimple8.Name = "blocSimple8";
            this.blocSimple8.Size = new System.Drawing.Size(80, 80);
            this.blocSimple8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple8.TabIndex = 10;
            this.blocSimple8.TabStop = false;
            this.blocSimple8.Tag = "bloc";
            // 
            // blocSimple9
            // 
            this.blocSimple9.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple9.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple9.Location = new System.Drawing.Point(754, 589);
            this.blocSimple9.Name = "blocSimple9";
            this.blocSimple9.Size = new System.Drawing.Size(80, 80);
            this.blocSimple9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple9.TabIndex = 11;
            this.blocSimple9.TabStop = false;
            this.blocSimple9.Tag = "bloc";
            // 
            // blocThin2
            // 
            this.blocThin2.BackColor = System.Drawing.Color.Transparent;
            this.blocThin2.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocThin2.Location = new System.Drawing.Point(326, 473);
            this.blocThin2.Name = "blocThin2";
            this.blocThin2.Size = new System.Drawing.Size(160, 25);
            this.blocThin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocThin2.TabIndex = 12;
            this.blocThin2.TabStop = false;
            this.blocThin2.Tag = "bloc";
            // 
            // blocThin3
            // 
            this.blocThin3.BackColor = System.Drawing.Color.Transparent;
            this.blocThin3.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocThin3.Location = new System.Drawing.Point(485, 554);
            this.blocThin3.Name = "blocThin3";
            this.blocThin3.Size = new System.Drawing.Size(160, 25);
            this.blocThin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocThin3.TabIndex = 13;
            this.blocThin3.TabStop = false;
            this.blocThin3.Tag = "bloc";
            // 
            // blocThin4
            // 
            this.blocThin4.BackColor = System.Drawing.Color.Transparent;
            this.blocThin4.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocThin4.Location = new System.Drawing.Point(674, 246);
            this.blocThin4.Name = "blocThin4";
            this.blocThin4.Size = new System.Drawing.Size(160, 25);
            this.blocThin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocThin4.TabIndex = 14;
            this.blocThin4.TabStop = false;
            this.blocThin4.Tag = "bloc";
            // 
            // blocMoving1
            // 
            this.blocMoving1.BackColor = System.Drawing.Color.Transparent;
            this.blocMoving1.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocMoving1.Location = new System.Drawing.Point(158, 161);
            this.blocMoving1.Name = "blocMoving1";
            this.blocMoving1.Size = new System.Drawing.Size(114, 25);
            this.blocMoving1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocMoving1.TabIndex = 15;
            this.blocMoving1.TabStop = false;
            this.blocMoving1.Tag = "bloc";
            // 
            // blocMoving2
            // 
            this.blocMoving2.BackColor = System.Drawing.Color.Transparent;
            this.blocMoving2.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocMoving2.Location = new System.Drawing.Point(531, 401);
            this.blocMoving2.Name = "blocMoving2";
            this.blocMoving2.Size = new System.Drawing.Size(114, 25);
            this.blocMoving2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocMoving2.TabIndex = 16;
            this.blocMoving2.TabStop = false;
            this.blocMoving2.Tag = "bloc";
            // 
            // PlatRat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MiniGames.Properties.Resources.NNZthjY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.blocMoving2);
            this.Controls.Add(this.blocMoving1);
            this.Controls.Add(this.blocThin4);
            this.Controls.Add(this.blocThin3);
            this.Controls.Add(this.blocThin2);
            this.Controls.Add(this.blocSimple9);
            this.Controls.Add(this.blocSimple8);
            this.Controls.Add(this.blocSpecial1);
            this.Controls.Add(this.blocSimple7);
            this.Controls.Add(this.blocSimple6);
            this.Controls.Add(this.blocSimple5);
            this.Controls.Add(this.blocSimple4);
            this.Controls.Add(this.blocSimple3);
            this.Controls.Add(this.blocThin1);
            this.Controls.Add(this.blocSimple2);
            this.Controls.Add(this.blocSimple1);
            this.Controls.Add(this.background);
            this.MinimumSize = new System.Drawing.Size(850, 638);
            this.Name = "PlatRat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The rat\'s sewers";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlatRat_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlatRat_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.timerGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSpecial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox blocMoving1;

        private System.Windows.Forms.PictureBox blocSimple7;

        private System.Windows.Forms.PictureBox blocMoving2;

        private System.Windows.Forms.PictureBox blocSimple9;

        private System.Windows.Forms.PictureBox blocSimple8;

        private System.Windows.Forms.PictureBox blocSpecial1;

        private System.Windows.Forms.PictureBox blocSimple6;

        private System.Windows.Forms.PictureBox blocSimple4;

        private System.Windows.Forms.PictureBox blocSimple5;

        private System.Windows.Forms.PictureBox blocSimple2;

        private System.Windows.Forms.PictureBox blocThin1;

        private System.Windows.Forms.PictureBox blocSimple1;

        private System.Windows.Forms.PictureBox background;

        private System.Timers.Timer timerGame;

        #endregion
    }
}
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
            this.blocSimple4 = new System.Windows.Forms.PictureBox();
            this.blocSimple5 = new System.Windows.Forms.PictureBox();
            this.blocSimple6 = new System.Windows.Forms.PictureBox();
            this.blocSimple7 = new System.Windows.Forms.PictureBox();
            this.blocSpecial1 = new System.Windows.Forms.PictureBox();
            this.blocSimple8 = new System.Windows.Forms.PictureBox();
            this.blocSimple9 = new System.Windows.Forms.PictureBox();
            this.blocThin2 = new System.Windows.Forms.PictureBox();
            this.blocMoving1 = new System.Windows.Forms.PictureBox();
            this.blocMoving2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.blocSimple3 = new System.Windows.Forms.PictureBox();
            this.blocThin3 = new System.Windows.Forms.PictureBox();
            this.blocThin4 = new System.Windows.Forms.PictureBox();
            this.message = new System.Windows.Forms.Label();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.livesCount = new System.Windows.Forms.Label();
            this.liveIcon = new System.Windows.Forms.PictureBox();
            this.cheeseIcon = new System.Windows.Forms.PictureBox();
            this.cheesesCount = new System.Windows.Forms.Label();
            this.exitDoor = new System.Windows.Forms.PictureBox();
            this.timeOffEnemies = new System.Timers.Timer();
            this.cheese1 = new System.Windows.Forms.PictureBox();
            this.cheese2 = new System.Windows.Forms.PictureBox();
            this.cheese3 = new System.Windows.Forms.PictureBox();
            this.cheese4 = new System.Windows.Forms.PictureBox();
            this.cheese5 = new System.Windows.Forms.PictureBox();
            this.cheese6 = new System.Windows.Forms.PictureBox();
            this.cheese7 = new System.Windows.Forms.PictureBox();
            this.cheese8 = new System.Windows.Forms.PictureBox();
            this.cheese9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSpecial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOffEnemies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese9)).BeginInit();
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
            this.background.Location = new System.Drawing.Point(0, -2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(834, 601);
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
            this.blocSimple9.Location = new System.Drawing.Point(754, 580);
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
            this.blocMoving2.Location = new System.Drawing.Point(531, 296);
            this.blocMoving2.Name = "blocMoving2";
            this.blocMoving2.Size = new System.Drawing.Size(114, 25);
            this.blocMoving2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocMoving2.TabIndex = 16;
            this.blocMoving2.TabStop = false;
            this.blocMoving2.Tag = "bloc";
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::MiniGames.Properties.Resources.cropRat;
            this.player1.Location = new System.Drawing.Point(12, 296);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(50, 50);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 17;
            this.player1.TabStop = false;
            // 
            // blocSimple3
            // 
            this.blocSimple3.BackColor = System.Drawing.Color.Transparent;
            this.blocSimple3.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocSimple3.Location = new System.Drawing.Point(249, 473);
            this.blocSimple3.Name = "blocSimple3";
            this.blocSimple3.Size = new System.Drawing.Size(80, 80);
            this.blocSimple3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocSimple3.TabIndex = 18;
            this.blocSimple3.TabStop = false;
            this.blocSimple3.Tag = "bloc";
            // 
            // blocThin3
            // 
            this.blocThin3.BackColor = System.Drawing.Color.Transparent;
            this.blocThin3.Image = global::MiniGames.Properties.Resources.blocShadow;
            this.blocThin3.Location = new System.Drawing.Point(465, 554);
            this.blocThin3.Name = "blocThin3";
            this.blocThin3.Size = new System.Drawing.Size(160, 25);
            this.blocThin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blocThin3.TabIndex = 19;
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
            this.blocThin4.TabIndex = 20;
            this.blocThin4.TabStop = false;
            this.blocThin4.Tag = "bloc";
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.message.Location = new System.Drawing.Point(547, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(273, 40);
            this.message.TabIndex = 21;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::MiniGames.Properties.Resources._542_5427076_colors_download_settings_cat_pixel_art;
            this.enemy1.Location = new System.Drawing.Point(376, 196);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(50, 50);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 22;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::MiniGames.Properties.Resources._542_5427076_colors_download_settings_cat_pixel_art;
            this.enemy2.Location = new System.Drawing.Point(386, 423);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(50, 50);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 23;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // livesCount
            // 
            this.livesCount.BackColor = System.Drawing.Color.Transparent;
            this.livesCount.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesCount.ForeColor = System.Drawing.Color.White;
            this.livesCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.livesCount.Location = new System.Drawing.Point(204, 10);
            this.livesCount.Name = "livesCount";
            this.livesCount.Size = new System.Drawing.Size(43, 40);
            this.livesCount.TabIndex = 25;
            this.livesCount.Text = "3";
            this.livesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // liveIcon
            // 
            this.liveIcon.BackColor = System.Drawing.Color.Transparent;
            this.liveIcon.Image = global::MiniGames.Properties.Resources.heart_pixel_art_254x254;
            this.liveIcon.Location = new System.Drawing.Point(158, 10);
            this.liveIcon.Name = "liveIcon";
            this.liveIcon.Size = new System.Drawing.Size(40, 40);
            this.liveIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.liveIcon.TabIndex = 26;
            this.liveIcon.TabStop = false;
            this.liveIcon.Tag = "icon";
            // 
            // cheeseIcon
            // 
            this.cheeseIcon.BackColor = System.Drawing.Color.Transparent;
            this.cheeseIcon.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheeseIcon.Location = new System.Drawing.Point(249, 12);
            this.cheeseIcon.Name = "cheeseIcon";
            this.cheeseIcon.Size = new System.Drawing.Size(40, 40);
            this.cheeseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheeseIcon.TabIndex = 27;
            this.cheeseIcon.TabStop = false;
            this.cheeseIcon.Tag = "icon";
            // 
            // cheesesCount
            // 
            this.cheesesCount.BackColor = System.Drawing.Color.Transparent;
            this.cheesesCount.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheesesCount.ForeColor = System.Drawing.Color.White;
            this.cheesesCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cheesesCount.Location = new System.Drawing.Point(295, 9);
            this.cheesesCount.Name = "cheesesCount";
            this.cheesesCount.Size = new System.Drawing.Size(43, 40);
            this.cheesesCount.TabIndex = 28;
            this.cheesesCount.Text = "0";
            this.cheesesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitDoor
            // 
            this.exitDoor.BackColor = System.Drawing.Color.Transparent;
            this.exitDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitDoor.Location = new System.Drawing.Point(674, 189);
            this.exitDoor.Name = "exitDoor";
            this.exitDoor.Size = new System.Drawing.Size(160, 57);
            this.exitDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitDoor.TabIndex = 29;
            this.exitDoor.TabStop = false;
            this.exitDoor.Tag = "";
            // 
            // timeOffEnemies
            // 
            this.timeOffEnemies.AutoReset = false;
            this.timeOffEnemies.Interval = 10000D;
            this.timeOffEnemies.SynchronizingObject = this;
            // 
            // cheese1
            // 
            this.cheese1.BackColor = System.Drawing.Color.Transparent;
            this.cheese1.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese1.Location = new System.Drawing.Point(23, 42);
            this.cheese1.Name = "cheese1";
            this.cheese1.Size = new System.Drawing.Size(34, 34);
            this.cheese1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese1.TabIndex = 31;
            this.cheese1.TabStop = false;
            this.cheese1.Tag = "cheese";
            // 
            // cheese2
            // 
            this.cheese2.BackColor = System.Drawing.Color.Transparent;
            this.cheese2.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese2.Location = new System.Drawing.Point(195, 121);
            this.cheese2.Name = "cheese2";
            this.cheese2.Size = new System.Drawing.Size(34, 34);
            this.cheese2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese2.TabIndex = 32;
            this.cheese2.TabStop = false;
            this.cheese2.Tag = "cheese";
            // 
            // cheese3
            // 
            this.cheese3.BackColor = System.Drawing.Color.Transparent;
            this.cheese3.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese3.Location = new System.Drawing.Point(326, 206);
            this.cheese3.Name = "cheese3";
            this.cheese3.Size = new System.Drawing.Size(34, 34);
            this.cheese3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese3.TabIndex = 33;
            this.cheese3.TabStop = false;
            this.cheese3.Tag = "cheese";
            // 
            // cheese4
            // 
            this.cheese4.BackColor = System.Drawing.Color.Transparent;
            this.cheese4.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese4.Location = new System.Drawing.Point(392, 42);
            this.cheese4.Name = "cheese4";
            this.cheese4.Size = new System.Drawing.Size(34, 34);
            this.cheese4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese4.TabIndex = 34;
            this.cheese4.TabStop = false;
            this.cheese4.Tag = "cheese";
            // 
            // cheese5
            // 
            this.cheese5.BackColor = System.Drawing.Color.Transparent;
            this.cheese5.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese5.Location = new System.Drawing.Point(742, 42);
            this.cheese5.Name = "cheese5";
            this.cheese5.Size = new System.Drawing.Size(34, 34);
            this.cheese5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese5.TabIndex = 35;
            this.cheese5.TabStop = false;
            this.cheese5.Tag = "cheese";
            // 
            // cheese6
            // 
            this.cheese6.BackColor = System.Drawing.Color.Transparent;
            this.cheese6.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese6.Location = new System.Drawing.Point(23, 514);
            this.cheese6.Name = "cheese6";
            this.cheese6.Size = new System.Drawing.Size(34, 34);
            this.cheese6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese6.TabIndex = 36;
            this.cheese6.TabStop = false;
            this.cheese6.Tag = "cheese";
            // 
            // cheese7
            // 
            this.cheese7.BackColor = System.Drawing.Color.Transparent;
            this.cheese7.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese7.Location = new System.Drawing.Point(274, 433);
            this.cheese7.Name = "cheese7";
            this.cheese7.Size = new System.Drawing.Size(34, 34);
            this.cheese7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese7.TabIndex = 37;
            this.cheese7.TabStop = false;
            this.cheese7.Tag = "cheese";
            // 
            // cheese8
            // 
            this.cheese8.BackColor = System.Drawing.Color.Transparent;
            this.cheese8.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese8.Location = new System.Drawing.Point(531, 514);
            this.cheese8.Name = "cheese8";
            this.cheese8.Size = new System.Drawing.Size(34, 34);
            this.cheese8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese8.TabIndex = 38;
            this.cheese8.TabStop = false;
            this.cheese8.Tag = "cheese";
            // 
            // cheese9
            // 
            this.cheese9.BackColor = System.Drawing.Color.Transparent;
            this.cheese9.Image = global::MiniGames.Properties.Resources._200_2009833_swiss_cheese_slice_pixel_art_swiss_cheese_pixel_art;
            this.cheese9.Location = new System.Drawing.Point(776, 540);
            this.cheese9.Name = "cheese9";
            this.cheese9.Size = new System.Drawing.Size(34, 34);
            this.cheese9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cheese9.TabIndex = 39;
            this.cheese9.TabStop = false;
            this.cheese9.Tag = "cheese";
            // 
            // PlatRat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::MiniGames.Properties.Resources.NNZthjY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.cheese9);
            this.Controls.Add(this.cheese8);
            this.Controls.Add(this.cheese7);
            this.Controls.Add(this.cheese6);
            this.Controls.Add(this.cheese5);
            this.Controls.Add(this.cheese4);
            this.Controls.Add(this.cheese3);
            this.Controls.Add(this.cheese2);
            this.Controls.Add(this.cheese1);
            this.Controls.Add(this.exitDoor);
            this.Controls.Add(this.cheesesCount);
            this.Controls.Add(this.cheeseIcon);
            this.Controls.Add(this.liveIcon);
            this.Controls.Add(this.livesCount);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.blocThin4);
            this.Controls.Add(this.blocThin3);
            this.Controls.Add(this.blocSimple3);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.blocMoving2);
            this.Controls.Add(this.blocMoving1);
            this.Controls.Add(this.blocThin2);
            this.Controls.Add(this.blocSimple9);
            this.Controls.Add(this.blocSimple8);
            this.Controls.Add(this.blocSpecial1);
            this.Controls.Add(this.blocSimple7);
            this.Controls.Add(this.blocSimple6);
            this.Controls.Add(this.blocSimple5);
            this.Controls.Add(this.blocSimple4);
            this.Controls.Add(this.blocThin1);
            this.Controls.Add(this.blocSimple2);
            this.Controls.Add(this.blocSimple1);
            this.Controls.Add(this.background);
            this.MinimumSize = new System.Drawing.Size(850, 638);
            this.Name = "PlatRat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The rat\'s sewers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlatRat_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlatRat_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlatRat_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.timerGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSpecial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocMoving2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocSimple3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocThin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOffEnemies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheese9)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox cheese1;

        private System.Windows.Forms.PictureBox cheese7;

        private System.Windows.Forms.PictureBox cheese8;

        private System.Windows.Forms.PictureBox cheese6;

        private System.Windows.Forms.PictureBox cheese5;
        private System.Windows.Forms.PictureBox cheese4;

        private System.Windows.Forms.PictureBox cheese9;

        private System.Windows.Forms.PictureBox cheese2;

        private System.Windows.Forms.PictureBox cheese3;

        private System.Timers.Timer timeOffEnemies;

        private System.Windows.Forms.PictureBox exitDoor;

        private System.Windows.Forms.Label message;

        private System.Windows.Forms.Label cheesesCount;

        private System.Windows.Forms.PictureBox cheeseIcon;

        private System.Windows.Forms.PictureBox liveIcon;

        private System.Windows.Forms.Label livesCount;

        private System.Windows.Forms.PictureBox enemy2;

        private System.Windows.Forms.PictureBox enemy1;

        private System.Windows.Forms.PictureBox blocThin3;

        private System.Windows.Forms.PictureBox blocSimple3;

        private System.Windows.Forms.PictureBox blocThin4;

        private System.Windows.Forms.PictureBox blocThin2;

        private System.Windows.Forms.PictureBox player1;

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
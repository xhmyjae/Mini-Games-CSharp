namespace MiniGames
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
            this.menuTitle = new System.Windows.Forms.Label();
            this.gameTitle1 = new System.Windows.Forms.Label();
            this.gameTitle2 = new System.Windows.Forms.Label();
            this.gameTitle3 = new System.Windows.Forms.Label();
            this.gameTitle4 = new System.Windows.Forms.Label();
            this.gameTitle8 = new System.Windows.Forms.Label();
            this.gameTitle5 = new System.Windows.Forms.Label();
            this.gameTitle6 = new System.Windows.Forms.Label();
            this.gameTitle7 = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuTitle
            // 
            this.menuTitle.BackColor = System.Drawing.Color.Transparent;
            this.menuTitle.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.ForeColor = System.Drawing.Color.Ivory;
            this.menuTitle.Location = new System.Drawing.Point(12, 28);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(808, 157);
            this.menuTitle.TabIndex = 0;
            this.menuTitle.Text = "funniest mini games ever";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTitle1
            // 
            this.gameTitle1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle1.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle1.Location = new System.Drawing.Point(21, 248);
            this.gameTitle1.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle1.Name = "gameTitle1";
            this.gameTitle1.Size = new System.Drawing.Size(84, 29);
            this.gameTitle1.TabIndex = 1;
            this.gameTitle1.Text = "PONG";
            this.gameTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle1.Click += new System.EventHandler(this.LoadPong);
            this.gameTitle1.MouseEnter += new System.EventHandler(this.gameTitle1_MouseEnter);
            this.gameTitle1.MouseLeave += new System.EventHandler(this.gameTitle1_MouseLeave);
            // 
            // gameTitle2
            // 
            this.gameTitle2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle2.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle2.Location = new System.Drawing.Point(178, 248);
            this.gameTitle2.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle2.Name = "gameTitle2";
            this.gameTitle2.Size = new System.Drawing.Size(182, 33);
            this.gameTitle2.TabIndex = 2;
            this.gameTitle2.Text = "PLATFORMER";
            this.gameTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle2.Click += new System.EventHandler(this.LoadPlatformer);
            this.gameTitle2.MouseEnter += new System.EventHandler(this.gameTitle2_MouseEnter);
            this.gameTitle2.MouseLeave += new System.EventHandler(this.gameTitle2_MouseLeave);
            // 
            // gameTitle3
            // 
            this.gameTitle3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle3.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle3.Location = new System.Drawing.Point(421, 248);
            this.gameTitle3.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle3.Name = "gameTitle3";
            this.gameTitle3.Size = new System.Drawing.Size(213, 33);
            this.gameTitle3.TabIndex = 3;
            this.gameTitle3.Text = "BRICK BREAKER";
            this.gameTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle3.MouseEnter += new System.EventHandler(this.gameTitle3_MouseEnter);
            this.gameTitle3.MouseLeave += new System.EventHandler(this.gameTitle3_MouseLeave);
            // 
            // gameTitle4
            // 
            this.gameTitle4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle4.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle4.Location = new System.Drawing.Point(693, 248);
            this.gameTitle4.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle4.Name = "gameTitle4";
            this.gameTitle4.Size = new System.Drawing.Size(124, 33);
            this.gameTitle4.TabIndex = 4;
            this.gameTitle4.Text = "PAC MAN";
            this.gameTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle4.MouseEnter += new System.EventHandler(this.gameTitle4_MouseEnter);
            this.gameTitle4.MouseLeave += new System.EventHandler(this.gameTitle4_MouseLeave);
            // 
            // gameTitle8
            // 
            this.gameTitle8.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle8.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle8.Location = new System.Drawing.Point(693, 345);
            this.gameTitle8.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle8.MinimumSize = new System.Drawing.Size(100, 32);
            this.gameTitle8.Name = "gameTitle8";
            this.gameTitle8.Size = new System.Drawing.Size(100, 32);
            this.gameTitle8.TabIndex = 5;
            this.gameTitle8.Text = "SNAKE";
            this.gameTitle8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle8.MouseEnter += new System.EventHandler(this.gameTitle8_MouseEnter);
            this.gameTitle8.MouseLeave += new System.EventHandler(this.gameTitle8_MouseLeave);
            // 
            // gameTitle5
            // 
            this.gameTitle5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle5.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle5.Location = new System.Drawing.Point(21, 345);
            this.gameTitle5.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle5.Name = "gameTitle5";
            this.gameTitle5.Size = new System.Drawing.Size(109, 32);
            this.gameTitle5.TabIndex = 6;
            this.gameTitle5.Text = "BASKET";
            this.gameTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle5.MouseEnter += new System.EventHandler(this.gameTitle5_MouseEnter);
            this.gameTitle5.MouseLeave += new System.EventHandler(this.gameTitle5_MouseLeave);
            // 
            // gameTitle6
            // 
            this.gameTitle6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle6.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle6.Location = new System.Drawing.Point(178, 345);
            this.gameTitle6.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle6.Name = "gameTitle6";
            this.gameTitle6.Size = new System.Drawing.Size(182, 32);
            this.gameTitle6.TabIndex = 7;
            this.gameTitle6.Text = "FLAPPY BIRD";
            this.gameTitle6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle6.MouseEnter += new System.EventHandler(this.gameTitle6_MouseEnter);
            this.gameTitle6.MouseLeave += new System.EventHandler(this.gameTitle6_MouseLeave);
            // 
            // gameTitle7
            // 
            this.gameTitle7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle7.ForeColor = System.Drawing.Color.Ivory;
            this.gameTitle7.Location = new System.Drawing.Point(421, 345);
            this.gameTitle7.Margin = new System.Windows.Forms.Padding(0);
            this.gameTitle7.Name = "gameTitle7";
            this.gameTitle7.Size = new System.Drawing.Size(226, 32);
            this.gameTitle7.TabIndex = 8;
            this.gameTitle7.Text = "SPACE INVADERS";
            this.gameTitle7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameTitle7.MouseEnter += new System.EventHandler(this.gameTitle7_MouseEnter);
            this.gameTitle7.MouseLeave += new System.EventHandler(this.gameTitle7_MouseLeave);
            // 
            // helpBtn
            // 
            this.helpBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.Ivory;
            this.helpBtn.Location = new System.Drawing.Point(386, 487);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(77, 43);
            this.helpBtn.TabIndex = 9;
            this.helpBtn.Text = "HELP";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpBtn.MouseEnter += new System.EventHandler(this.helpBtn_MouseEnter);
            this.helpBtn.MouseLeave += new System.EventHandler(this.helpBtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Ivory;
            this.exitBtn.Location = new System.Drawing.Point(386, 530);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(77, 43);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.Exit);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.gameTitle1);
            this.Controls.Add(this.gameTitle2);
            this.Controls.Add(this.gameTitle3);
            this.Controls.Add(this.gameTitle4);
            this.Controls.Add(this.gameTitle5);
            this.Controls.Add(this.gameTitle6);
            this.Controls.Add(this.gameTitle7);
            this.Controls.Add(this.gameTitle8);
            this.Controls.Add(this.menuTitle);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(850, 638);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.GamesMenu_Load);
            this.Resize += new System.EventHandler(this.GamesMenu_Resize);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Label helpBtn;
        private System.Windows.Forms.Label gameTitle1;
        private System.Windows.Forms.Label gameTitle2;
        private System.Windows.Forms.Label gameTitle3;
        private System.Windows.Forms.Label gameTitle4;
        private System.Windows.Forms.Label gameTitle5;
        private System.Windows.Forms.Label gameTitle6;
        private System.Windows.Forms.Label gameTitle7;
        private System.Windows.Forms.Label gameTitle8;
        private System.Windows.Forms.Label menuTitle;

        #endregion
    }
}
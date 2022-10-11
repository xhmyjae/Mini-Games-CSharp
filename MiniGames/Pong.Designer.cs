using System.ComponentModel;

namespace MiniGames
{
    partial class Pong
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
            this.midLine = new System.Windows.Forms.PictureBox();
            this.scorePlayer1 = new System.Windows.Forms.Label();
            this.scorePlayer2 = new System.Windows.Forms.Label();
            this.boxPlayer1 = new System.Windows.Forms.PictureBox();
            this.boxPlayer2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timeRepeat = new System.Timers.Timer();
            this.winTextPlayer1 = new System.Windows.Forms.Label();
            this.winTextPlayer2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.midLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // midLine
            // 
            this.midLine.BackColor = System.Drawing.Color.Ivory;
            this.midLine.Location = new System.Drawing.Point(404, -5);
            this.midLine.Name = "midLine";
            this.midLine.Size = new System.Drawing.Size(8, 614);
            this.midLine.TabIndex = 0;
            this.midLine.TabStop = false;
            // 
            // scorePlayer1
            // 
            this.scorePlayer1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer1.ForeColor = System.Drawing.Color.Ivory;
            this.scorePlayer1.Location = new System.Drawing.Point(305, 21);
            this.scorePlayer1.Name = "scorePlayer1";
            this.scorePlayer1.Size = new System.Drawing.Size(68, 43);
            this.scorePlayer1.TabIndex = 1;
            this.scorePlayer1.Text = "00";
            // 
            // scorePlayer2
            // 
            this.scorePlayer2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePlayer2.ForeColor = System.Drawing.Color.Ivory;
            this.scorePlayer2.Location = new System.Drawing.Point(444, 21);
            this.scorePlayer2.Name = "scorePlayer2";
            this.scorePlayer2.Size = new System.Drawing.Size(68, 43);
            this.scorePlayer2.TabIndex = 2;
            this.scorePlayer2.Text = "00";
            // 
            // boxPlayer1
            // 
            this.boxPlayer1.BackColor = System.Drawing.Color.Aqua;
            this.boxPlayer1.Location = new System.Drawing.Point(12, 217);
            this.boxPlayer1.Name = "boxPlayer1";
            this.boxPlayer1.Size = new System.Drawing.Size(36, 162);
            this.boxPlayer1.TabIndex = 3;
            this.boxPlayer1.TabStop = false;
            // 
            // boxPlayer2
            // 
            this.boxPlayer2.BackColor = System.Drawing.Color.Chartreuse;
            this.boxPlayer2.Location = new System.Drawing.Point(784, 217);
            this.boxPlayer2.Name = "boxPlayer2";
            this.boxPlayer2.Size = new System.Drawing.Size(36, 162);
            this.boxPlayer2.TabIndex = 4;
            this.boxPlayer2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.DeepPink;
            this.ball.Location = new System.Drawing.Point(397, 21);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(23, 23);
            this.ball.TabIndex = 5;
            this.ball.TabStop = false;
            // 
            // timeRepeat
            // 
            this.timeRepeat.Enabled = true;
            this.timeRepeat.Interval = 10D;
            this.timeRepeat.SynchronizingObject = this;
            this.timeRepeat.Elapsed += new System.Timers.ElapsedEventHandler(this.timeRepeat_Elapsed);
            // 
            // winTextPlayer1
            // 
            this.winTextPlayer1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winTextPlayer1.ForeColor = System.Drawing.Color.Ivory;
            this.winTextPlayer1.Location = new System.Drawing.Point(270, 98);
            this.winTextPlayer1.Name = "winTextPlayer1";
            this.winTextPlayer1.Size = new System.Drawing.Size(287, 49);
            this.winTextPlayer1.TabIndex = 7;
            this.winTextPlayer1.Text = "Player 1 WON !";
            this.winTextPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winTextPlayer2
            // 
            this.winTextPlayer2.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winTextPlayer2.ForeColor = System.Drawing.Color.Ivory;
            this.winTextPlayer2.Location = new System.Drawing.Point(263, 98);
            this.winTextPlayer2.Name = "winTextPlayer2";
            this.winTextPlayer2.Size = new System.Drawing.Size(294, 49);
            this.winTextPlayer2.TabIndex = 8;
            this.winTextPlayer2.Text = "Player 2 WON !";
            this.winTextPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.winTextPlayer2);
            this.Controls.Add(this.winTextPlayer1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.boxPlayer2);
            this.Controls.Add(this.boxPlayer1);
            this.Controls.Add(this.scorePlayer2);
            this.Controls.Add(this.scorePlayer1);
            this.Controls.Add(this.midLine);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pong_FormClosing);
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            this.Resize += new System.EventHandler(this.Pong_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.midLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeRepeat)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label winTextPlayer1;
        private System.Windows.Forms.Label winTextPlayer2;

        private System.Timers.Timer timeRepeat;

        private System.Windows.Forms.PictureBox boxPlayer2;

        private System.Windows.Forms.PictureBox boxPlayer1;

        private System.Windows.Forms.Label scorePlayer2;
        private System.Windows.Forms.PictureBox ball;

        private System.Windows.Forms.Label scorePlayer1;

        private System.Windows.Forms.PictureBox midLine;

        #endregion
    }
}
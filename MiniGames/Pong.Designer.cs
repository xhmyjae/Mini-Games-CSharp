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
            this.boxPLayer2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.midLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPLayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
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
            // boxPLayer2
            // 
            this.boxPLayer2.BackColor = System.Drawing.Color.Chartreuse;
            this.boxPLayer2.Location = new System.Drawing.Point(784, 217);
            this.boxPLayer2.Name = "boxPLayer2";
            this.boxPLayer2.Size = new System.Drawing.Size(36, 162);
            this.boxPLayer2.TabIndex = 4;
            this.boxPLayer2.TabStop = false;
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
            // Pong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.boxPLayer2);
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
            this.Resize += new System.EventHandler(this.Pong_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.midLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPLayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox boxPLayer2;

        private System.Windows.Forms.PictureBox boxPlayer1;

        private System.Windows.Forms.Label scorePlayer2;
        private System.Windows.Forms.PictureBox ball;

        private System.Windows.Forms.Label scorePlayer1;

        private System.Windows.Forms.PictureBox midLine;

        #endregion
    }
}
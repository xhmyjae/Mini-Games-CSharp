using System.ComponentModel;

namespace MiniGames
{
    partial class Platformer
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
            this.bloc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.bloc)).BeginInit();
            this.SuspendLayout();
            // 
            // bloc
            // 
            this.bloc.BackColor = System.Drawing.Color.Ivory;
            this.bloc.Location = new System.Drawing.Point(-1, 532);
            this.bloc.Name = "bloc";
            this.bloc.Size = new System.Drawing.Size(60, 60);
            this.bloc.TabIndex = 0;
            this.bloc.TabStop = false;
            // 
            // Platformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (24)))), ((int) (((byte) (24)))));
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.bloc);
            this.Name = "Platformer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platformer";
            ((System.ComponentModel.ISupportInitialize) (this.bloc)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox bloc;

        #endregion
    }
}
﻿namespace plantsVSzombies
{
    partial class frmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));

            this.label_quit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_quit
            // 
            this.label_quit.Image = ((System.Drawing.Image)(resources.GetObject("label_quit.Image")));
            this.label_quit.Location = new System.Drawing.Point(624, 523);
            this.label_quit.Name = "label_quit";
            this.label_quit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_quit.Size = new System.Drawing.Size(100, 23);
            this.label_quit.TabIndex = 0;
            this.label_quit.Click += new System.EventHandler(this.label1_Click);
            this.label_quit.MouseEnter += new System.EventHandler(this.label_quit_MouseEnter);
            this.label_quit.MouseLeave += new System.EventHandler(this.label_quit_MouseLeave);

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 592);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(793, 589);

            this.Controls.Add(this.label_quit);

            this.Controls.Add(this.pictureBox1);

            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOptions";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Label label_quit;




    }
}
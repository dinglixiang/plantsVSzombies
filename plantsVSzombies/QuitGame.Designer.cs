namespace plantsVSzombies
{
    partial class QuitGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitGame));
            this.lblExit = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Image = ((System.Drawing.Image)(resources.GetObject("lblExit.Image")));
            this.lblExit.Location = new System.Drawing.Point(55, 226);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(160, 42);
            this.lblExit.TabIndex = 1;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.Image = ((System.Drawing.Image)(resources.GetObject("lblCancel.Image")));
            this.lblCancel.Location = new System.Drawing.Point(232, 226);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(160, 42);
            this.lblCancel.TabIndex = 2;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // QuitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(431, 295);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuitGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuitGame";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuitGame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QuitGame_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.QuitGame_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblCancel;
    }
}
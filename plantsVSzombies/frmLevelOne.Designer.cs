namespace plantsVSzombies
{
    partial class frmLevelOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelOne));
            this.pictureBox_Peashooter = new System.Windows.Forms.PictureBox();
            this.timer_gameSpeed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Peashooter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Peashooter
            // 
            this.pictureBox_Peashooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Peashooter.BackgroundImage")));
            this.pictureBox_Peashooter.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox_Peashooter.Name = "pictureBox_Peashooter";
            this.pictureBox_Peashooter.Size = new System.Drawing.Size(99, 62);
            this.pictureBox_Peashooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Peashooter.TabIndex = 0;
            this.pictureBox_Peashooter.TabStop = false;
            this.pictureBox_Peashooter.Click += new System.EventHandler(this.pictureBox_Peashooter_Click);
            // 
            // timer_gameSpeed
            // 
            this.timer_gameSpeed.Interval = 50;
            this.timer_gameSpeed.Tick += new System.EventHandler(this.timer_gameSpeed_Tick);
            // 
            // frmLevelOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 680);
            this.Controls.Add(this.pictureBox_Peashooter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLevelOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "植物大战僵尸";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLevelOne_FormClosed);
            this.Load += new System.EventHandler(this.frmLevelOne_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLevelOne_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLevelOne_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Peashooter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Peashooter;
        private System.Windows.Forms.Timer timer_gameSpeed;
    }
}
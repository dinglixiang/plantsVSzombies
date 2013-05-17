namespace plantsVSzombies
{
    partial class frmSelectLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectLevel));
            this.btnfirstlevel = new System.Windows.Forms.Button();
            this.btnsecondlevel = new System.Windows.Forms.Button();
            this.pbback = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfirstlevel
            // 
            this.btnfirstlevel.Location = new System.Drawing.Point(104, 220);
            this.btnfirstlevel.Name = "btnfirstlevel";
            this.btnfirstlevel.Size = new System.Drawing.Size(76, 39);
            this.btnfirstlevel.TabIndex = 0;
            this.btnfirstlevel.Text = "第一关";
            this.btnfirstlevel.UseVisualStyleBackColor = true;
            this.btnfirstlevel.Click += new System.EventHandler(this.btnfirstlevel_Click);
            // 
            // btnsecondlevel
            // 
            this.btnsecondlevel.Location = new System.Drawing.Point(287, 220);
            this.btnsecondlevel.Name = "btnsecondlevel";
            this.btnsecondlevel.Size = new System.Drawing.Size(69, 39);
            this.btnsecondlevel.TabIndex = 0;
            this.btnsecondlevel.Text = "第二关";
            this.btnsecondlevel.UseVisualStyleBackColor = true;
            // 
            // pbback
            // 
            this.pbback.BackColor = System.Drawing.Color.Transparent;
            this.pbback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbback.BackgroundImage")));
            this.pbback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbback.Location = new System.Drawing.Point(580, 7);
            this.pbback.Name = "pbback";
            this.pbback.Size = new System.Drawing.Size(59, 59);
            this.pbback.TabIndex = 1;
            this.pbback.TabStop = false;
            this.pbback.Click += new System.EventHandler(this.pbback_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(68, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 191);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(247, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 191);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frmSelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(648, 432);
            this.Controls.Add(this.pbback);
            this.Controls.Add(this.btnsecondlevel);
            this.Controls.Add(this.btnfirstlevel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "植物大战僵尸";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelectLevel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfirstlevel;
        private System.Windows.Forms.Button btnsecondlevel;
        private System.Windows.Forms.PictureBox pbback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
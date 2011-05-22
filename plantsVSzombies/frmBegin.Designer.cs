namespace plantsVSzombies
{
    partial class frmBegin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBegin));
            this.panel_logo = new System.Windows.Forms.Panel();
            this.timer_logo = new System.Windows.Forms.Timer(this.components);
            this.linkBeginHover = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1_grassCircle = new System.Windows.Forms.Timer(this.components);
            this.timer2_grassCircle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_logo.Location = new System.Drawing.Point(-2, -3);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(796, 592);
            this.panel_logo.TabIndex = 2;
            // 
            // timer_logo
            // 
            this.timer_logo.Tick += new System.EventHandler(this.timer_logo_Tick);
            // 
            // linkBeginHover
            // 
            this.linkBeginHover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.linkBeginHover.BackColor = System.Drawing.Color.Transparent;
            this.linkBeginHover.Location = new System.Drawing.Point(358, 548);
            this.linkBeginHover.Name = "linkBeginHover";
            this.linkBeginHover.Size = new System.Drawing.Size(88, 20);
            this.linkBeginHover.TabIndex = 4;
            this.linkBeginHover.Click += new System.EventHandler(this.linkBeginHover_Click);
            this.linkBeginHover.MouseEnter += new System.EventHandler(this.linkBeginHover_MouseEnter);
            this.linkBeginHover.MouseLeave += new System.EventHandler(this.linkBeginHover_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, -106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 114);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1_grassCircle
            // 
            this.timer1_grassCircle.Tick += new System.EventHandler(this.timer1_grassCircle_Tick);
            // 
            // timer2_grassCircle
            // 
            this.timer2_grassCircle.Interval = 50;
            this.timer2_grassCircle.Tick += new System.EventHandler(this.timer2_grassCircle_Tick);
            // 
            // frmBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 589);
            this.Controls.Add(this.panel_logo);
            this.Controls.Add(this.linkBeginHover);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBegin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "植物大战僵尸";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBegin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBegin_FormClosed);
            this.Load += new System.EventHandler(this.frmBegin_Load);
            this.SizeChanged += new System.EventHandler(this.frmBegin_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmBegin_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Timer timer_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1_grassCircle;
        private System.Windows.Forms.Timer timer2_grassCircle;
        public System.Windows.Forms.Label linkBeginHover;

    }
}


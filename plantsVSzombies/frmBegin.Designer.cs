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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBegin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkBegin = new System.Windows.Forms.LinkLabel();
            this.linkBeginHover = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 593);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkBegin
            // 
            this.linkBegin.AutoSize = true;
            this.linkBegin.BackColor = System.Drawing.Color.Transparent;
            this.linkBegin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkBegin.Image = ((System.Drawing.Image)(resources.GetObject("linkBegin.Image")));
            this.linkBegin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkBegin.Location = new System.Drawing.Point(344, 540);
            this.linkBegin.Name = "linkBegin";
            this.linkBegin.Size = new System.Drawing.Size(104, 16);
            this.linkBegin.TabIndex = 1;
            this.linkBegin.TabStop = true;
            this.linkBegin.Text = "            ";
            this.linkBegin.MouseEnter += new System.EventHandler(this.linkBegin_MouseEnter);
            // 
            // linkBeginHover
            // 
            this.linkBeginHover.BackColor = System.Drawing.Color.Transparent;
            this.linkBeginHover.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkBeginHover.Image = ((System.Drawing.Image)(resources.GetObject("linkBeginHover.Image")));
            this.linkBeginHover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkBeginHover.Location = new System.Drawing.Point(347, 540);
            this.linkBeginHover.Name = "linkBeginHover";
            this.linkBeginHover.Size = new System.Drawing.Size(104, 16);
            this.linkBeginHover.TabIndex = 1;
            this.linkBeginHover.TabStop = true;
            this.linkBeginHover.Text = "          ";
            this.linkBeginHover.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBeginHover_LinkClicked);
            this.linkBeginHover.MouseLeave += new System.EventHandler(this.linkBeginHover_MouseLeave);
            // 
            // frmBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 589);
            this.Controls.Add(this.linkBeginHover);
            this.Controls.Add(this.linkBegin);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmBegin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "植物大战僵尸中文版";
            this.Load += new System.EventHandler(this.frmBegin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkBegin;
        private System.Windows.Forms.LinkLabel linkBeginHover;

    }
}


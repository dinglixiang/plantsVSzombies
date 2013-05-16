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
            this.btnfirstlevel = new System.Windows.Forms.Button();
            this.btnsecondlevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfirstlevel
            // 
            this.btnfirstlevel.Location = new System.Drawing.Point(13, 28);
            this.btnfirstlevel.Name = "btnfirstlevel";
            this.btnfirstlevel.Size = new System.Drawing.Size(185, 355);
            this.btnfirstlevel.TabIndex = 0;
            this.btnfirstlevel.Text = "第一关";
            this.btnfirstlevel.UseVisualStyleBackColor = true;
            this.btnfirstlevel.Click += new System.EventHandler(this.btnfirstlevel_Click);
            // 
            // btnsecondlevel
            // 
            this.btnsecondlevel.Location = new System.Drawing.Point(236, 28);
            this.btnsecondlevel.Name = "btnsecondlevel";
            this.btnsecondlevel.Size = new System.Drawing.Size(185, 355);
            this.btnsecondlevel.TabIndex = 0;
            this.btnsecondlevel.Text = "第二关";
            this.btnsecondlevel.UseVisualStyleBackColor = true;
            // 
            // frmSelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 394);
            this.Controls.Add(this.btnsecondlevel);
            this.Controls.Add(this.btnfirstlevel);
            this.Name = "frmSelectLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "植物大战僵尸";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelectLevel_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfirstlevel;
        private System.Windows.Forms.Button btnsecondlevel;
    }
}
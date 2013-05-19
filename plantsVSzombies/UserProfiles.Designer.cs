namespace plantsVSzombies
{
    partial class UserProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfiles));
            this.label_ok = new System.Windows.Forms.Label();
            this.label_delet_user = new System.Windows.Forms.Label();
            this.label_cancel = new System.Windows.Forms.Label();
            this.label_rename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ok
            // 
            this.label_ok.BackColor = System.Drawing.Color.Transparent;
            this.label_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ok.Location = new System.Drawing.Point(64, 463);
            this.label_ok.Name = "label_ok";
            this.label_ok.Size = new System.Drawing.Size(214, 47);
            this.label_ok.TabIndex = 0;
            this.label_ok.Click += new System.EventHandler(this.label_ok_Click);
            this.label_ok.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_ok_MouseDown);
            this.label_ok.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_ok_MouseUp);
            // 
            // label_delet_user
            // 
            this.label_delet_user.BackColor = System.Drawing.Color.Transparent;
            this.label_delet_user.Location = new System.Drawing.Point(292, 423);
            this.label_delet_user.Name = "label_delet_user";
            this.label_delet_user.Size = new System.Drawing.Size(208, 36);
            this.label_delet_user.TabIndex = 1;
            this.label_delet_user.Click += new System.EventHandler(this.label_delet_user_Click);
            // 
            // label_cancel
            // 
            this.label_cancel.BackColor = System.Drawing.Color.Transparent;
            this.label_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_cancel.Location = new System.Drawing.Point(294, 465);
            this.label_cancel.Name = "label_cancel";
            this.label_cancel.Size = new System.Drawing.Size(206, 45);
            this.label_cancel.TabIndex = 2;
            this.label_cancel.Click += new System.EventHandler(this.label_cancel_Click);
            // 
            // label_rename
            // 
            this.label_rename.BackColor = System.Drawing.Color.Transparent;
            this.label_rename.Location = new System.Drawing.Point(66, 414);
            this.label_rename.Name = "label_rename";
            this.label_rename.Size = new System.Drawing.Size(212, 45);
            this.label_rename.TabIndex = 3;
            this.label_rename.Click += new System.EventHandler(this.label_rename_Click);
            // 
            // UserProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 529);
            this.Controls.Add(this.label_rename);
            this.Controls.Add(this.label_cancel);
            this.Controls.Add(this.label_delet_user);
            this.Controls.Add(this.label_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfiles";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.UserProfiles_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserProfiles_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserProfiles_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserProfiles_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ok;
        private System.Windows.Forms.Label label_delet_user;
        private System.Windows.Forms.Label label_cancel;
        private System.Windows.Forms.Label label_rename;

    }
}
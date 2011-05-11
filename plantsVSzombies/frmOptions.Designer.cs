namespace plantsVSzombies
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.label_quit = new System.Windows.Forms.Label();
            this.label_help = new System.Windows.Forms.Label();
            this.label_choice = new System.Windows.Forms.Label();
            this.label_risk = new System.Windows.Forms.Label();
            this.label_easygame = new System.Windows.Forms.Label();
            this.label_shop = new System.Windows.Forms.Label();
            this.label_page = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_quit
            // 
            this.label_quit.BackColor = System.Drawing.Color.Transparent;
            this.label_quit.Location = new System.Drawing.Point(708, 534);
            this.label_quit.Name = "label_quit";
            this.label_quit.Size = new System.Drawing.Size(73, 27);
            this.label_quit.TabIndex = 1;
            this.label_quit.Click += new System.EventHandler(this.label1_Click);
            this.label_quit.MouseEnter += new System.EventHandler(this.label_quit_MouseEnter);
            this.label_quit.MouseLeave += new System.EventHandler(this.label_quit_MouseLeave);
            // 
            // label_help
            // 
            this.label_help.BackColor = System.Drawing.Color.Transparent;
            this.label_help.Location = new System.Drawing.Point(642, 545);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(60, 26);
            this.label_help.TabIndex = 2;
            this.label_help.MouseEnter += new System.EventHandler(this.label_help_MouseEnter);
            this.label_help.MouseLeave += new System.EventHandler(this.label_help_MouseLeave);
            // 
            // label_choice
            // 
            this.label_choice.BackColor = System.Drawing.Color.Transparent;
            this.label_choice.Location = new System.Drawing.Point(575, 509);
            this.label_choice.Name = "label_choice";
            this.label_choice.Size = new System.Drawing.Size(63, 27);
            this.label_choice.TabIndex = 3;
            this.label_choice.MouseEnter += new System.EventHandler(this.label_choice_MouseEnter);
            this.label_choice.MouseLeave += new System.EventHandler(this.label_choice_MouseLeave);
            // 
            // label_risk
            // 
            this.label_risk.BackColor = System.Drawing.Color.Transparent;
            this.label_risk.Location = new System.Drawing.Point(405, 95);
            this.label_risk.Name = "label_risk";
            this.label_risk.Size = new System.Drawing.Size(330, 114);
            this.label_risk.TabIndex = 4;
            this.label_risk.MouseEnter += new System.EventHandler(this.label_risk_MouseEnter);
            this.label_risk.MouseLeave += new System.EventHandler(this.label_risk_MouseLeave);
            // 
            // label_easygame
            // 
            this.label_easygame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_easygame.BackColor = System.Drawing.Color.Transparent;
            this.label_easygame.Location = new System.Drawing.Point(405, 194);
            this.label_easygame.Name = "label_easygame";
            this.label_easygame.Size = new System.Drawing.Size(306, 127);
            this.label_easygame.TabIndex = 5;
            this.label_easygame.MouseEnter += new System.EventHandler(this.label_easegame_MouseEnter);
            this.label_easygame.MouseLeave += new System.EventHandler(this.label_easegame_MouseLeave);
            // 
            // label_shop
            // 
            this.label_shop.BackColor = System.Drawing.Color.Transparent;
            this.label_shop.Location = new System.Drawing.Point(406, 496);
            this.label_shop.Name = "label_shop";
            this.label_shop.Size = new System.Drawing.Size(128, 94);
            this.label_shop.TabIndex = 6;
            this.label_shop.MouseEnter += new System.EventHandler(this.label_shop_MouseEnter);
            this.label_shop.MouseLeave += new System.EventHandler(this.label_shop_MouseLeave);
            // 
            // label_page
            // 
            this.label_page.BackColor = System.Drawing.Color.Transparent;
            this.label_page.Image = ((System.Drawing.Image)(resources.GetObject("label_page.Image")));
            this.label_page.Location = new System.Drawing.Point(329, 441);
            this.label_page.Name = "label_page";
            this.label_page.Size = new System.Drawing.Size(100, 106);
            this.label_page.TabIndex = 7;
            this.label_page.MouseEnter += new System.EventHandler(this.label_page_MouseEnter);
            this.label_page.MouseLeave += new System.EventHandler(this.label_page_MouseLeave);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 589);
            this.Controls.Add(this.label_page);
            this.Controls.Add(this.label_shop);
            this.Controls.Add(this.label_risk);
            this.Controls.Add(this.label_choice);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.label_quit);
            this.Controls.Add(this.label_easygame);
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOptions";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmOptions_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_quit;
        private System.Windows.Forms.Label label_help;
        private System.Windows.Forms.Label label_choice;
        private System.Windows.Forms.Label label_risk;
        private System.Windows.Forms.Label label_easygame;
        private System.Windows.Forms.Label label_shop;
        private System.Windows.Forms.Label label_page;






    }
}
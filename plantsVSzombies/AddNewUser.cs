using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace plantsVSzombies
{
    public partial class AddNewUser : Form
    {
        private UserOperate userOperate = new UserOperate();
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text.Equals("") || textBox_username.Text == null || textBox_username.Text == "")
            { MessageBox.Show("用户名不能为空"); return; }
            if (userOperate.addUser(textBox_username.Text)) 
            {
                frmOptions.label_username.Text = textBox_username.Text;//将选中的username赋给frmOptions.label_username
                this.Close(); 
            }
            else { MessageBox.Show("用户名重复"); return; }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

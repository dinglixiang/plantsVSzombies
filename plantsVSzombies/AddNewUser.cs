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
            userOperate.addUser(textBox_username.Text);
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

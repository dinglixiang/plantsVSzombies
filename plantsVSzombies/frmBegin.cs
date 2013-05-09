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
    public partial class frmBegin : Form
    {
        public frmBegin()
        {
            InitializeComponent();
        }

        private void linkBegin_MouseEnter(object sender, EventArgs e)
        {
            linkBeginHover.Show();
        }

        private void frmBegin_Load(object sender, EventArgs e)
        {
            linkBeginHover.Hide();
        }

        private void linkBeginHover_MouseLeave(object sender, EventArgs e)
        {
            linkBeginHover.Hide();
        }

        private void linkBeginHover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOptions frmo = new frmOptions();          
            frmo.Show();
           
        }
    }
}

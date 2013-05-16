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
    public partial class frmLevelOne : Form
    {
        public frmLevelOne()
        {
            InitializeComponent();
        }

        private void frmLevelOne_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

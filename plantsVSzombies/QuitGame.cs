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
    public partial class QuitGame : Form
    {
        public QuitGame()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

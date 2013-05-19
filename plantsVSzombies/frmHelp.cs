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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            Music.stopBackMusic();//停止背景音乐
            //防止进度条滚动时闪屏（挺管用）
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOptions frmo = new frmOptions();
            frmo.Show();
        }

        private void frmHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHelp_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Music.stopBackMusic();//停止背景音乐
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                Music.playBackMusic();
            }
        }
    }
}

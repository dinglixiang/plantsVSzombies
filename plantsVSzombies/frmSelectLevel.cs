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
    public partial class frmSelectLevel : Form
    {
        public frmSelectLevel()
        {
            InitializeComponent();
            //防止进度条滚动时闪屏（挺管用）
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void frmSelectLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnfirstlevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLevelOne levelone = new frmLevelOne();
            levelone.Show();
        }

        private void pbback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOptions frmo = new frmOptions();
            frmo.Show();
        }

        private void lblsecondlevel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("偶还没解锁哦！");
        }

        private void frmSelectLevel_SizeChanged(object sender, EventArgs e)
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

        private void pbfirst_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            pbfirst.BackgroundImage = Image.FromFile("../../images/xiao2.png");
            pbfirst.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pbfirst_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            pbfirst.BackgroundImage = Image.FromFile("../../images/xiao1.png");
            pbfirst.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pbsecond_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            pbsecond.BackgroundImage = Image.FromFile("../../images/xiao2.png");
            pbsecond.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pbsecond_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            pbsecond.BackgroundImage = Image.FromFile("../../images/xiao1.png");
            pbsecond.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pbback_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
        }

        private void pbback_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
        }
    }
}

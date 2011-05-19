using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using plantsVSzombies.model;
using plantsVSzombies.control;

namespace plantsVSzombies
{
    public partial class frmLevelOne : Form
    {
        
        public frmLevelOne()
        {
            InitializeComponent();
            //防止进度条滚动时闪屏（挺管用）
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void frmLevelOne_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        PictureBox pic_Plants;//中间pictureBox
        private void pictureBox_Peashooter_Click(object sender, EventArgs e)
        {
            pic_Plants = new PictureBox();
            pic_Plants.BackColor = Color.Transparent;//背景透明
            pic_Plants.Image = Image.FromFile("../../images/Peashooter.gif");
            pic_Plants.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_Plants.Click += new EventHandler(pic_PlantsPeashooter_Click);
            this.Controls.Add(pic_Plants);
        }

        private void frmLevelOne_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic_Plants == null) { return; }
            pic_Plants.Location = e.Location;
        }

        #region pic_Plants各种点击事件
        private void pic_PlantsPeashooter_Click(object sender, EventArgs e)
        {
            Manager.buildPeashooter(pic_Plants.Location);
            this.Controls.Remove(pic_Plants);
        }
        #endregion

        private void timer_gameSpeed_Tick(object sender, EventArgs e)
        {
            Manager.updateAction();
            this.Invalidate();
        }

        private void frmLevelOne_Paint(object sender, PaintEventArgs e)
        {
            Manager.updateDisplay(e.Graphics);
        }

        private void frmLevelOne_Load(object sender, EventArgs e)
        {
            Manager.buildBackground_level1();
            timer_gameSpeed.Enabled = true;

        }
    }
}

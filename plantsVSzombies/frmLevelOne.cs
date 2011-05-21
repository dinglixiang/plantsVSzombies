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
            Manager.buildPeashooter(seletPlantsLocation(pic_Plants.Location), selectPlantsLand(pic_Plants.Location));
            this.Controls.Remove(pic_Plants);
        }
        #endregion

        int start = 0;//到一定时间开始产生僵尸
        int build = 0;//产生僵尸间隔时间

        private void timer_gameSpeed_Tick(object sender, EventArgs e)
        {
            
            if (start == 20)
            {
                if (build++ == 50)
                {
                    int num = selectZombiesLand();
                    Manager.buildNomelZombies(startLocation(num),num);
                    build = 0;
                }

                Manager.updateAction();//这样做是为了防止用start++的方式使start无限的加下去
                this.Invalidate();
                return;
            }

            Manager.updateAction();
            this.Invalidate();
            start++;
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

        private void frmLevelOne_SizeChanged(object sender, EventArgs e)
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


        //选择种植物的格子
        private Point seletPlantsLocation(Point location)
        {
            #region 第一个草坪
            if (location.Y <= 240)
            {

                if (location.X <= 291)
                {
                    return new Point(216, 120);
                }
                else if (location.X <= 346)
                {
                    return new Point(291, 120);
                }
                else if (location.X <= 420)
                {
                    return new Point(346, 120);
                }
                else if (location.X <= 478)
                {
                    return new Point(420, 120);
                }
                else if (location.X <= 538)
                {
                    return new Point(478, 120);
                }
                else if (location.X <= 617)
                {
                    return new Point(538, 120);
                }
                else if (location.X <= 676)
                {
                    return new Point(617, 120);
                }
                else if (location.X <= 748)
                {
                    return new Point(676, 120);
                }
                else
                {
                    return new Point(748, 120);
                }
            }
            #endregion
            #region 第二个草坪
            else if (location.Y <= 370)
            {

                if (location.X <= 291)
                {
                    return new Point(216, 250);
                }
                else if (location.X <= 346)
                {
                    return new Point(291, 250);
                }
                else if (location.X <= 420)
                {
                    return new Point(346, 250);
                }
                else if (location.X <= 478)
                {
                    return new Point(420, 250);
                }
                else if (location.X <= 538)
                {
                    return new Point(478, 250);
                }
                else if (location.X <= 617)
                {
                    return new Point(538, 250);
                }
                else if (location.X <= 676)
                {
                    return new Point(617, 250);
                }
                else if (location.X <= 748)
                {
                    return new Point(676, 250);
                }
                else
                {
                    return new Point(748, 250);
                }
            }
            #endregion
            #region 第三个草坪
            else if (location.Y <= 500)
            {

                if (location.X <= 291)
                {
                    return new Point(216, 380);
                }
                else if (location.X <= 346)
                {
                    return new Point(291, 380);
                }
                else if (location.X <= 420)
                {
                    return new Point(346, 380);
                }
                else if (location.X <= 478)
                {
                    return new Point(420, 380);
                }
                else if (location.X <= 538)
                {
                    return new Point(478, 380);
                }
                else if (location.X <= 617)
                {
                    return new Point(538, 380);
                }
                else if (location.X <= 676)
                {
                    return new Point(617, 380);
                }
                else if (location.X <= 748)
                {
                    return new Point(676, 380);
                }
                else
                {
                    return new Point(748, 380);
                }
            }
            #endregion
            #region 第四个草坪
            else
            {

                if (location.X <= 291)
                {
                    return new Point(216, 510);
                }
                else if (location.X <= 346)
                {
                    return new Point(291, 510);
                }
                else if (location.X <= 420)
                {
                    return new Point(346, 510);
                }
                else if (location.X <= 478)
                {
                    return new Point(420, 510);
                }
                else if (location.X <= 538)
                {
                    return new Point(478, 510);
                }
                else if (location.X <= 617)
                {
                    return new Point(538, 510);
                }
                else if (location.X <= 676)
                {
                    return new Point(617, 510);
                }
                else if (location.X <= 748)
                {
                    return new Point(676, 510);
                }
                else
                {
                    return new Point(748, 510);
                }
            }
            #endregion

        }

        //选择植物在那块草坪
        private int selectPlantsLand(Point location)
        {

            if (location.Y < 240){ return 1; }
            else if (location.Y < 370) { return 2; }
            else if (location.Y < 500) { return 3; }
            else { return 4; }
        }

        //选择产生僵尸的草坪
        private int selectZombiesLand()
        { 
            System.Random random = new Random();
            int n = 0;
            switch (random.Next(1, 5))
            {

                case 1: n = 1; break;
                case 2: n = 2; break;
                case 3: n = 3; break;
                default: n = 4; break;
            }

            return n;
        }

        //选择僵尸的位置
        private Point startLocation(int num)
        {
            Point location;
            switch (num)
            {

                case 1: location = new Point(950, 50); break;
                case 2: location = new Point(950, 180); break;
                case 3: location = new Point(950, 310); break;
                default: location = new Point(950, 440); break;
            }

            return location;
        }
    }
}

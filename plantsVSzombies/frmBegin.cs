using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace plantsVSzombies
{
    public partial class frmBegin : Form
    {
        #region 淡入淡出
        private Image image;
        private Image newBmp;
        private double _opacity = 0.0;
        private PictureEffect draw;
        private Graphics graphicsBmp;
        private Graphics graphicsPanel;





        private void GetImage()
        {
            //if (openFileDialog_Test.ShowDialog() == DialogResult.OK)
            //{
            //    image = new Bitmap(openFileDialog_Test.FileName);//image类型
            //    newBmp = new Bitmap(panel_draw.Width, panel_draw.Height);//image类型
            //    graphicsBmp = Graphics.FromImage(newBmp);//Graphics类型
            //    _opacity = 0.0;//double类型
            //    timer_test.Interval = 50;//时间计时器
            //    timer_test.Enabled = true;
            //}

            
            image = new Bitmap("../../images/login.jpg");//image类型
            newBmp = new Bitmap(panel_logo.Width, panel_logo.Height);//image类型
            graphicsBmp = Graphics.FromImage(newBmp);//Graphics类型
            _opacity = 0.0;//double类型
            timer_logo.Interval = 10;//事件发生的频率
            timer_logo.Enabled = true;

        }
        public static int i = 0;
        //淡入淡出效果
        private void fadeOutIn()
        {
            
            if (_opacity <= 1.0)
            {
                draw.ChangeTransparency(image, graphicsBmp, newBmp.Size, _opacity);
                graphicsPanel.DrawImage(newBmp, panel_logo.ClientRectangle, 0, 0, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel);
                _opacity = _opacity + 0.04;
            }
            else
            {
                draw.ChangeTransparency(image, graphicsBmp, newBmp.Size, 2 - _opacity);
                graphicsPanel.DrawImage(newBmp, panel_logo.ClientRectangle, 0, 0, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel);
                _opacity = _opacity + 0.05;
            }
            if (2 - _opacity < 0.0 + 0.05 && 2 - _opacity > 0.0 - 0.05)
            {
                
                panel_logo.Hide();
                timer_logo.Enabled = true;
                i++;
                timer1_grassCircle.Enabled = true;//picturebox开始移动
                timer2_grassCircle.Enabled = true;//草开始滚动
            }


        }

        public static int p = 0;
        private void timer_logo_Tick(object sender, EventArgs e)
        {
            fadeOutIn();        
             for (int j = 0; j < i; j++)
              { 
                     pictureBox1.Top += 11;
                     p++;
                     if (p == 10)
                         timer_logo.Enabled = false;
             }
           
        }

        private void frmBegin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (graphicsBmp != null)
            {
                graphicsBmp.Dispose();
            }
            if (graphicsPanel != null)
            {
                graphicsPanel.Dispose();
            }
        }

        #endregion

        
        
        public frmBegin()
        {
            InitializeComponent();
            Music.OpenBackMusic();
            draw = new PictureEffect();//淡入淡出
            graphicsPanel = panel_logo.CreateGraphics();//淡入淡出
            
            //防止进度条滚动时闪屏（挺管用）
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        #region 进度条
        Point point = new Point(228, 483);
        System.Drawing.Size pic_size = new System.Drawing.Size(64, 61);
        private void timer1_grassCircle_Tick(object sender, EventArgs e)
        {
            point.X += 10;
            //pic_size.Height = pic_size.Height - 1;
            //pic_size.Width -= 1;
            pictureBox2.Size = pic_size;
            pictureBox2.Location = point;
            if (point.X >= 500)
            {

                timer1_grassCircle.Enabled = false;
                timer2_grassCircle.Enabled = false;
            }
        }
        int n = 0;
        private void timer2_grassCircle_Tick(object sender, EventArgs e)
        {
            n++;
            switch (n)
            {

                case 1: pictureBox2.Image = Image.FromFile("../../images/grassCircle.png"); break;
                //pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                case 2: pictureBox2.Image = Image.FromFile("../../images/grassCircle.png");
                    pictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;

                case 3: pictureBox2.Image = Image.FromFile("../../images/grassCircle.png");
                    pictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                default: pictureBox2.Image = Image.FromFile("../../images/grassCircle.png");
                    pictureBox2.Image.RotateFlip(RotateFlipType.Rotate270FlipNone); n = 0; break;
            }
        }


        #endregion

        private void frmBegin_Load(object sender, EventArgs e)
        {
            Music.playBackMusic();
            GetImage();         
        }



        #region 点击开始
        private void linkBeginHover_MouseLeave(object sender, EventArgs e)
        {
            linkBeginHover.Image = null;
        }

        private void linkBeginHover_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOptions frmo = new frmOptions();
            frmo.Update();
            frmo.Show();
        }

        private void linkBeginHover_MouseEnter(object sender, EventArgs e)
        {
             linkBeginHover.Image = Image.FromFile("../../images/dianjikaishi.jpg");
        }

        #endregion

        private void frmBegin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}

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

            
            image = new Bitmap("../../images/slogo.png");//image类型
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
                _opacity = _opacity + 0.03;
            }
            else
            {
                draw.ChangeTransparency(image, graphicsBmp, newBmp.Size, 2 - _opacity);
                graphicsPanel.DrawImage(newBmp, panel_logo.ClientRectangle, 0, 0, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel);
                _opacity = _opacity + 0.04;
            }
            if (2 - _opacity < 0.0 + 0.03 && 2 - _opacity > 0.0 - 0.03)
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
        ProgressBar bar = new ProgressBar();
        Rectangle rec = new Rectangle(228,483,64,61);//将图片儿画在此矩形中
        Image image_grassCircle = Image.FromFile("../../images/grassCircle.png");
        bool flag = false;
        private void timer1_grassCircle_Tick(object sender, EventArgs e)
        {         
            bar.nextAction();       
            this.Invalidate();
        }
        
        
        private void timer2_grassCircle_Tick(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (bar.getX() > 500)
                {
                    linkBeginHover.Image = null;
                    flag = true;
                }
            }
            //rec.X += 10;
            //rec.Height -= 10;
            //rec.Width -= 10;
            ////pic_size.Height = pic_size.Height - 1;
            ////pic_size.Width -= 1;
            ////pictureBox2.Size = pic_size;
            ////pictureBox2.Location = point;
            //if (rec.X >= 500)
            //{

            //    timer1_grassCircle.Enabled = false;
            //    timer2_grassCircle.Enabled = false;
            //}
            //n++;
            //switch (n)
            //{

            //    case 1: this.CreateGraphics().DrawImage(image_grassCircle,rec); break;


            //    case 2: image_grassCircle.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //            this.CreateGraphics().DrawImage(image_grassCircle, rec); break;

            //    case 3: image_grassCircle.RotateFlip(RotateFlipType.Rotate180FlipNone);
            //        this.CreateGraphics().DrawImage(image_grassCircle, rec); break;
            //    default: image_grassCircle.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //        this.CreateGraphics().DrawImage(image_grassCircle, rec); n = 0; break;
            //}
        }


        #endregion

        private void frmBegin_Load(object sender, EventArgs e)
        {
            bar.showzairu(linkBeginHover);
            Music.playBackMusic();
            GetImage();         
        }



        #region 点击开始
        private void linkBeginHover_MouseLeave(object sender, EventArgs e)
        {
            if (!flag)
            {
                linkBeginHover.Image = Image.FromFile("../../images/zairuzhong.jpg");              
            }
            else {
                linkBeginHover.Image = null;
            }
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
            if (!flag)
            {
                linkBeginHover.Image = Image.FromFile("../../images/zairuzhong.jpg");
            }
            else {
                linkBeginHover.Image = Image.FromFile("../../images/dianjikaishi.jpg");
            }
        }

        #endregion

        private void frmBegin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmBegin_Paint(object sender, PaintEventArgs e)
        {
            bar.display(e.Graphics);
        }


    }
}

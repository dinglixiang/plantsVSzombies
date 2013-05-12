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
    public partial class frmOptions : Form
    {
        //#region 背景音乐
        //public static uint SND_ASYNC = 0x0001;
        //public static uint SND_FILENAME = 0x00020000;
        //[DllImport("winmm.dll")]
        //public static extern uint mciSendString(string lpstrCommand,
        //string lpstrReturnString, uint uReturnLength, uint hWndCallback);
        //public void OpenMusic()
        //{

        //    mciSendString(@"open ""../../music/1983组合 - 快乐猪八戒 - 搞笑歌曲.mp3"" alias temp_alias", null, 0, 0);
            
        //}
        //public void stopMusic() 
        //{
        //    mciSendString("stop temp_alias", null, 0, 0); //必须加temp_alias
        //}
        //public void playMusic()
        //{

        //    mciSendString("play temp_alias repeat", null, 0, 0);
        //}
        //public void closeMusic()
        //{
        //    mciSendString(@"close temp_alias", null, 0, 0);
        //}
        //#endregion

        public frmOptions()
        {
            InitializeComponent();
            
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

            
            timer1.Enabled = true;//图片下降开始
            //Music.openButtonMusic();
        }

        #region 各种label 事件
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_quit_MouseEnter(object sender, EventArgs e)
        {
            
            Music.stopBackMusic();//停止背景音乐
            label_quit.Image = Image.FromFile("../../images/quit.jpg");
            
        }

        private void label_quit_MouseLeave(object sender, EventArgs e)
        {
            
            Music.playBackMusic();//播放背景音乐
            label_quit.Image = null;
            
        }

        private void label_help_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            label_help.Image = Image.FromFile("../../images/help.jpg");
        }

        private void label_help_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            label_help.Image = null;
        }

        private void label_choice_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            label_choice.Image = Image.FromFile("../../images/choice.jpg");
        }

        private void label_choice_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            label_choice.Image = null;
        }

        private void label_risk_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            label_risk.Image = Image.FromFile("../../images/risk.jpg");

        }

        private void label_risk_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            label_risk.Image = null;
            
        }

        private void label_easegame_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            label_easygame.Image = Image.FromFile("../../images/easygame.jpg");
        }

        private void label_easegame_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            label_easygame.Image = null;
            
        }

        //绘制多变形label
        private void frmOptions_Paint(object sender, PaintEventArgs e)
        {

            //初始化一个GraphicsPath类的对象,label_risk
            System.Drawing.Drawing2D.GraphicsPath riskGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] riskpoint = { new Point(0, 0),new Point(0, 80),new Point(90, 100),new Point(150, 114),new Point(330, 114),new Point(330, 0)};
            riskGraphicsPath.AddPolygon(riskpoint);
            //将控件的Region属性设置为上面创建的GraphicsPath对象
            label_risk.Region = new Region(riskGraphicsPath);

            //label_easygame
            System.Drawing.Drawing2D.GraphicsPath easygameGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] point ={new Point(0, 0),new Point(0, 80),new Point(303, 129),new Point(303, 40)};
            easygameGraphicsPath.AddPolygon(point);
            //将控件的Region属性设置为上面创建的GraphicsPath对象
            label_easygame.Region = new Region(easygameGraphicsPath);
        }

        private void label_shop_MouseEnter(object sender, EventArgs e)
        {
            label_shop.Image = Image.FromFile("../../images/shop.jpg");
        }

        private void label_shop_MouseLeave(object sender, EventArgs e)
        {
            label_shop.Image = null;
        }

        private void label_page_MouseEnter(object sender, EventArgs e)
        {
            label_page.Image = Image.FromFile("../../images/page_over.jpg");
        }

        private void label_page_MouseLeave(object sender, EventArgs e)
        {
            label_page.Image = null;
        }

        #endregion

        Point pic1_point = new Point(0, -180);
        Point pic2_point = new Point(0, -50);

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic1_point.Y += 45;
            pic2_point.Y += 45;
            pictureBox_pic1.Location = pic1_point;//new Point(0,-180+n)
            pictureBox_pic2.Location = pic2_point;//new Point(0, -50 + n)
            if (pic1_point.Y >= 0)
            {

                timer1.Enabled = false;
                timer2.Enabled = true;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pic1_point.Y -= 2;
            pic2_point.Y = pic2_point.Y + 2;
            pictureBox_pic1.Location = pic1_point;
            pictureBox_pic2.Location = pic2_point;
            if (pic1_point.Y - 2 <= -5)
            {
                pic1_point.Y = 0;
                pic2_point.Y -= 5;
                pictureBox_pic1.Location = pic1_point;
                pictureBox_pic2.Location = pic2_point;
                timer3.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pic2_point.Y += 15;
            pictureBox_pic2.Location = pic2_point;
            timer3.Enabled = false;
        }

        private void pictureBox_pic2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_pic2.Image = Image.FromFile("../../images/SelectorScreen_WoodSign2_press.png");
        }

        private void pictureBox_pic2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_pic2.Image = Image.FromFile("../../images/SelectorScreen_WoodSign2.png");
        }
    }
}

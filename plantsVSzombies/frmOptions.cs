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
        public static Label label_username = null;//定义一个label_username用以显示当前用户

        public frmOptions()
        {
            InitializeComponent();
            //防止进度条滚动时闪屏（挺管用）
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void frmOptions_Load(object sender, EventArgs e)
        { 
            timer1.Enabled = true;//图片下降开始
            Music.playBackMusic();//播放背景音乐
        }

        #region 各种label 事件
        private void label1_Click(object sender, EventArgs e)
        {
            QuitGame quit = new QuitGame();
            quit.Show();
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
            Music.playButtonMusic();
            label_shop.Image = Image.FromFile("../../images/shop.jpg");
        }

        private void label_shop_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            label_shop.Image = null;
        }

        private void label_page_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            label_page.Image = Image.FromFile("../../images/page_over.jpg");
        }

        private void label_page_MouseLeave(object sender, EventArgs e)
        {
            Music.stopButtonMusic();
            label_page.Image = null;
        }

        #endregion
        #region 档案掉落
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
            //动态生成一个label_username用以显示当前用户
            label_username = new Label();
            label_username.Location = new Point(65, 98);
            label_username.Size = new System.Drawing.Size(180, 15);
            label_username.Text = "";
            label_username.BackColor = Color.FromArgb(82, 70, 50);//通过指定数值指定颜色
            label_username.Font = new Font("宋体", 12F, FontStyle.Bold);//设置字体
            label_username.ForeColor = Color.White;
            label_username.TextAlign = ContentAlignment.MiddleCenter;
            this.pictureBox_pic1.Controls.Add(label_username);//将label添加到picturebox中*********
        }

        private void pictureBox_pic2_MouseEnter(object sender, EventArgs e)
        {
            Music.playButtonMusic();
            pictureBox_pic2.Image = Image.FromFile("../../images/SelectorScreen_WoodSign2_press.png");
        }

        private void pictureBox_pic2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_pic2.Image = Image.FromFile("../../images/SelectorScreen_WoodSign2.png");
        }
        #endregion
        private void label_risk_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectLevel selectlevel = new frmSelectLevel();
            selectlevel.Show();
        }

        private void pictureBox_pic2_Click(object sender, EventArgs e)
        {
            UserProfiles up = new UserProfiles();
            up.ShowDialog();//将此窗体设为对话框模式，这样显示此窗体时候就不能操作其他窗体
            
        }

        private void frmOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label_easygame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("偶就是不解锁~~~");
        }

        private void label_choice_Click(object sender, EventArgs e)
        {

        }

        private void label_help_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp help = new frmHelp();
            help.Show();
        }

        private void frmOptions_SizeChanged(object sender, EventArgs e)
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

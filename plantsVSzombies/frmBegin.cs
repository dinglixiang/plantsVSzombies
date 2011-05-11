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

        //淡入淡出效果
        private void fadeOutIn()
        {
            if (_opacity <= 1.0)
            {
                draw.ChangeTransparency(image, graphicsBmp, newBmp.Size, _opacity);
                graphicsPanel.DrawImage(newBmp, panel_logo.ClientRectangle, 0, 0, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel);
                _opacity = _opacity + 0.01;
            }
            else
            {
                draw.ChangeTransparency(image, graphicsBmp, newBmp.Size, 2 - _opacity);
                graphicsPanel.DrawImage(newBmp, panel_logo.ClientRectangle, 0, 0, newBmp.Width, newBmp.Height, GraphicsUnit.Pixel);
                _opacity = _opacity + 0.01;
            }
            if (2 - _opacity < 0.0 + 0.01 && 2 - _opacity > 0.0 - 0.01)
            {
                timer_logo.Enabled = false;
                panel_logo.Hide();
            }


        }

        private void timer_logo_Tick(object sender, EventArgs e)
        {
            fadeOutIn();

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

        #region 背景音乐
        public static uint SND_ASYNC = 0x0001;
        public static uint SND_FILENAME = 0x00020000;
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand,
        string lpstrReturnString, uint uReturnLength, uint hWndCallback);
        public void OpenMusic()
        {

            mciSendString(@"open ""../../music/儿童歌曲-葫芦娃.mp3"" alias temp_alias", null, 0, 0);
            
        }
        public static void stopMusic() 
        {
            mciSendString("stop temp_alias", null, 0, 0); //必须加temp_alias
        }
        public static void playMusic()
        {

            mciSendString("play temp_alias repeat", null, 0, 0);
        }
        public void closeMusic()
        {
            mciSendString(@"close temp_alias", null, 0, 0);
        }
        #endregion
        
        public frmBegin()
        {
            InitializeComponent();
            draw = new PictureEffect();//淡入淡出
            graphicsPanel = panel_logo.CreateGraphics();//淡入淡出
            OpenMusic();
        }



        private void frmBegin_Load(object sender, EventArgs e)
        {
            GetImage();
            playMusic();
            
        }




        private void linkBeginHover_MouseLeave(object sender, EventArgs e)
        {
            linkBeginHover.Image = null;
        }

        private void linkBeginHover_Click(object sender, EventArgs e)
        {
            frmOptions frmo = new frmOptions();
            frmo.Show();
            
        }

        private void linkBeginHover_MouseEnter(object sender, EventArgs e)
        {
             linkBeginHover.Image = Image.FromFile("../../images/dianjikaishi.jpg");
        }




    }
}

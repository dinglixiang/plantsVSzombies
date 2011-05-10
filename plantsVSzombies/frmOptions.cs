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
        public void stopMusic() 
        {
            mciSendString("stop temp_alias", null, 0, 0); //必须加temp_alias
        }
        public void playMusic()
        {

            mciSendString("play temp_alias repeat", null, 0, 0);
        }
        public void closeMusic()
        {
            mciSendString(@"close temp_alias", null, 0, 0);
        }
        #endregion
        public frmOptions()
        {
            InitializeComponent();
            OpenMusic(); //打开音乐文件
            
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

            playMusic();//播放音乐
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_quit_MouseEnter(object sender, EventArgs e)
        {
            this.stopMusic();//停止音乐
            label_quit.Image = Image.FromFile("../../images/SelectorScreen_Quit2.png");
        }

        private void label_quit_MouseLeave(object sender, EventArgs e)
        {
            this.playMusic();//播放音乐
            label_quit.Image = Image.FromFile("../../images/SelectorScreen_Quit1.png");
        }


    }
}

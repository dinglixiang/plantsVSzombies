using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace plantsVSzombies
{
    public class Music
    {
        public static uint SND_ASYNC = 0x0001;
        public static uint SND_FILENAME = 0x00020000;
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand,
        string lpstrReturnString, uint uReturnLength, uint hWndCallback);

        public void OpenMusic(String position)
        {

            mciSendString(@"open ""../../images/儿童歌曲-葫芦娃.mp3"" alias temp_alias", null, 0, 0);

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
    }
}

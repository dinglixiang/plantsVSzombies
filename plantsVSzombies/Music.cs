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
        #region 背景音乐
        public static void OpenBackMusic()
        {

            mciSendString(@"open ""../../music/bmusic.mp3"" alias temp_alias", null, 0, 0);

        }
        public static void stopBackMusic()
        {
            mciSendString("stop temp_alias", null, 0, 0); //必须加temp_alias
        }
        public static void playBackMusic()
        {

            mciSendString("play temp_alias repeat", null, 0, 0);
        }
        public static void closeBackMusic()
        {
            mciSendString(@"close temp_alias", null, 0, 0);
        }
        #endregion
        #region button音效
        public static void openButtonMusic()
        {
            mciSendString(@"open ""../../music/puff.mp3", null, 0, 0);
        }
        public static void playButtonMusic() 
        {

            //mciSendString("play  ../../music/button_up.mp3 ", null, 0, 0);
            mciSendString("play ../../music/puff.mp3", null, 0, 0);
        }

        public static void stopButtonMusic() 
        {
            mciSendString("stop ../../music/puff.mp3", null, 0, 0);
        }
        #endregion
    }
}

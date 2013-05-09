using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace plantsVSzombies
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmBegin begin = new frmBegin();
            //begin.Show();
            Application.Run(new frmBegin());
           
        }
    }
}

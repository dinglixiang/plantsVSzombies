using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace plantsVSzombies.model.levebackground
{
    interface BackGround
    {
        void nextAction();
        void display(Graphics g);
    }
}

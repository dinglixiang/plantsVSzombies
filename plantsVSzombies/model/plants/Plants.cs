using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace plantsVSzombies.model.plants
{
    interface Plants
    {

         void nextAction();
         void display(Graphics g);
        //应该再加一个子弹属性
    }
}


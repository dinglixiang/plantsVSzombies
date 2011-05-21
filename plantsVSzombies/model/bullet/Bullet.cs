using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace plantsVSzombies.model.bullet
{
    interface Bullet
    {
        void nextAction();
        void display(Graphics g);
        Point getLocation();
        int getDamage();
        int getLandNum();
    }
}

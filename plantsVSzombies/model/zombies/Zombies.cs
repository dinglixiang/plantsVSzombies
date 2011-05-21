using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace plantsVSzombies.model.zombies
{
    interface Zombies
    {
        void nextAction();
        void display(Graphics g);
        Point getLocation();
        int getLife();
        void cutLife(int num);
        int getLandNum();
    }
}

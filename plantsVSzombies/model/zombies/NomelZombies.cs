using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace plantsVSzombies.model.zombies
{
    class NomelZombies : Zombies
    {
        private Point location;
        Image image;
        Random ran = new Random();
        int life = 100;
        int count = 0;
        int index = 0;
        private int landNum = 0;//第几块草坪
        public NomelZombies(Point location ,int landNum)
        {
            image = Image.FromFile("../../images/Zombie.gif");
            count = image.GetFrameCount(FrameDimension.Time);
            this.location = location;
            this.landNum = landNum;
        }


        public int getLandNum()
        {

            return landNum;
        }
        public Point getLocation()
        {

            return location;
        }

        public int getLife()
        {

            return life;
        }

        public void cutLife(int num)
        {

            this.life -= num;
        }
        public void nextAction()
        {

            this.location.X -= 2;
            index++;
            if (index == count) { index = 0; }
            image.SelectActiveFrame(FrameDimension.Time, index);
        }

        public void display(Graphics g)
        {

            g.DrawImage(image, location);
        }
    }
}

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
        bool eat = false;
        public int damage = 10;
        public NomelZombies(Point location ,int landNum)
        {
            image = Image.FromFile("../../images/Zombie.gif");
            count = image.GetFrameCount(FrameDimension.Time);
            this.location = location;
            this.landNum = landNum;
        }

        public int getDamage()
        {

            return damage;
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

        public void beginEat()
        {
            if (eat) { return; }
            eat = true;
            image = Image.FromFile("../../images/ZombieAttack.gif");
            count = image.GetFrameCount(FrameDimension.Time);
            index = 0;
        }

        public void stopEat()
        {

            eat = false;
            image = Image.FromFile("../../images/Zombie.gif");
            index = 0;
        }
        public void nextAction()
        {

            if (eat) 
            {

                index++;
                if (index == count) { index = 0; }
                image.SelectActiveFrame(FrameDimension.Time, index);
                return;
            }
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

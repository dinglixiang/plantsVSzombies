using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace plantsVSzombies.model.bullet
{
    class Bullet_Peashooter : Bullet
    {
        private Image image;
        private Point location;
        int damage = 10;
        int landNum = 0;
        public Bullet_Peashooter(Point location,int landNum)
        {
            location.X += 50;
            image = Image.FromFile("../../images/peashooterBullet.png");
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

        public int getDamage()
        {

            return damage;
        }
        public void nextAction()
        {

            location.X += 10;
        }

        public void display(Graphics g)
        {

            g.DrawImage(image, location);
        }
    }
}

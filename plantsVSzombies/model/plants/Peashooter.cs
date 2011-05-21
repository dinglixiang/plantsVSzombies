using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using plantsVSzombies.model.bullet;

namespace plantsVSzombies.model.plants
{
    class Peashooter : Plants
    {
        private Image image;
        private Point location;
        private double liftnum;
        private int count;//gif总帧数
        private int index;//具体帧数
        private int landNum = 0;//记录所在哪块草坪
        public Peashooter(Point location ,int landNum)
        {
            this.location = location;
            liftnum = 100.0;
            image = Image.FromFile("../../images/Peashooter.gif");
            count = image.GetFrameCount(FrameDimension.Time);//获得图片时间维度上的总帧数
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

        public void nextAction()
        {

            index++;
            if (index == count) { index = 0; Map.bulletList.Add(new Bullet_Peashooter(location,landNum)); }
            image.SelectActiveFrame(FrameDimension.Time, index);

        }

        public void display(Graphics g)
        {

            g.DrawImage(image, location);
        }
    }
}

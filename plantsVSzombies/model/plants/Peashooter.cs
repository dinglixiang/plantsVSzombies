using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace plantsVSzombies.model.plants
{
    class Peashooter : Plants
    {
        private Image image;
        private Point location;
        private double liftnum;
        private int count;//gif总帧数
        private int index;//具体帧数
        public Peashooter(Point location)
        {
            this.location = location;
            liftnum = 100.0;
            image = Image.FromFile("../../images/Peashooter.gif");
            count = image.GetFrameCount(FrameDimension.Time);//获得图片时间维度上的总帧数

        }

        public void nextAction()
        {

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

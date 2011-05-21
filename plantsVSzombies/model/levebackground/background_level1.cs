using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace plantsVSzombies.model.levebackground
{
    class background_level1 : BackGround
    {
        private Grassland grassland;
        private Point location;
        private Image image;
        private Rectangle rectangle;//设置一个窗体大小的矩形，让其在此矩形中绘制背景图，不然背景图太大
        bool end = false;//图片到右边缘的标志
        bool start = false;//图片回到左边缘的标志
        int n = 0;
        public background_level1()
        {
            grassland = new Grassland();
            location = new Point(0,0);
            image = Image.FromFile("../../images/background_level1.jpg");
            rectangle = new Rectangle(location,new Size(1170,680));
        }
        public void nextAction()
        {
            if (start) { grassland.nextAction(); return; }//如果回到左边缘，停止
            if (location.X <= -200) { end = true; if (n++ < 10) { return; } }//如果达到右边缘则将end改为true并且停止10个周期
            if (end) { this.location.X += 10; if (this.location.X == 0) { start = true; } return; }//10个周期后，开始向左移动，移动之后return，不让其执行后一条语句，达到左边缘后start改为true
            this.location.X -= 20;
        }

        public void display(Graphics g)
        {
            rectangle.Location = this.location;
            g.DrawImage(image, rectangle);
            
            if (start)
            {

                grassland.display(g);
            }
        }
    }
}

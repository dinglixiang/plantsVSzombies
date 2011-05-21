using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace plantsVSzombies.model.levebackground
{
    class Grassland
    {
        private Point grass1StartLocation;
        private Point grass2StartLocation;
        private Point grass3StartLocation;
        private Point grass4StartLocation;
        private Point Roll1Location;
        private Point RollCop1Location;
        private Point Roll2Location;
        private Point RollCop2Location;
        private Point Roll3Location;
        private Point RollCop3Location;
        private Point Roll4Location;
        private Point RollCop4Location;
        private Image imageGrassLand1;
        private Image imageGrassLand2;
        private Image imageGrassLand3;
        private Image imageGround;
        private Image imageRoll;
        private Rectangle r1;
        private Rectangle r2;
        private Rectangle r3;
        private Rectangle r4;
        public bool flag = false;//草坪铺设完毕的标记 

        public Grassland()
        {

            grass1StartLocation = new Point(210, 105);
            grass2StartLocation = new Point(210, 235);
            grass3StartLocation = new Point(210, 365);
            grass4StartLocation = new Point(210, 495);
            Roll1Location = new Point(190, 105);
            RollCop1Location = new Point(190, 200);
            Roll2Location = new Point(190, 230);
            RollCop2Location = new Point(190, 330);
            Roll3Location = new Point(190, 360);
            RollCop3Location = new Point(190, 460);
            Roll4Location = new Point(190, 490);
            RollCop4Location = new Point(190, 595);
            imageGrassLand1 = Image.FromFile("../../images/sod1row.png");
            imageGrassLand2 = Image.FromFile("../../images/sod1row2.png");
            imageGrassLand3 = Image.FromFile("../../images/sod1row3.png");
            imageGround = Image.FromFile("../../images/SodRoll.png");
            imageRoll = Image.FromFile("../../images/SodRollCap.png");
            r1 = new Rectangle();
            r1.Height = imageGrassLand1.Height;
            r1.Location = grass1StartLocation;
            r2 = new Rectangle();
            r2.Height = imageGrassLand2.Height;
            r2.Location = grass2StartLocation;
            r3 = new Rectangle();
            r3.Height = imageGrassLand3.Height;
            r3.Location = grass3StartLocation;
            r4 = new Rectangle();
            r4.Height = imageGrassLand3.Height;
            r4.Location = grass4StartLocation;
        }

        int length = 0;
        public bool nextAction()
        {
            if (length >= 620) { return true; }
            Roll1Location.X += 20;
            Roll2Location.X += 20;
            Roll3Location.X += 20;
            Roll4Location.X += 20;
            RollCop1Location.X += 20;
            RollCop2Location.X += 20;
            RollCop3Location.X += 20;
            RollCop4Location.X += 20;
            length += 20;

            r1.Width = length;
            r2.Width = length;
            r3.Width = length;
            r4.Width = length;
            return false;
        }

        public void display(Graphics g)
        {

            g.DrawImageUnscaledAndClipped(imageGrassLand1, r1);
            g.DrawImageUnscaledAndClipped(imageGrassLand2, r2);
            g.DrawImageUnscaledAndClipped(imageGrassLand3, r3);
            g.DrawImageUnscaledAndClipped(imageGrassLand3, r4);
            if (length < 620)
            {
                g.DrawImage(imageGround, Roll1Location);
                g.DrawImage(imageRoll, RollCop1Location);
                g.DrawImage(imageGround, Roll2Location);
                g.DrawImage(imageRoll, RollCop2Location);
                g.DrawImage(imageGround, Roll3Location);
                g.DrawImage(imageRoll, RollCop3Location);
                g.DrawImage(imageGround, Roll4Location);
                g.DrawImage(imageRoll, RollCop4Location);
            }
        }
    }
}

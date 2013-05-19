using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using plantsVSzombies.model;
using System.Drawing;
using plantsVSzombies.model.plants;
using plantsVSzombies.model.levebackground;

namespace plantsVSzombies.control
{
    class Manager
    {
        public static void buildBackground_level1()
        {

            background_level1 bg1 = new background_level1();
            Map.background.Add(bg1);
        }
        public static void buildPeashooter(Point location)
        {

            Peashooter ph = new Peashooter(location);
            Map.plantList.Add(ph);
        }
        public static void buildSunFlower(Point location)
        { }

        public static void updateAction()
        {
            //改变当前背景图片位置
            Map.background[0].nextAction();
            //改变所有植物的当前帧
            foreach (Plants ph in Map.plantList)
            {

                ph.nextAction();
            }
        }

        public static void updateDisplay(Graphics g)
        {
            Map.background[0].display(g);

            foreach (Plants ph in Map.plantList)
            {

                ph.display(g);
            }
        }
    }
}

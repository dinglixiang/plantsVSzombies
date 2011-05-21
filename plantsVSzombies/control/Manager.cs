using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using plantsVSzombies.model;
using System.Drawing;
using plantsVSzombies.model.plants;
using plantsVSzombies.model.levebackground;
using plantsVSzombies.model.bullet;
using plantsVSzombies.model.zombies;

namespace plantsVSzombies.control
{
    class Manager
    {
       
        public static void buildBackground_level1()
        {

            background_level1 bg1 = new background_level1();
            Map.background.Add(bg1);
        }
        public static void buildPeashooter(Point location ,int landNum)
        {

            Peashooter ph = new Peashooter(location, landNum);

            Map.plantList.Add(ph);

        }

        public static void buildSunFlower(Point location, int landNum)
        { }

        //产生僵尸
        public static void buildNomelZombies(Point location ,int landNum)
        {

            NomelZombies nomelzombies = new NomelZombies(location, landNum);
            Map.zombiesList.Add(nomelzombies);
        }
        //子弹打僵尸
        public static void attackZombies(Graphics g)
        {
            Bullet bullet;
            Zombies zombies;
            for (int i = 0; i < Map.bulletList.Count; i++)
            {
                bullet = Map.bulletList[i];
                for (int n = 0; n < Map.zombiesList.Count; n++)
                {
                    zombies = Map.zombiesList[n];
                    if (bullet.getLandNum()== zombies.getLandNum() && zombies.getLocation().X - bullet.getLocation().X <= -40)
                    {

                        Map.bulletList.Remove(bullet);
                        g.DrawImage(Image.FromFile("../../images/SodRollCap.png"), bullet.getLocation());
                        if (zombies.getLife() < 0)
                        {

                            Map.zombiesList.Remove(zombies);
                            continue;
                        }
                        zombies.cutLife(bullet.getDamage());
                    }
                }
            }
        }

        public static void updateAction()
        {
            #region foreach 需注意
            //foreach (Bullet bullet in Map.bulletList)
            //{
            //    //if (bullet.getLocation().X > 800) { Map.bulletList.Remove(bullet); continue; }//不能在foreach里遍历的时侯把它的元素进行删除或增加的操作的,所以这句会报错，可以改为for循环遍历
            //    bullet.nextAction();
            //}
            #endregion
            //改变当前背景图片位置
            Map.background[0].nextAction();

            //改变所有植物的当前帧
            foreach (Plants ph in Map.plantList)
            {

                ph.nextAction();
            }

            //改变子弹当前帧
            for (int i = 0; i < Map.bulletList.Count; i++)
            {

                if (Map.bulletList[i].getLocation().X > 800) { Map.bulletList.Remove(Map.bulletList[i]); continue; }
                Map.bulletList[i].nextAction();
            }
            //改变僵尸位置和当前帧
            for (int i = 0; i < Map.zombiesList.Count; i++)
            {

                if (Map.zombiesList[i].getLocation().X < 100) { Map.zombiesList.Remove(Map.zombiesList[i]); continue; }
                Map.zombiesList[i].nextAction();
            }
            //attackZombies(g);
        }

        public static void updateDisplay(Graphics g)
        {
            Map.background[0].display(g);

            foreach (Plants ph in Map.plantList)
            {

                ph.display(g);
            }

            foreach (Bullet bullet in Map.bulletList)
            {

                bullet.display(g);
            }

            foreach (Zombies zombies in Map.zombiesList)
            {

                zombies.display(g);
            }

            attackZombies(g);
        }
    }
}

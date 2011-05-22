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
                Point bLocation = bullet.getLocation();
                for (int n = 0; n < Map.zombiesList.Count; n++)
                {
                    zombies = Map.zombiesList[n];
                    Point zLocation = zombies.getLocation();
                    if (bullet.getLandNum() == zombies.getLandNum() && (zLocation.X - bLocation.X <= -75 && zLocation.X - bLocation.X>=-120))
                    {

                        Map.bulletList.Remove(bullet);
                        Point point = bullet.getLocation();
                        bLocation.X -= 30;
                        g.DrawImage(Image.FromFile("../../images/PeaBulletHit.gif"), bLocation);
                        if (zombies.getLife() < 0)
                        {

                            Map.zombiesList.Remove(zombies);
                            break;//一个子弹只能打一个僵尸，如果僵尸别打死，推出针对子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                        }
                        
                        zombies.cutLife(bullet.getDamage());
                        break;//一个子弹只能打一个僵尸，找到后推出针对此子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                    }
                }
            }
        }

        //僵尸吃植物
        public static void attackBullet()
        {

            for (int i = 0; i < Map.plantList.Count; i++)
            {
                Plants plant = Map.plantList[i];
                Point pLocation = plant.getLocation();
                int pLand = plant.getLandNum();
                for (int n = 0; n < Map.zombiesList.Count; n++)
                {
                    Zombies zombies = Map.zombiesList[n];
                    Point zLocation = zombies.getLocation();
                    int zLand = zombies.getLandNum();
                    if (pLand == zLand && zLocation.X - pLocation.X <= -5)
                    {

                        zombies.beginEat();
                        if (plant.getLife() <= 0)
                        {

                            Map.plantList.Remove(plant);
                            zombies.stopEat();//植物死后停止僵尸吃
                            break;//一个僵尸一次只能吃一个植物，如果此植物别吃完后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                        }
                        plant.cutLife(zombies.getDamage());
                        break; ;//一个僵尸一次只能吃一个植物，找到吃这个植物的僵尸后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
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
            attackBullet();
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

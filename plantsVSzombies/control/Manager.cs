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
            switch (landNum)
            {

                case 1: Map.plantLand1.addPlant(ph); break;
                case 2: Map.plantLand2.addPlant(ph); break;
                case 3: Map.plantLand3.addPlant(ph); break;
                case 4: Map.plantLand4.addPlant(ph); break;
                case 5: Map.plantLand5.addPlant(ph); break;
            }

            Map.plantList.Add(ph);

        }

        public static void buildSunFlower(Point location, int landNum)
        { }

        //产生僵尸
        public static void buildNomelZombies(Point location ,int landNum)
        {

            NomelZombies nomelzombies = new NomelZombies(location, landNum);
            switch (landNum)
            {

                case 1: Map.zombiesLand1.addZombies(nomelzombies); break;
                case 2: Map.zombiesLand2.addZombies(nomelzombies); break;
                case 3: Map.zombiesLand3.addZombies(nomelzombies); break;
                case 4: Map.zombiesLand4.addZombies(nomelzombies); break;
                case 5: Map.zombiesLand5.addZombies(nomelzombies); break;
            }
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
                switch (bullet.getLandNum())
                {
                    #region  如果子弹在第一个草坪
                    case 1:    for (int n = 0; n < Map.zombiesLand1.getList().Count; n++)
                               {
                                   zombies = Map.zombiesLand1.getOneZombie(n);
                                   Point zLocation = zombies.getLocation();
                                   if (zLocation.X - bLocation.X <= -75 && zLocation.X - bLocation.X>-150)
                                  {

                                     Map.bulletList.Remove(bullet);
                                     Point point = bullet.getLocation();
                                     bLocation.X -= 30;
                                     g.DrawImage(Image.FromFile("../../images/PeaBulletHit.gif"), bLocation);
                                     if (zombies.getLife() < 0)
                                      {

                                         Map.zombiesList.Remove(zombies);
                                         Map.zombiesLand1.remove(zombies);
                                         break;//一个子弹只能打一个僵尸，如果僵尸被打死，推出针对子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                                      }

                                      zombies.cutLife(bullet.getDamage());
                                      break;//一个子弹只能打一个僵尸，找到后推出针对此子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                                   }
                                }break;
                    #endregion
                    #region  如果子弹在第二个草坪
                    case 2: for (int n = 0; n < Map.zombiesLand2.getList().Count; n++)
                        {
                            zombies = Map.zombiesLand2.getOneZombie(n);
                            Point zLocation = zombies.getLocation();
                            if (zLocation.X - bLocation.X <= -75 && zLocation.X - bLocation.X>-150)
                            {

                                Map.bulletList.Remove(bullet);
                                Point point = bullet.getLocation();
                                bLocation.X -= 30;
                                g.DrawImage(Image.FromFile("../../images/PeaBulletHit.gif"), bLocation);
                                if (zombies.getLife() < 0)
                                {

                                    Map.zombiesList.Remove(zombies);
                                    Map.zombiesLand2.remove(zombies);
                                    break;//一个子弹只能打一个僵尸，如果僵尸被打死，推出针对子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                                }

                                zombies.cutLife(bullet.getDamage());
                                break;//一个子弹只能打一个僵尸，找到后推出针对此子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                            }
                        } break;
                    #endregion
                    #region  如果子弹在第三个草坪
                    case 3: for (int n = 0; n < Map.zombiesLand3.getList().Count; n++)
                        {
                            zombies = Map.zombiesLand3.getOneZombie(n);
                            Point zLocation = zombies.getLocation();
                            if (zLocation.X - bLocation.X <= -75 && zLocation.X - bLocation.X > -150)
                            {

                                Map.bulletList.Remove(bullet);
                                Point point = bullet.getLocation();
                                bLocation.X -= 30;
                                g.DrawImage(Image.FromFile("../../images/PeaBulletHit.gif"), bLocation);
                                if (zombies.getLife() < 0)
                                {

                                    Map.zombiesList.Remove(zombies);
                                    Map.zombiesLand3.remove(zombies);
                                    break;//一个子弹只能打一个僵尸，如果僵尸被打死，推出针对子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                                }

                                zombies.cutLife(bullet.getDamage());
                                break;//一个子弹只能打一个僵尸，找到后推出针对此子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                            }
                        } break;
                    #endregion
                    #region  如果子弹在第四个草坪
                    case 4: for (int n = 0; n < Map.zombiesLand4.getList().Count; n++)
                        {
                            zombies = Map.zombiesLand4.getOneZombie(n);
                            Point zLocation = zombies.getLocation();
                            if (zLocation.X - bLocation.X <= -75 && zLocation.X - bLocation.X > -150)
                            {

                                Map.bulletList.Remove(bullet);
                                Point point = bullet.getLocation();
                                bLocation.X -= 30;
                                g.DrawImage(Image.FromFile("../../images/PeaBulletHit.gif"), bLocation);
                                if (zombies.getLife() < 0)
                                {

                                    Map.zombiesList.Remove(zombies);
                                    Map.zombiesLand4.remove(zombies);
                                    break;//一个子弹只能打一个僵尸，如果僵尸被打死，推出针对子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                                }

                                zombies.cutLife(bullet.getDamage());
                                break;//一个子弹只能打一个僵尸，找到后推出针对此子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                            }
                        } break;
                    #endregion
                    #region  如果子弹在第五个草坪
                    case 5: for (int n = 0; n < Map.zombiesLand5.getList().Count; n++)
                        {
                            zombies = Map.zombiesLand5.getOneZombie(n);
                            Point zLocation = zombies.getLocation();
                            if (zLocation.X - bLocation.X <= -75 && zLocation.X - bLocation.X > -150)
                            {

                                Map.bulletList.Remove(bullet);
                                Point point = bullet.getLocation();
                                bLocation.X -= 30;
                                g.DrawImage(Image.FromFile("../../images/PeaBulletHit.gif"), bLocation);
                                if (zombies.getLife() < 0)
                                {

                                    Map.zombiesList.Remove(zombies);
                                    Map.zombiesLand5.remove(zombies);
                                    break;//一个子弹只能打一个僵尸，如果僵尸被打死，推出针对子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                                }

                                zombies.cutLife(bullet.getDamage());
                                break;//一个子弹只能打一个僵尸，找到后推出针对此子弹搜索僵尸的内循环，开始针对另一个子弹搜索僵尸
                            }
                        } break;
                    #endregion
                }
            }
        }
        //僵尸吃植物
        public static void attackPlants()
        {
            Plants plant;
            Zombies zombies;
            Point zLocation;
            Point pLocation;
            //用僵尸做外循环寻找植物是因为如果用植物做外循环的话会出现一个僵尸吃植物时，其它僵尸不再吃
            for (int i = 0; i < Map.zombiesList.Count; i++)
            {
                zombies = Map.zombiesList[i];
                zLocation = zombies.getLocation();

                switch (zombies.getLandNum())
                {
                    #region 如果僵尸在第一个草坪
                    case 1: for (int n = 0; n < Map.plantLand1.getList().Count; n++)
                            {
                                plant = Map.plantLand1.getOnePlant(n);
                                pLocation = plant.getLocation();
                                if (zLocation.X - pLocation.X <= -5 && zLocation.X - pLocation.X > -120)
                                {

                                    zombies.beginEat();
                                    if (plant.getLife() <= 0)//这种情况当多个僵尸同时吃一个植物时，要最后一口的僵尸会停下而其它的会因为刚被吃的plant已经不存在而不停地吃
                                    {

                                        Map.plantList.Remove(plant);
                                        Map.plantLand1.remove(plant);
                                        foreach (Zombies zombie in Map.zombiesLand1.getList()) { zombie.stopEat(); }//一颗植物死后停止这一草坪上所有僵尸吃，防止出现不停吃的植物的情况（也可以在植物类中加一个方法包含一个list，将吃这个植物的所有僵尸加到list中，当植物死时调用循环将吃这个植物的僵尸停止（不过一个草坪上的僵尸不会太多，所以就省事的选用全部停止的方法））
                                        
                                        break;//一个僵尸一次只能吃一个植物，如果此植物别吃完后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                    }
                                    plant.cutLife(zombies.getDamage());
                                    break;//一个僵尸一次只能吃一个植物，找到吃这个植物的僵尸后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                }
                            }break;
                    #endregion
                    #region 如果植物在第二个草坪
                        case 2: for (int n = 0; n < Map.plantLand2.getList().Count; n++)
                        {
                            plant = Map.plantLand2.getOnePlant(n);
                            pLocation = plant.getLocation();
                            if (zLocation.X - pLocation.X <= -5 && zLocation.X - pLocation.X > -120)
                            {

                                zombies.beginEat();
                                if (plant.getLife() <= 0)//这种情况当多个僵尸同时吃一个植物时，要最后一口的僵尸会停下而其它的会因为刚被吃的plant已经不存在而不停地吃
                                {

                                    Map.plantList.Remove(plant);
                                    Map.plantLand2.remove(plant);
                                    foreach (Zombies zombie in Map.zombiesLand2.getList()) { zombie.stopEat(); }//一颗植物死后停止这一草坪上所有僵尸吃，防止出现不停吃的植物的情况（也可以在植物类中加一个方法包含一个list，将吃这个植物的所有僵尸加到list中，当植物死时调用循环将吃这个植物的僵尸停止（不过一个草坪上的僵尸不会太多，所以就省事的选用全部停止的方法））

                                    break;//一个僵尸一次只能吃一个植物，如果此植物别吃完后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                }
                                plant.cutLife(zombies.getDamage());
                                break;//一个僵尸一次只能吃一个植物，找到吃这个植物的僵尸后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                            }
                        } break;
                    #endregion
                    #region 如果植物在第三个草坪
                        case 3: for (int n = 0; n < Map.plantLand3.getList().Count; n++)
                        {
                            plant = Map.plantLand3.getOnePlant(n);
                            pLocation = plant.getLocation();
                            if (zLocation.X - pLocation.X <= -5 && zLocation.X - pLocation.X > -120)
                            {

                                zombies.beginEat();
                                if (plant.getLife() <= 0)//这种情况当多个僵尸同时吃一个植物时，要最后一口的僵尸会停下而其它的会因为刚被吃的plant已经不存在而不停地吃
                                {

                                    Map.plantList.Remove(plant);
                                    Map.plantLand3.remove(plant);
                                    foreach (Zombies zombie in Map.zombiesLand3.getList()) { zombie.stopEat(); }//一颗植物死后停止这一草坪上所有僵尸吃，防止出现不停吃的植物的情况（也可以在植物类中加一个方法包含一个list，将吃这个植物的所有僵尸加到list中，当植物死时调用循环将吃这个植物的僵尸停止（不过一个草坪上的僵尸不会太多，所以就省事的选用全部停止的方法））

                                    break;//一个僵尸一次只能吃一个植物，如果此植物别吃完后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                }
                                plant.cutLife(zombies.getDamage());
                                break;//一个僵尸一次只能吃一个植物，找到吃这个植物的僵尸后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                            }
                        } break;
                    #endregion
                    #region 如果植物在第四个草坪
                            case 4: for (int n = 0; n < Map.plantLand4.getList().Count; n++)
                            {
                                plant = Map.plantLand4.getOnePlant(n);
                                pLocation = plant.getLocation();
                                if (zLocation.X - pLocation.X <= -5 && zLocation.X - pLocation.X > -120)
                                {

                                    zombies.beginEat();
                                    if (plant.getLife() <= 0)//这种情况当多个僵尸同时吃一个植物时，要最后一口的僵尸会停下而其它的会因为刚被吃的plant已经不存在而不停地吃
                                    {

                                        Map.plantList.Remove(plant);
                                        Map.plantLand4.remove(plant);
                                        foreach (Zombies zombie in Map.zombiesLand4.getList()) { zombie.stopEat(); }//一颗植物死后停止这一草坪上所有僵尸吃，防止出现不停吃的植物的情况（也可以在植物类中加一个方法包含一个list，将吃这个植物的所有僵尸加到list中，当植物死时调用循环将吃这个植物的僵尸停止（不过一个草坪上的僵尸不会太多，所以就省事的选用全部停止的方法））

                                        break;//一个僵尸一次只能吃一个植物，如果此植物别吃完后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                    }
                                    plant.cutLife(zombies.getDamage());
                                    break;//一个僵尸一次只能吃一个植物，找到吃这个植物的僵尸后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                }
                            } break;
                    #endregion
                    #region 如果植物在第五个草坪
                            case 5: for (int n = 0; n < Map.plantLand5.getList().Count; n++)
                            {
                                plant = Map.plantLand5.getOnePlant(n);
                                pLocation = plant.getLocation();
                                if (zLocation.X - pLocation.X <= -5 && zLocation.X - pLocation.X > -120)
                                {

                                    zombies.beginEat();
                                    if (plant.getLife() <= 0)//这种情况当多个僵尸同时吃一个植物时，要最后一口的僵尸会停下而其它的会因为刚被吃的plant已经不存在而不停地吃
                                    {

                                        Map.plantList.Remove(plant);
                                        Map.plantLand5.remove(plant);
                                        foreach (Zombies zombie in Map.zombiesLand5.getList()) { zombie.stopEat(); }//植物死后停止僵尸吃}

                                        break;//一个僵尸一次只能吃一个植物，如果此植物别吃完后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                    }
                                    plant.cutLife(zombies.getDamage());
                                    break;//一个僵尸一次只能吃一个植物，找到吃这个植物的僵尸后，退出针对植物找僵尸的内循环，马上针对另一个植物开始搜索僵尸
                                }
                            } break;
                    #endregion
                }
            }
        }

        //判断是否有僵尸，是否开火
        public static void FireOnOff()
        {
            if (Map.zombiesLand1.getList().Count > 0) { Map.plantLand1.fire(); }
            else { Map.plantLand1.stopFire(); }
            if (Map.zombiesLand2.getList().Count > 0) { Map.plantLand2.fire(); }
            else { Map.plantLand2.stopFire(); }
            if (Map.zombiesLand3.getList().Count > 0) { Map.plantLand3.fire(); }
            else { Map.plantLand3.stopFire(); }
            if (Map.zombiesLand4.getList().Count > 0) { Map.plantLand4.fire(); }
            else { Map.plantLand4.stopFire(); }
            if (Map.zombiesLand5.getList().Count > 0) { Map.plantLand5.fire(); }
            else { Map.plantLand5.stopFire(); }
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

                if (Map.bulletList[i].getLocation().X > 900) { Map.bulletList.Remove(Map.bulletList[i]); continue; }//如果子弹超过一定距离，则让其消失
                Map.bulletList[i].nextAction();
            }
            //改变僵尸位置和当前帧
            for (int i = 0; i < Map.zombiesList.Count; i++)
            {

                if (Map.zombiesList[i].getLocation().X < 100) { Map.zombiesList.Remove(Map.zombiesList[i]); continue; }
                Map.zombiesList[i].nextAction();
            }
            //判断是否开火
            FireOnOff();
            //判断时候攻击植物
            attackPlants();
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
            //子弹打僵尸的动作
            attackZombies(g);
        }
    }
}

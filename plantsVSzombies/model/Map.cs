using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using plantsVSzombies.model.plants;
using plantsVSzombies.model.levebackground;
using plantsVSzombies.model.bullet;
using plantsVSzombies.model.zombies;

namespace plantsVSzombies.model
{
    class Map
    {
        
        public static List<BackGround> background = new List<BackGround>();
        public static List<Bullet> bulletList = new List<Bullet>();
    
        public static List<Plants> plantList = new List<Plants>();
        public static PlantLandList plantLand1 = new PlantLandList();
        public static PlantLandList plantLand2 = new PlantLandList();
        public static PlantLandList plantLand3 = new PlantLandList();
        public static PlantLandList plantLand4 = new PlantLandList();
        public static PlantLandList plantLand5 = new PlantLandList();

        public static List<Zombies> zombiesList = new List<Zombies>();
        public static ZombiesLandList zombiesLand1 = new ZombiesLandList();
        public static ZombiesLandList zombiesLand2 = new ZombiesLandList();
        public static ZombiesLandList zombiesLand3 = new ZombiesLandList();
        public static ZombiesLandList zombiesLand4 = new ZombiesLandList();
        public static ZombiesLandList zombiesLand5 = new ZombiesLandList();

    }
}

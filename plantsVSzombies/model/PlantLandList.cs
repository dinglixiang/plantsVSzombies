using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using plantsVSzombies.model.plants;

namespace plantsVSzombies.model
{
    class PlantLandList
    {
        public List<Plants> plantList;

        public PlantLandList()
        {

            plantList = new List<Plants>();

        }

        public void addPlant(Plants plant)
        {

            plantList.Add(plant);
        }

        public void remove(Plants plant)
        {

            plantList.Remove(plant);
        }

        public List<Plants> getList()
        {

            return plantList;
        }
        public Plants getOnePlant(int n)
        {

            return plantList[n];
        }
        public void fire()
        {

            foreach (Plants plant in plantList)
            {

                plant.beginAttack();
            }
        }

        public void stopFire()
        {

            foreach (Plants plant in plantList)
            {

                plant.stopAttack();
            }
        }
    }
}

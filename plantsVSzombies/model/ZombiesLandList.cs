using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using plantsVSzombies.model.zombies;
namespace plantsVSzombies.model
{
    class ZombiesLandList
    {
        private List<Zombies> zombiesList;

        public ZombiesLandList()
        {

            zombiesList = new List<Zombies>();
        }

        public void addZombies(Zombies zombies)
        {

            this.zombiesList.Add(zombies);
        }

        public void remove(Zombies zombies)
        {

            this.zombiesList.Remove(zombies);
        }

        public List<Zombies> getList()
        {

            return zombiesList;
        }

        public Zombies getOneZombie(int n)
        {

            return zombiesList[n];
        }
    }
}

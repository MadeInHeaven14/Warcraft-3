using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Building
    {
        public int Health { get; set; }
        public int Cost { get; set; }

        public int Lvl;
        
        public Building (int health, int cost, int lvl)
        {
            Health = health;
            Cost = cost;
            Lvl = lvl;
        }
    }
}

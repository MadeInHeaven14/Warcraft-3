using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Unit
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int MoveSpeed { get; set; }
        public int Cost { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public int lvl { get; set; }

        public static List<Unit> Units = new List<Unit>();

        public Unit (int health, int moveSpeed, int cost, int damage, string name, int lvl)
        {
            Health = health;
            MoveSpeed = moveSpeed;
            Cost = cost;
            Damage = damage;
            Name = name;
            this.lvl = lvl;
            MaxHealth = Health;
            Units.Add(this);
        }

        public void Move()
        {

        }

        public virtual void Attack(Unit unit)
        {
            if (unit.Name == this.Name)
            {
                Console.WriteLine("Нельзя атаковать самого себя!");
                return;
            }

            if (unit.Health == 0)
            {
                Console.WriteLine("Невозможно атаковать, так как герой мёртв!");
                return;
            }

            if (unit.Health > 0)
            {
                if (unit.Health < this.Damage)
                {
                    unit.Health = 0;
                    Console.WriteLine(unit.Name + " " + "Повержен!");
                }
                else
                {
                    unit.Health -= this.Damage;
                    Console.WriteLine(this.Name + " " + "атакует" + " " + unit.Name + "а!" + " " + "У" + " " + unit.Name + "а" + " " + "осталось" + " " + unit.Health + " " + "hp!");
                }
            }

            if (this.Health == 0)
            {
                Console.WriteLine($"{this.Name} Повержен!");

            }
        }
    }
}

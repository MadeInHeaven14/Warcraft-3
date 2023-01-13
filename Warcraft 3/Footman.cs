using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Footman : Unit
    {
        public int Armor { get; set; } = 5;
        public Footman(int armor) : base(80, 140, 200, 15, "Мечник", 1)
        {
            Armor = armor;
        }

        public void Rage()
        {
            this.Damage = this.Damage + 10;
        }

        public override void Attack(Unit unit)
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

            if (this.Health <= 10)
            {
                Console.WriteLine("Мечник усиляется!");
                this.Rage();
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
                    Console.WriteLine("Мечник атакует" + " " + unit.Name + "а!" + " " + "У" + " " + unit.Name + "а" + " " + "осталось" + " " + unit.Health + " " + "hp!");
                }
            }

            if (this.Health == 0)
            {
                Console.WriteLine($"{this.Name}Повержен!");

            }
        }

        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Уровень:" + " " + this.lvl);
            Console.WriteLine("Имя:" + " " + this.Name);
            Console.WriteLine("Здоровье:" + " " + this.Health);
            Console.WriteLine("Урон:" + " " + this.Damage);
            Console.WriteLine("Скорость:" + " " + this.MoveSpeed);
            Console.WriteLine("Броня:" + " " + this.Armor);
        }
    }
}

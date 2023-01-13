using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Archer : Unit
    {
        protected int Arrows = 30;
        protected int Range = 50;
        public Archer() : base(70, 250, 190, 10, "Лучник", 1)
        {
        }

        public override void Attack(Unit unit)
        {
            if (unit.Health == 0)
            {
                Console.WriteLine("Невозможно атаковать, так как герой мёртв!");
                return;
            }

            if (unit.Name == this.Name)
            {
                Console.WriteLine("Нельзя атаковать самого себя!");
                return;
            }

            if (Arrows > 0)
            {
                if (unit.Health > 0)
                {
                    if (unit.Health <= this.Damage)
                    {
                        unit.Health = 0;
                        Console.WriteLine(unit.Name + " " + "Повержен!");
                    }
                    else
                    {
                        unit.Health -= this.Damage;
                        Arrows -= 1;
                        Console.WriteLine("Лучник атакует" + " " + unit.Name + "а!" + " " + "У" + " " + unit.Name + "а" + " " + "осталось" + " " + unit.Health + " " + "hp! У Лучника осталось" + " " + Arrows + " " + "стрел!");
                    }
                }

                if (this.Health == 0)
                {
                    Console.WriteLine("Лучник Повержен!");
                }
            }

            if (Arrows == 0)
            {
                Console.WriteLine("Недостаточно стрел!");
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
            Console.WriteLine("Кол-во стрел:" + " " + this.Arrows);
        }
    }
}

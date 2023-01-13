using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Peasant : Unit
    {
        public bool isWork;
        public Peasant() : base(40, 100, 50, 5, "Крестьянин", 1)
        {
        }

        public void Mining()
        {
            isWork = true;
            Console.WriteLine("Я копаю");
        }

        public void Build()
        {
            isWork = true;
            Console.WriteLine("Я строю");
        }

        public void Cancel()
        {
            isWork = false;
            Console.WriteLine("Действие отменено");
        }


        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Уровень:" + " " + this.lvl);
            Console.WriteLine("Имя:" + " " + this.Name);
            Console.WriteLine("Здоровье:" + " " + this.Health);
            Console.WriteLine("Урон:" + " " + this.Damage);
            Console.WriteLine("Скорость:" + " " + this.MoveSpeed);
        }
    }
}

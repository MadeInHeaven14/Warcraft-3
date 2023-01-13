using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class Mage : Unit
    {
        protected int Mana = 200;
        public Mage() : base(60, 200, 250, 8, "Маг", 1)
        {
        }


        public void CastFireBall(Unit unit)
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

            if (Mana >= 50)
            {
                if (unit.Health < 30)
                {
                    unit.Health = 0;
                    Console.WriteLine(unit.Name + " " + "Повержен огненным шаром!");
                }
                unit.Health -= 30;
                Mana -= 50;
                Console.WriteLine("Маг атакует" + " " + unit.Name + "а" + " " + "Огненным шаром! У" + " " + unit.Name + "а" + " " + "осталось" + " " + unit.Health + " " + "hp! У Мага осталось" + " " + Mana + " " + "маны!");
            }

            else
            {
                Console.WriteLine("Недостаточно маны!");
            }
        }

        public void TargetHeal(Unit unit)
        {
            if (unit.Name == this.Name)
            {
                if (unit.Health + 20 > this.MaxHealth)
                {
                    unit.Health = unit.MaxHealth;
                }
                this.Health += 20;
            }

            if (unit.Health + 20 > unit.MaxHealth)
            {
                unit.Health = unit.MaxHealth;
            }

            if (unit.Health == 0)
            {
                Console.WriteLine("Невозможно вылечить, так как герой мёртв!");
                return;
            }
            unit.Health += 20;
            Mana -= 70;
            Console.WriteLine(this.Name + " " + "исцеляет" + " " + unit.Name + "а" + " " + "на 20 hp! Теперь у него" + " " + unit.Health + " " + "hp! У Мага осталось" + " " + Mana + " " + "маны!");
        }

        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Уровень:" + " " + this.lvl);
            Console.WriteLine("Имя:" + " " + this.Name);
            Console.WriteLine("Здоровье:" + " " + this.Health);
            Console.WriteLine("Урон:" + " " + this.Damage);
            Console.WriteLine("Скорость:" + " " + this.MoveSpeed);
            Console.WriteLine("Мана:" + " " + this.Mana);
        }

    }
}

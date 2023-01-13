using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Warcraft_3
{
    internal class BlackSmith : Building
    {
        protected int UpDamage;
        protected int UpArmor;
        protected int UpBow;

        public BlackSmith() : base(120, 400, 1)
        {
        }

        public void UpgradeAllUnits(List<Unit> units)
        {
            foreach (var unit in units)
            {
                if (unit.lvl < 3)
                {
                    if (unit.Name == "Мечник")
                    {
                        unit.Armor += 1;
                    }

                    if (unit.Name == "Лучник")
                    {
                        unit.Range += 30;
                    }
                    unit.Damage += 3;
                    unit.lvl += 1;
                }

                else
                {
                    Console.WriteLine($"Невозможно повысить уровень {unit.Name}, так как его уровень уже максимальный!");
                }
            }
        }
        public void UpgradeUnit(Unit unit)
        {
            if (unit.lvl < 3)
            {
                if (unit.Name == "Мечник")
                {
                    unit.Armor += 1;
                }

                if (unit.Name == "Лучник")
                {
                    unit.Range += 30;
                }
                unit.Damage += 3;
                unit.lvl += 1;
            }

            else
            {
                Console.WriteLine($"Невозможно повысить уровень {unit.Name}, так как его уровень уже максимальный!");
            }
        }
    }
}

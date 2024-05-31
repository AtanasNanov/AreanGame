using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Katana : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public double Sharpness { get; private set; }

        public Tesla(string name, double sharpness)
        {
            Name = name;
            AttackDamage = 90;
            BlockingPower = 6;
            Sharpness = sharpness;
        }
    }
}

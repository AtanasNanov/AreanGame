using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class TommyGun : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public bool Magazine { get; private set; }

        public TommyGun(string name, bool magazine)
        {
            Name = name;
            AttackDamage = 70;
            Magazine = magazine;
        }
    }
}

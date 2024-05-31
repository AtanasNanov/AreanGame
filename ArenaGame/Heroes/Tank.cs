using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Tank : Hero
    {
        public bool Tank { get; private set; }

        public Knight(string name, double armor, double strength, IWeapon weapon, bool parry) :
            base(name, armor, strength, weapon)
        {
            Parry = parry;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if (Tank)
            {
                damage *= 1.2;
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            double reducedDamage = base.Defend(damage);

            if (Parry)
            {
                reducedDamage *= 0.1;
            }
            return reducedDamage; // if the Tank parries, it reduces the damage by 90%
        }
    }
}

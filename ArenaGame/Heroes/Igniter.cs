using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Igniter : Hero
    {
        public int IgniteDamage { get; private set; }

        public Igniter(string name, double armor, double strength, IWeapon weapon, int igniteDamage) :
            base(name, armor, strength, weapon)
        {
            IgniteDamage = igniteDamage;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            return damage + IgniteDamage;
        }

        public override double Defend(double damage)
        {
            double reducedDamage = base.Defend(damage);
            if (IgniteDamage > 0)
            {
                reducedDamage *= 0.8;
            }
            return reducedDamage;
        }
    }
}

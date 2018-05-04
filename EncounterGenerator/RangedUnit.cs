using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterGenerator
{
    class RangedUnit : EnemyUnit
    {
        public TomeType Tome { get; set; }
        private bool tomeUser;
        public RangedUnit(int level, int seed) : base(level, seed)
        {
            Weapon = (WeaponType)(seed % 3 + 3);
            tomeUser = Weapon == WeaponType.Tome;
            bool oddSeed = (seed % 2 == 1);
            Random r = new Random();

            if (oddSeed)
            {
                HP = level * 4;
            }
            else
            {
                HP = level * 5;
            }

            //Always light armor
            AC = 7 + (seed % 10) + (r.Next() % 10);

            if (tomeUser)
            {
                Tome = (TomeType)(seed % 5);
            }
        }

            public override string GetDamageRoll()
        {
            if(tomeUser)
            {
                return "1d" + DamageDie + " + " + AttackBonus + " " + Tome.ToString();
            }

            return "1d" + DamageDie + " + " + AttackBonus;
        }
    } 
}


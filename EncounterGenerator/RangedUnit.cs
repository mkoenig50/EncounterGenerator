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
        public RangedUnit(int level, int seed)
        {
            Weapon = (WeaponType)(seed % 3 + 3);
            tomeUser = Weapon == WeaponType.Tome;
            bool oddSeed = (seed % 2 == 1);
            Random r = new Random();

            if (oddSeed)
            {
                HP = level * 8;
            }
            else
            {
                HP = level * 10;
            }

            //Always light armor
            AC = 7 + (seed % 10) + (r.Next() % 10);

            //Determine damage values based on level
            if (level <= 5)
            {
                AttackBonus = seed % 4;
                DamageDie = (seed % 3 + 2) * 2;
            }
            else if (level <= 10)
            {
                AttackBonus = seed % 4 + 1;
                DamageDie = (seed % 2 + 3) * 2;
            }
            else if (level <= 15)
            {
                AttackBonus = seed % 4 + 2;
                DamageDie = (seed % 3 + 3) * 2;
            }
            else if (level <= 20)
            {
                AttackBonus = seed % 4 + 3;
                DamageDie = (seed % 3 + 4) * 2;
            }

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


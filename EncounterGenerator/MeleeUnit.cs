using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterGenerator
{
    class MeleeUnit : EnemyUnit
    {
        public MeleeUnit(int level, int seed)
        {
            Weapon = (WeaponType)(seed % 3);
            bool oddSeed = (seed % 2 == 1);
            Random r = new Random();

            //Heavy armor or light armor 
            if (oddSeed)
            {
                HP = level * 12;
                AC = 12 + seed % 10;
            }
            else
            {
                HP = level * 10;
                AC = 7 + (seed % 10) + (r.Next() % 10);
            }

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
        }

        public override string GetDamageRoll()
        {
            return "1d" + DamageDie + " + " + AttackBonus;
        }
    }
}

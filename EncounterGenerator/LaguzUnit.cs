using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterGenerator
{
    class LaguzUnit : EnemyUnit
    {
        public LaguzTribe Tribe { get; set; }

        public LaguzUnit (int level, int seed)
        {
            //Laguz always use formshift
            Weapon = WeaponType.Formshift;
            Tribe = (LaguzTribe)(seed % 3);
            bool oddSeed = (seed % 2 == 1);
            Random r = new Random();

            if(oddSeed)
            {
                HP = level * 10;
            }
            else
            {
                HP = level * 12;
            }

            //Always light armor
            AC = 7 + (seed % 10 + 1) + (r.Next() % 10 + 1);

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
            return "1d" + DamageDie + " + " + AttackBonus + " " + Tribe.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterGenerator
{
    class MeleeUnit : EnemyUnit
    {
        public TypeModifier type;

        public MeleeUnit(int level, int seed) : base(level, seed)
        {
            Weapon = (WeaponType)(seed % 3);
            Random r = new Random();
            int typeSeed = r.Next() % 100;

            if(typeSeed < 30)
            {
                type = TypeModifier.None;
            }
            else if (typeSeed < 50)
            {
                type = TypeModifier.Heavy;
            }
            else if (typeSeed < 70)
            {
                type = TypeModifier.Mounted;
            }
            else if (typeSeed < 85)
            {
                type = TypeModifier.Flying;
            }
            else
            {
                type = TypeModifier.Wyvern;
            }
        }

        public override string GetDamageRoll()
        {
            return "1d" + DamageDie + " + " + AttackBonus + " " + type;
        }
    }
}

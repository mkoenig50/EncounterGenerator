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

        
        public LaguzUnit (int level, int seed) : base(level, seed)
        {
            //Laguz always use formshift
            Weapon = WeaponType.Formshift;
            Tribe = (LaguzTribe)(seed % 3);
            Random r = new Random();
            
            //Always light armor
            AC = 7 + (seed % 10 + 1) + (r.Next() % 10 + 1);
        }

        public override string GetDamageRoll()
        {
            return "1d" + DamageDie + " + " + AttackBonus + " " + Tribe.ToString();
        }
    }
}

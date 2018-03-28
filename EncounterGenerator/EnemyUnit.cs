using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterGenerator
{
    abstract class EnemyUnit
    {
        public int HP { get; set; }
        public int AC { get; set; }
        public WeaponType Weapon { get; set; }
        public string WeaponTypeDesc { get { return Weapon.ToString(); } set { } }
        public int AttackBonus { get; set; }
        public int DamageDie { get; set; }
        public string DamageRoll
        {
            get
            {
                return GetDamageRoll();
            }
            set
            {
                //Do nothing
            }
        }

        abstract public string GetDamageRoll();
    }
}

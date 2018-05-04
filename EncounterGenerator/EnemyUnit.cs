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
        private int baseAC;
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

        public EnemyUnit(int level, int seed)
        {
            bool oddSeed = (seed % 2 == 1);
            Random r = new Random();

            //If odd - Light armor Else - Heavy
            if (oddSeed)
            {
                HP = level * 5;
                baseAC = 7;
                AC = 7 + (seed % 10) + (r.Next() % 10);
            }
            else
            {
                HP = level * 6;
                baseAC = 12;
                AC = 12 + seed % 10;
            }

            //Determine damage values based on level
            if (level <= 5)
            {
                AttackBonus = seed % 4;
                DamageDie = (seed % 3 + 2) * 2;
                AC = baseAC + seed % 4 + r.Next() % 4 + 4;
            }
            else if (level <= 10)
            {
                AttackBonus = seed % 4 + r.Next() % 4 + 6;
                DamageDie = (seed % 2 + 3) * 2;
                AC = baseAC + seed % 4 + r.Next() % 4 + 6;
            }
            else if (level <= 15)
            {
                AttackBonus = seed % 6 + r.Next() % 6 + 8;
                DamageDie = (seed % 3 + 3) * 2;
                AC = baseAC + seed % 6 + r.Next() % 6 + 8;
            }
            else if (level <= 20)
            {
                AttackBonus = seed % 5 + r.Next() % 5 + 10;
                DamageDie = (seed % 3 + 4) * 2;
                AC = baseAC + seed % 5 + r.Next() % 5 + 10;
            }
        }
    }
}

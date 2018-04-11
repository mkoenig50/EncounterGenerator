using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncounterGenerator
{
    public partial class EncounterGenerator : Form
    {
        public EncounterGenerator()
        {
            InitializeComponent();
            dgvFoeList.AutoGenerateColumns = false;
            colAC.DataPropertyName = "AC";
            colHP.DataPropertyName = "HP";
            colDamage.DataPropertyName = "DamageRoll";
            colAttackBonus.DataPropertyName = "AttackBonus";
            colWeaponType.DataPropertyName = "WeaponTypeDesc";
        }

        private void btnGenerateEncounter_Click(object sender, EventArgs e)
        {
            int numberOfMeleeEnemies = int.Parse(txtNumberOfMelee.Text);
            int numberOfRangedEnemies = int.Parse(txtNumberOfRanged.Text);
            int numberOfLaguzEnemies = int.Parse(txtNumberOfLaguz.Text);
            int enemyLevel = int.Parse(txtLevel.Text);

            MeleeUnit meleeEnemy;
            RangedUnit rangedEnemy;
            LaguzUnit laguzEnemy;
            Random r = new Random();

            int seed;

            List<EnemyUnit> enemies = new List<EnemyUnit>();
            for (int i = 0; i < numberOfMeleeEnemies; i++)
            {
                seed = r.Next() % 100;
                meleeEnemy = new MeleeUnit(enemyLevel, seed);
                enemies.Add(meleeEnemy);
            }

            for (int i = 0; i < numberOfRangedEnemies; i++)
            {
                seed = r.Next() % 100;
                rangedEnemy = new RangedUnit(enemyLevel, seed);
                enemies.Add(rangedEnemy);
            }

            for (int i = 0; i < numberOfLaguzEnemies; i++)
            {
                seed = r.Next() % 100;
                laguzEnemy = new LaguzUnit(enemyLevel, seed);
                enemies.Add(laguzEnemy);
            }

            dgvFoeList.DataSource = enemies;
        }
    }
}

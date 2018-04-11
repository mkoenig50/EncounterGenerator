namespace EncounterGenerator
{
    partial class EncounterGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateEncounter = new System.Windows.Forms.Button();
            this.txtNumberOfMelee = new System.Windows.Forms.TextBox();
            this.txtNumberOfRanged = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lblNumberOfMelee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFoeList = new System.Windows.Forms.DataGridView();
            this.colHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttackBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDamage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeaponType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfLaguz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateEncounter
            // 
            this.btnGenerateEncounter.Location = new System.Drawing.Point(459, 45);
            this.btnGenerateEncounter.Name = "btnGenerateEncounter";
            this.btnGenerateEncounter.Size = new System.Drawing.Size(139, 23);
            this.btnGenerateEncounter.TabIndex = 0;
            this.btnGenerateEncounter.Text = "Generate Encounter";
            this.btnGenerateEncounter.UseVisualStyleBackColor = true;
            this.btnGenerateEncounter.Click += new System.EventHandler(this.btnGenerateEncounter_Click);
            // 
            // txtNumberOfMelee
            // 
            this.txtNumberOfMelee.Location = new System.Drawing.Point(35, 47);
            this.txtNumberOfMelee.Name = "txtNumberOfMelee";
            this.txtNumberOfMelee.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfMelee.TabIndex = 1;
            // 
            // txtNumberOfRanged
            // 
            this.txtNumberOfRanged.Location = new System.Drawing.Point(141, 47);
            this.txtNumberOfRanged.Name = "txtNumberOfRanged";
            this.txtNumberOfRanged.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfRanged.TabIndex = 2;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(353, 47);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 3;
            // 
            // lblNumberOfMelee
            // 
            this.lblNumberOfMelee.AutoSize = true;
            this.lblNumberOfMelee.Location = new System.Drawing.Point(32, 31);
            this.lblNumberOfMelee.Name = "lblNumberOfMelee";
            this.lblNumberOfMelee.Size = new System.Drawing.Size(88, 13);
            this.lblNumberOfMelee.TabIndex = 4;
            this.lblNumberOfMelee.Text = "Number of Melee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Ranged";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level";
            // 
            // dgvFoeList
            // 
            this.dgvFoeList.AllowUserToAddRows = false;
            this.dgvFoeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHP,
            this.colAC,
            this.colAttackBonus,
            this.colDamage,
            this.colWeaponType});
            this.dgvFoeList.Location = new System.Drawing.Point(35, 99);
            this.dgvFoeList.Name = "dgvFoeList";
            this.dgvFoeList.RowHeadersVisible = false;
            this.dgvFoeList.Size = new System.Drawing.Size(732, 317);
            this.dgvFoeList.TabIndex = 7;
            // 
            // colHP
            // 
            this.colHP.HeaderText = "HP";
            this.colHP.Name = "colHP";
            // 
            // colAC
            // 
            this.colAC.HeaderText = "AC";
            this.colAC.Name = "colAC";
            this.colAC.ReadOnly = true;
            // 
            // colAttackBonus
            // 
            this.colAttackBonus.HeaderText = "Attack Bonus";
            this.colAttackBonus.Name = "colAttackBonus";
            this.colAttackBonus.ReadOnly = true;
            // 
            // colDamage
            // 
            this.colDamage.HeaderText = "Damage";
            this.colDamage.Name = "colDamage";
            this.colDamage.ReadOnly = true;
            // 
            // colWeaponType
            // 
            this.colWeaponType.HeaderText = "Weapon Type";
            this.colWeaponType.Name = "colWeaponType";
            this.colWeaponType.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of Laguz";
            // 
            // txtNumberOfLaguz
            // 
            this.txtNumberOfLaguz.Location = new System.Drawing.Point(247, 48);
            this.txtNumberOfLaguz.Name = "txtNumberOfLaguz";
            this.txtNumberOfLaguz.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfLaguz.TabIndex = 8;
            // 
            // EncounterGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfLaguz);
            this.Controls.Add(this.dgvFoeList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfMelee);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtNumberOfRanged);
            this.Controls.Add(this.txtNumberOfMelee);
            this.Controls.Add(this.btnGenerateEncounter);
            this.Name = "EncounterGenerator";
            this.Text = "Encounter Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateEncounter;
        private System.Windows.Forms.TextBox txtNumberOfMelee;
        private System.Windows.Forms.TextBox txtNumberOfRanged;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label lblNumberOfMelee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFoeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttackBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDamage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeaponType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfLaguz;
    }
}


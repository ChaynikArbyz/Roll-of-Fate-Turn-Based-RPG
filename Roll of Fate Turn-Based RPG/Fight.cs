using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnemyClass;
using PlayerClass;

namespace Roll_of_Fate_Turn_Based_RPG
{
    public partial class Fight : Form
    {
        Player player;
        Enemy enemy;
        public Fight(Player newPlayer)
        {
            InitializeComponent();
            player = newPlayer;
            enemy = new Enemy(player);
            MessageBox.Show("На вас напали!","Fight time!", MessageBoxButtons.OK);
            ShowStats();
        }

        void ShowStats()
        { 
            EnemyInfoLabel.Text = $"{enemy.Name}\n\nУровень: {enemy.Level}\nЗащита: {enemy.Defence}\nЗдоровье: {enemy.Health}/{enemy.MaxHealth}\n\nНагарада:{enemy.RewardXp} Xp {enemy.RewardGold} Золота";
            EnemyHealthLabel.Text = $"{enemy.Health}/{enemy.MaxHealth}";
            EnemyHealthBar.Maximum = enemy.MaxHealth;
            EnemyHealthBar.Value = enemy.Health;

            HealthCountLabel.Text = $"{player.Health}/{player.MaxHealth}";
            HealthBar.Maximum = player.MaxHealth;
            HealthBar.Value = player.Health;
            HealPotionLabel.Text = $"Зелье здоровья: {player.HealPotion}";
            HealthPotionToUse.Text = $"Раундов до использования: {HealthToUse}";

            ManaCountLabel.Text = $"{player.Mana}/{player.MaxMana}";
            ManaBar.Maximum = player.MaxMana;
            ManaBar.Value = player.Mana;
            ManaPotionLabel.Text = $"Зелье Манны: {player.ManaPotion}";
            ManaPotionToUse.Text = $"Раундов до использования: {ManaToUse}";

        }




        private void Win() 
        {
            ShowStats();
            player.IncreaseExp(enemy.RewardXp);
            player.IncreaseMoney(enemy.RewardGold);
            MessageBox.Show($"Вы победили!", "Win", MessageBoxButtons.OK);
            ShowStats();
            exitButton.Visible = true;
        }

        private void Fight_Load(object sender, EventArgs e)
        {

        }

        int HealthToUse = 0;
        int ManaToUse = 0;

        private void FightRound(int choise)
        {
            ShowStats();
            AttackButton.Enabled = false;
            BlockButton.Enabled = false;
            AbilityButton.Enabled = false;
            HealthPotionButton.Enabled = false;
            ManaPotionButton.Enabled = false;

            switch (choise)
            {
                case 1:
                    enemy.TakeDamage(player, 100);
                    if (enemy.Health <= 0) { Win(); return; }
                    ShowStats();
                    enemy.DealDamage(player);
                    break;
                case 2:
                    player.isBlocking = true;
                    if (enemy.Health <= 0) { Win(); return; }
                    ShowStats();
                    enemy.DealDamage(player);
                    break;
                default:
                    if (player.Weapon.UseAbility(player, enemy))
                    {
                        if (enemy.Health <= 0) { Win(); return; }
                        ShowStats();
                        enemy.DealDamage(player);
                    }
                    break;
            }

            ShowStats();
            if (HealthToUse > 0) { HealthToUse--; }
            if (ManaToUse > 0) { ManaToUse--; }
            ShowStats();
            if (player.Health > 0)
            {
                AttackButton.Enabled = true;
                BlockButton.Enabled = true;
                AbilityButton.Enabled = true;
                HealthPotionButton.Enabled = true;
                ManaPotionButton.Enabled = true;
            }
        }

        private void AttackButton_Click(object sender, EventArgs e) => FightRound(1);

        private void BlockButton_Click(object sender, EventArgs e) => FightRound(2);

        private void AbilityButton_Click(object sender, EventArgs e) => FightRound(3);

        private void HealthPotionButton_Click(object sender, EventArgs e)
        {
            if (HealthToUse <= 0)
            { HealthToUse = 5; player.UseHealPotion(); ShowStats(); }
        }

        private void ManaPotionButton_Click(object sender, EventArgs e)
        {
            if (ManaToUse <= 0)
            { ManaToUse = 5; player.UseManaPotion(); ShowStats(); }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(player);
            this.Close();
            form.Show();
        }
    }
}

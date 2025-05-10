using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonServise;
using PlayerClass;
using Roll_of_Fate_Turn_Based_RPG.Properties;


namespace Roll_of_Fate_Turn_Based_RPG
{
    public partial class MainForm : Form
    {
        SaveLoadService SLService = new SaveLoadService();
        Player player;
        public MainForm(Player newPlayer)
        {
            InitializeComponent();
            player = newPlayer;
            ShowStats();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

        private void ShowStats()
        {
            nameLabel.Text = $"- {player.Name} -";

            WeaponLabel.Text = $"Оружие: {player.Weapon.Name}";
            ArmorLabel.Text = $"Броня: {player.Armor.Name}";

            LvlCountLabel.Text = $"Уровень: {player.Level}";
            expCountLabel.Text = $"{player.Experience}/{player.LevelCup}";
            ExpBar.Maximum = player.LevelCup;
            ExpBar.Value = player.Experience;

            HealthCountLabel.Text = $"{player.Health}/{player.MaxHealth}";
            HealthBar.Maximum = player.MaxHealth;
            HealthBar.Value = player.Health;

            ManaCountLabel.Text = $"{player.Mana}/{player.MaxMana}";
            ManaBar.Maximum = player.MaxMana;
            ManaBar.Value = player.Mana;

            StrengthLabel.Text = $"Сила: {player.Strength}";
            AgilityLabel.Text = $"Выносливость: {player.Agility}";
            EnduranceLabel.Text = $"Ловкость: {player.Endurance}";
            IntelligenceLabel.Text = $"Интелект: {player.Intelligence}";

            CritChanceLabel.Text = $"Шанс крит. урона: {player.CalculateCriticalChance()}%";
            AvoidChanceLabel.Text = $"Шанс увернуться: {player.CalculateAvoidChance()}%";

            GoldLabel.Text = $"Золото: {player.Gold}";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        { SLService.Save(player); MessageBox.Show("Успешно сохранено!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
    }
}

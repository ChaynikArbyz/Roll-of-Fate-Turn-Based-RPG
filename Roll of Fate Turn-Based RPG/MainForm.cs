using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonServise;
using PlayerClass;
using Roll_of_Fate_Turn_Based_RPG.Properties;
using RollServ;


namespace Roll_of_Fate_Turn_Based_RPG
{
    public partial class MainForm : Form
    {
        RollService rollService = new RollService();
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

            WeaponLabel.Text = $"Оружие: {player.Weapon.Name}\nБонус к урону: {player.Weapon.GetAttackBonus()}\nСпособность: {player.Weapon.AbilityDescription}";
            ArmorLabel.Text = $"Броня: {player.Armor.Name}\nБонус к защите: {player.Armor.GetDefenseBonus()}";

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
            HealPotionsLabel.Text = $"Зелья здоровья: {player.HealPotion}";
            ManaPotionsLabel.Text = $"Зелья маны: {player.ManaPotion}";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SLService.Save(player);
            SaveButton.Enabled = false;
            SucessLabel.Visible = true;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 2000 };
            timer.Tick += (s, ev) =>
            {
                SaveButton.Enabled = true;
                SucessLabel.Visible = false;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private PictureBox pictureBox10;
        bool isRolling = false;
        private void RollButton_Click(object sender, EventArgs e)
        {
            if (isRolling) { return; }
            isRolling = true;
            RollButton.Enabled = false;

            pictureBox10 = new PictureBox();
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Image = Resources.RollingDice;
            pictureBox10.Location = new Point(1094, 220);
            pictureBox10.Size = new Size(506, 600);
            pictureBox10.TabStop = false;

            Controls.Add(pictureBox10);
            pictureBox10.BringToFront();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 2000 };
            timer.Tick += (s, ev) =>
            {
                if (pictureBox10 != null)
                {
                    Controls.Remove(pictureBox10);
                    pictureBox10.Dispose();
                    pictureBox10 = null;
                }

                timer.Stop();
                timer.Dispose();

                isRolling = false;
                RollButton.Enabled = true;

                ShowStats();
                rollService.RollRandom(player, this);
                player.IncreaseExp(player.LevelCup / 30);
                player.Heal(player.MaxHealth / 50);
                player.HealMana(player.MaxMana / 15);
                ShowStats();



            };
            timer.Start();
        }

        private void UseHealthPotionButton_Click(object sender, EventArgs e)
        { 
            player.UseHealPotion();
            ShowStats(); 
        }

        private void UseManaPotionButton_Click(object sender, EventArgs e)
        {
            player.UseManaPotion();
            ShowStats();
        }
    }
}

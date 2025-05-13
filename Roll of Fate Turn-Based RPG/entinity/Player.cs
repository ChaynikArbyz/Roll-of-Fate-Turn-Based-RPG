using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArmorClass;
using EnemyClass;
using JsonService;
using MSPlayer;
using Roll_of_Fate_Turn_Based_RPG;
using Roll_of_Fate_Turn_Based_RPG.Properties;
using WeaponClass;
using WoodenStickW;

namespace PlayerClass
{

    public class Player
    {
        Random random = new Random();
        SaveLoadService saveLoadService = new SaveLoadService();

        public string Name = "";

        public int Level = 1;
        public int LevelCup = 100;
        public int Experience = 0;

        public int Health = 100;
        public int MaxHealth = 100;
        public int Mana = 50;
        public int MaxMana = 50;

        public int Strength = 1;
        public int Endurance = 1;
        public int Agility = 1;
        public int Intelligence = 1;

        public double CriticalChance = 0;
        public double AvoidChance = 0;

        public bool isBlocking = false;

        public bool died = false;

        public int Gold = 0;

        public Weapon Weapon = new WoodenStick();
        public Armor Armor = new Armor();

        public int HealPotion = 0;
        public int ManaPotion = 0;

        public Player()
        {
            this.Health = this.MaxHealth;
            this.Mana = this.MaxMana;
            CalculateCriticalChance();
            CalculateAvoidChance();
        }

        public double CalculateCriticalChance()
        {
            this.CriticalChance = this.Agility;
            return this.CriticalChance; }
        public double CalculateAvoidChance()
        {
            this.AvoidChance = this.Endurance;
            return this.AvoidChance;
        }

        public void AddAgility(int toAdd) { Agility = Math.Max(1,Agility + toAdd); CalculateCriticalChance(); }
        public void AddEndurance(int toAdd) { Endurance = Math.Max(1, Endurance + toAdd); CalculateAvoidChance(); }
        public void AddStrength(int toAdd) { Strength = Math.Max(1, Strength + toAdd); MaxHealth = 100 + Strength * 25; }
        public void AddIntelligence(int toAdd) { Intelligence = Math.Max(1, Intelligence + toAdd); MaxMana = 50 + Intelligence * 10; }

        public int CalculateAttackPower() { return this.Strength * 5 + Weapon.AttackBonus; }

        public int CalculateDefense() { return this.Strength * 4 + Armor.DefenseBonus; }



        public int DealingDamage()
        {
            if (random.NextDouble() <= CalculateCriticalChance() / 100)
            {
                MessageBox.Show("Крит.Шанс сработал! х2 урон");
                return CalculateAttackPower() * 2;
            }
            else { return CalculateAttackPower(); }
        }

        public void TakeDamage(int damage)
        {
            if (random.NextDouble() <= CalculateAvoidChance() / 100) { MessageBox.Show("Ви увернулись от атаки"); }
            else
            {
                DecreaseHealth(damage);
            }
        }

        public void StatsUp()
        {
            MessageBox.Show("Поднятие Уровня", "Level Up!");
            Level++;
            LevelCup = 125 * Level;

            Strength += 2;
            Endurance++;
            Agility++;
            Intelligence++;
            CalculateCriticalChance();
            CalculateAvoidChance();

            MaxHealth = 100 + Strength * 25;
            MaxMana = 50 + Intelligence * 10;
            Health = MaxHealth;
            Mana = MaxMana;
        }

        public void IncreaseExp(int exp)
        {
            Experience += exp;
            if (Experience >= LevelCup)
            {
                Experience -= LevelCup;
                StatsUp();
            }
        }

        public void IncreaseMoney(int money) => Gold += money;
        public bool BuyWithMoney(int cost) 
        {
            if (Gold >= cost)
            {
                Gold -= cost;
                return true;
            }
            else
            {
                MessageBox.Show("Недостаточно денег!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }


        public void DecreaseHealth(int toDecrease)
        {
            if (Health - toDecrease <= 0)
            {
                Health = 0;
                saveLoadService.MarkPlayerAsDead();
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += (s, e) => { timer.Stop(); timer.Dispose(); Application.Restart(); };
                MySoundPlayer.PlayDeadSound();
                timer.Start();
            }
            else { Health -= toDecrease; }
        }
        public bool UseMana(int toDecrease)
        {
            if (Mana - toDecrease < 0) {MessageBox.Show($"Недостаточно маны!\n требуеться {toDecrease} маны", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error); return false; }
            else {Mana -= toDecrease; return true; }
        }

        public void Heal(int toHeal) => Health = Math.Min(MaxHealth, Health + toHeal);
        public void HealMana(int toHeal) => Mana = Math.Min(MaxMana, Mana + toHeal);

        public void UseHealPotion() 
        {
            if (HealPotion > 0)
            {
                HealPotion--;
                Heal(MaxHealth / 4);
                MessageBox.Show("Зелье использовано\n+25% здоровья", "Sucess", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Недостаточно Зелий!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }
        public void UseManaPotion()
        {
            if (ManaPotion > 0)
            {
                ManaPotion--;
                HealMana(MaxMana / 4);
                MessageBox.Show("Зелье использовано\n+25% маны", "Sucess", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Недостаточно Зелий!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}

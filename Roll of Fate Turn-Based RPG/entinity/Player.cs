using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArmorClass;
using EnemyClass;
using WeaponClass;

namespace PlayerClass
{

    public class Player
    {
        Random random = new Random();

        public string Name = "";

        public int Level = 1;
        public int LevelCup = 100;
        public int Experience = 0;

        public int Health = 100;
        public int MaxHealth = 100;
        public int Mana = 50;
        public int MaxMana = 50;

        public int Strength = 0;
        public int Endurance = 0;
        public int Agility = 0;
        public int Intelligence = 0;

        public double CriticalChance = 0;
        public double AvoidChance = 0;

        public int Gold = 0;

        public Weapon Weapon = new Weapon();
        public Armor Armor = new Armor();


        public Player()
        {
            this.Health = this.MaxHealth;
            this.Mana = this.MaxMana;
            this.CriticalChance = this.Agility;
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


        public int CalculateAttackPower()
        { return this.Strength * 5 + Weapon.GetAttackBonus(); }

        public int CalculateDefense()
        { return this.Strength * 3 + Armor.GetDefenseBonus(); }

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
                damage = Math.Max(0, damage - CalculateDefense());
                if (Health - damage > 0) { Health -= damage; }
                else { Health = 0; MessageBox.Show("Ви умерли!", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        public void GetExp(int exp)
        {
            Experience += exp;
            if (Experience >= LevelCup)
            {
                Experience -= LevelCup;
                StatsUp();
            }
        }

        public void GetMoney(int money) => Gold += money;
        public bool DecreaseMoney(int cost) 
        {
            if (Gold >= cost)
            {
                Gold -= cost;
                return true;
            }
            else
            { 
                return false; 
            }
        }

    }
}

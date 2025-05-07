using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmorClass;
using WeaponClass;

namespace PlayerClass
{
    public class Player
    {
        public string Name = "";

        public int Level = 0;
        public int LevelCup = 100;
        public int Experience = 0;

        public int Strength = 0;
        public double CriticalChance = 0;

        public int Endurance = 0;
        public int Agility = 0;
        public int Intelligence = 0;

        public int Health = 0;
        public int MaxHealth = 10;
        public int Mana = 0;
        public int MaxMana = 5;

        public int Gold = 0;
        
        Weapon Weapon = new Weapon();
        Armor Armor = new Armor();


        public Player()
        {
            this.Health = this.MaxHealth;
            this.Mana = this.MaxMana;
            this.CriticalChance = this.Agility * 0.5;
        }

        public double CalculateCriticalChance()
            {this.CriticalChance = this.Agility * 0.5 ;
            return this.CriticalChance; }
        public int CalculateAttackPower()
        { return this.Strength + Weapon.GetAttackBonus();}

        public int CalculateDefense()
        {return this.Strength + Armor.GetDefenseBonus();}

    }
}

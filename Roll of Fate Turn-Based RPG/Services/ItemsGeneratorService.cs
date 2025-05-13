using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmorClass;
using BloodthirstyScytheW;
using BloodyShardW;
using CryOfGhostsW;
using CursedFangW;
using FlamingBladeW;
using HugeSwordW;
using IceBladeW;
using PlayerClass;
using ShadowDaggerW;
using StaffOfLightW;
using ThunderRiftW;
using WeaponClass;

namespace ItemsGeneratorNameSpace
{
    public class ItemsGeneratorService
    {
        Random random = new Random();

        List<string> ArmorNames = new List<string>{
            "Доспехи Алого Жнеца",
            "Кровавый Плащь",
            "Мантия Скорбящих Душ",
            "Доспехи Осквернённого Зверя",
            "Накидка Пламенной Ярости",
            "Колосальные Титановые Латы",
            "Доспехи Вечного Мороза",
            "Одеяние Небесного Защитника",
            "Громовая Мантия",
            "Тёмная Мантия Бездны"};

        List<Weapon> weapons = new List<Weapon> {
        new BloodthirstyScythe(),
        new BloodyShard(),
        new CryOfGhosts(),
        new CursedFang(),
        new FlamingBlade(),
        new HugeSword(),
        new IceBlade(),
        new ShadowDagger(),
        new StaffOfLight(),
        new ThunderRift()};

        public Armor ArmorGenerator(Player player) 
        {
        Armor armor = new Armor();
            int multy = random.Next(1, 4);
            armor.Price = 0;//multy * player.Level * random.Next(20, 61);
            armor.DefenseBonus = multy * player.Level * random.Next(2, 6);
            armor.Name = ArmorNames[random.Next(0, ArmorNames.Count)];

            return armor;
        }

        public Weapon WeaponGenerator(Player player)
        {
            Weapon weapon = weapons[random.Next(0, weapons.Count)];
            int StarterPrice = random.Next(2, 5);
            weapon.Price = 0;// StarterPrice * player.Level * random.Next(20, 61);
            weapon.AttackBonus = StarterPrice * player.Level * random.Next(2, 6);
            return weapon;
        }
    }
}

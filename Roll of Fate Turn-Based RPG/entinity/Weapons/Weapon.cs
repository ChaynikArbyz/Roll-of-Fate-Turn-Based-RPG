using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using System.Text.Json.Serialization;
using WoodenStickW;
using BloodyShardW;
using CursedFangW;
using StaffOfLightW;
using ShadowDaggerW;
using CryOfGhostsW;
using ThunderRiftW;
using BloodthirstyScytheW;
using FlamingBladeW;
using IceBladeW;
using HugeSwordW;

namespace WeaponClass
{
    //не забывать добавлять сюда подклассы для рабочей загрузки сейва
    [JsonDerivedType(typeof(WoodenStick), "WoodenStick")]

    [JsonDerivedType(typeof(BloodyShard), "BloodyShard")]
    [JsonDerivedType(typeof(CursedFang), "CursedFang")]
    [JsonDerivedType(typeof(StaffOfLight), "StaffOfLight")]
    [JsonDerivedType(typeof(ShadowDagger), "ShadowDagger")]
    [JsonDerivedType(typeof(CryOfGhosts), "CryOfGhosts")]
    [JsonDerivedType(typeof(ThunderRift), "ThunderRift")]
    [JsonDerivedType(typeof(BloodthirstyScythe), "BloodthirstyScythe")]
    [JsonDerivedType(typeof(FlamingBlade), "FlamingBlade")]
    [JsonDerivedType(typeof(IceBlade), "IceBlade")]
    [JsonDerivedType(typeof(HugeSword), "HugeSword")]

    public abstract class Weapon
    {
        public abstract string Name { get; }
        public abstract string AbilityDescription { get; }
        public abstract int Price { get; set; }
        public abstract int AttackBonus { get; set; }

        public abstract bool UseAbility(Player player, Enemy enemy);
    }
}

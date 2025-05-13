using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace StaffOfLightW
{
    public class StaffOfLight : Weapon
    {
        public override string Name => "Посох Света";
        public override string AbilityDescription => "Атака + Атака игнорирующая 20% защиты";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 9;


        public override bool UseAbility(Player player, Enemy enemy)
        {
            if (player.UseMana(100))
            {
                enemy.TakeDamage(player, 100);
                enemy.TakeDamageWithPercentDefence(player, 100, 80);
                return true;
            }
            return false;

        }
    }
}


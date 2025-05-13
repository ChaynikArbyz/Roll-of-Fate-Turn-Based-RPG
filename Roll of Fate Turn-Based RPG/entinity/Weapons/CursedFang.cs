using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace CursedFangW
{
    public class CursedFang : Weapon
    {
        public override string Name => "Проклятый Клык";
        public override string AbilityDescription => "Атака + Атака с 20% урона";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 15;


        public override bool UseAbility(Player player, Enemy enemy)
        {
            if (player.UseMana(100))
            {
                enemy.TakeDamage(player, 100);
                enemy.TakeDamage(player, 20);
                return true;
            }
            return false;

        }
    }
}


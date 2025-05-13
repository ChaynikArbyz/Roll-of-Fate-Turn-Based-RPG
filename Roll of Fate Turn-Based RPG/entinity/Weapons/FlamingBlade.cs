using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace FlamingBladeW
{
    public class FlamingBlade : Weapon
    {
        public override string Name => "Пылающий Клинок";
        public override string AbilityDescription => "Атака с 130% урона но вы теряете здоровья от 20% урона атаки";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 15;


        public override bool UseAbility(Player player, Enemy enemy)
        {
            if (player.UseMana(100)) { player.DecreaseHealth(enemy.TakeDamage(player, 130) / 5);return true; }
            return false;

        }
    }
}

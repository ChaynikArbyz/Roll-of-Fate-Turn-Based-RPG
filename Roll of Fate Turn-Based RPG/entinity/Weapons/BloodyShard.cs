using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace BloodyShardW
{
    public class BloodyShard : Weapon
    {
        public override string Name => "Кровавый Осколок";
        public override string AbilityDescription => "Атака с исцелением здоровья от 25% урона";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 20;


        public override void UseAbility(Player player, Enemy enemy)
        {
            player.UseMana(100);
            player.Heal(enemy.TakeDamage(player,100)/4);
        }
    }
}

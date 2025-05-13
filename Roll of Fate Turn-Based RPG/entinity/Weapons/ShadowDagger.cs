using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace ShadowDaggerW
{
    public class ShadowDagger : Weapon
    {
        public override string Name => "Теневой Кинжал";
        public override string AbilityDescription => "Атака с исцелением здоровья от 10% урона атаки + Атака игнорирующая 50% защиты врага+ Атака с 50% урона";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 7;


        public override void UseAbility(Player player, Enemy enemy)
        {
            player.UseMana(100);
            player.Heal(enemy.TakeDamage(player,100)/10);
            enemy.TakeDamageWithPercentDefence(player,100,50);
            enemy.TakeDamage(player,50);
        }
    }
}

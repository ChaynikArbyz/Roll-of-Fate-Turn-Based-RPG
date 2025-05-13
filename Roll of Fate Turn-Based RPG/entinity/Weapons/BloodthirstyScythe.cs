using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace BloodthirstyScytheW
{
    public class BloodthirstyScythe : Weapon
    {
        public override string Name => "Кровожадная Коса";
        public override string AbilityDescription => "Атака с 100% исцелением от урона если у врага меньше 10% здоровья";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 15;


        public override void UseAbility(Player player, Enemy enemy)
        {
            player.UseMana(200);
            if (enemy.Health <= enemy.MaxHealth / 10) { player.Heal(enemy.TakeDamage(player, 100)); }
            else { enemy.TakeDamage(player, 100); }
        }
    }
}

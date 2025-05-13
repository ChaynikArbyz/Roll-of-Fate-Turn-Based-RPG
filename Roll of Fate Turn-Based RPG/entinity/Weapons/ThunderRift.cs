using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace ThunderRiftW
{
    public class ThunderRift : Weapon
    {
        Random random = new Random();
        public override string Name => "Громовой Разлом";
        public override string AbilityDescription => "Атака игнорирующая 20% защиты + 25% шанс оглушить врага";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 11;


        public override void UseAbility(Player player, Enemy enemy)
        {
            player.UseMana(150);
            int chance = random.Next(1,5);
            if (chance == 1 & enemy.skipTurn < 1) { enemy.skipTurn++; }
            enemy.TakeDamageWithPercentDefence(player, 100, 80);
        }
    }
}

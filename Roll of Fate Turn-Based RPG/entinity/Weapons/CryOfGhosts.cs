using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace CryOfGhostsW
{
    public class CryOfGhosts : Weapon
    {
        Random random = new Random();
        public override string Name => "Плач Призраков";
        public override string AbilityDescription => "Атака + 50% шанс оглушить врага";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 13;


        public override void UseAbility(Player player, Enemy enemy)
        {
            player.UseMana(150);
            int chance = random.Next(1,3);
            if (chance == 1 & enemy.skipTurn < 1) { enemy.skipTurn++; }
            enemy.TakeDamage(player, 100);
        }
    }
}

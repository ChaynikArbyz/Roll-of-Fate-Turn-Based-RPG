using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace IceBladeW
{
    public class IceBlade : Weapon
    {
        Random random = new Random();
        public override string Name => "Ледяной Клинок";
        public override string AbilityDescription => "Атака + Атака с исцилением здоровья от 50% урона + 50% шанс оглушить врага";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 6;


        public override bool UseAbility(Player player, Enemy enemy)
        {
            if (player.UseMana(150))
            {
                int chance = random.Next(1, 3);
                if (chance == 1 & enemy.skipTurn < 1) { enemy.skipTurn++; }
                enemy.TakeDamage(player, 100);
                player.Heal(enemy.TakeDamage(player, 100) / 2);
                return true;
            }
            return false;

        }
    }
}

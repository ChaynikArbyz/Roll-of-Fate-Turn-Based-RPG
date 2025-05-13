using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace HugeSwordW
{
    public class HugeSword : Weapon
    {
        public override string Name => "Огромный меч";
        public override string AbilityDescription => "Атака игнорирующая 99% защиты врага";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 18;


        public override void UseAbility(Player player, Enemy enemy)
        {
            player.UseMana(250);
            enemy.TakeDamageWithPercentDefence(player,100,1);
        }
    }
}

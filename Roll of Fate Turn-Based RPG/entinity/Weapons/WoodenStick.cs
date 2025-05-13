using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;
using WeaponClass;

namespace WoodenStickW
{
    public class WoodenStick : Weapon
    {

        public override string Name => "Деревянная Палка";
        public override string AbilityDescription => "Исцеляет... 1 здоровье";
        public override int Price { get; set; } = 0;
        public override int AttackBonus { get; set; } = 3;

        
        public override bool UseAbility(Player player, Enemy enemy)
        {
            if (player.UseMana(100))
            {
                player.Heal(1);
                return true;
            }
            return false;

        }
    }
}

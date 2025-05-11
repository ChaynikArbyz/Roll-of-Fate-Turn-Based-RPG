using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using EnemyClass;
using PlayerClass;

namespace WeaponClass
{
    public class Weapon
    {
        public string Name = "";
        public string AbilityDescription = "";
        public int Price = 0;
        int AttackBonus = 0;

        public int GetAttackBonus()
        { return this.AttackBonus; }
        public virtual void UseAbility(Player player, Enemy enemy)
        { }
    }
}

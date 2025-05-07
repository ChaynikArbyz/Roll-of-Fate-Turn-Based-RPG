using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClass
{
    public class Weapon
    {
        string Name = "";
        int Price = 0;
        int AttackBonus = 0;

        public int GetAttackBonus()
        { return this.AttackBonus; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmorClass
{
    public class Armor
    {
        string Name = "";
        int Price = 0;
        int DefenseBonus = 0;

        public int GetDefenseBonus()
        { return this.DefenseBonus; }

    }
}

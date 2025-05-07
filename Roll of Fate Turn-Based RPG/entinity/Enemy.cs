using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemy
{
    public class Enemy
    {
        string Name = "";

        int Level = 0;
        int Attack = 0;
        int Defense = 0;

        int Health = 0;
        int MaxHealth = 10;

        int RewardGold = 0;
        int RewardXp = 0;

        Enemy() { this.Health = this.MaxHealth; }

        void AddHealth(int addingHealth)
        {
            if (this.Health + addingHealth >= MaxHealth)
            { this.Health = this.MaxHealth; }
            else { this.Health += addingHealth; }
        }

    }
}

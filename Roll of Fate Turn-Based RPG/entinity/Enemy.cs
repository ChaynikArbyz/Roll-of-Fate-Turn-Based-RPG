using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerClass;

namespace EnemyClass
{
    public class Enemy
    {
        Random random = new Random();
        List<string> names = new List<string>() {"Скелет","Зомби","Вор","Разбойник","Бандит","Орг","Гоблин","Призрак"};
        
        public string Name = "";

        public int Level = 0;

        public int Defence = 0;
        public int Health = 0;
        public int MaxHealth = 50;

        int RewardGold = 0;
        int RewardXp = 0;

        public int skipTurn = 0;
        public Enemy(Player player)
        {
            if (player.Level >= 5) { Level = random.Next(player.Level - 3, player.Level + 4); }
            else { Level = random.Next(1,4); }

            Defence = (int)(Level * random.Next(0, 7));
            MaxHealth = random.Next(15 * Level, 70 * Level + 1);
            RewardGold = random.Next(5 * Level, 20 * Level + 1);
            RewardXp = random.Next(40 * Level, 110 * Level + 1);

            this.Health = this.MaxHealth;
            Name = names[random.Next(names.Count)];
            
        }

        public void DealDamage(Player player)
        {
            if (skipTurn <= 0) { player.TakeDamage(random.Next(Level * 10, Level * 30)); }
            else { skipTurn--; }
        }

        public int TakeDamage(Player player, int percentDamage) 
        {
            int PlrDealingDamage = player.DealingDamage() / 100 * percentDamage;
            int damage = Math.Max(0, PlrDealingDamage - Defence);
            if (Health > damage)
                {
                Health -= damage;
                }
            else 
                {
                Health = 0;
                player.IncreaseMoney(RewardGold);
                player.IncreaseExp(RewardXp);
            }
            return PlrDealingDamage;
        }

        public int TakeDamageWithPercentDefence(Player player, int percentDamage, int percentDef)
        {
            int PlrDealingDamage = player.DealingDamage() / 100 * percentDamage;
            int damage = Math.Max(0, PlrDealingDamage - (Defence / 100 * percentDef));
            if (Health > damage)
            {
                Health -= damage;
            }
            else
            {
                Health = 0;
                player.IncreaseMoney(RewardGold);
                player.IncreaseExp(RewardXp);
            }
            return PlrDealingDamage;
        }
    }
}

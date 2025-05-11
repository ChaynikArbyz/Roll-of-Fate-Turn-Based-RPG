using System;
using System.Collections.Generic;
using System.Linq;
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

        public Enemy(Player player)
        {
            if (player.Level >= 5) { Level = random.Next(player.Level - 3, player.Level + 4); }
            else { Level = random.Next(1,4); }

            Defence = (int)(Level * random.NextDouble()* 3);
            MaxHealth = random.Next(15 * Level, 50 * Level + 1);
            RewardGold = random.Next(5 * Level, 20 * Level + 1);
            RewardXp = random.Next(40 * Level, 110 * Level + 1);

            this.Health = this.MaxHealth;
            Name = names[random.Next(names.Count)];
            
        }

        public void DealDamage(Player player)
        {
            player.TakeDamage(random.Next(Level * 10, Level * 30));
        }

        public void TakeDamage(Player player) 
        {
            int damage = Math.Max(0, player.DealingDamage() - Defence);
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
        }

    }
}

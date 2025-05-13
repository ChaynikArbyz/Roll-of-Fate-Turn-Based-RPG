using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerClass;
using WoodenStickW;

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

        public int RewardGold = 0;
        public int RewardXp = 0;

        public int skipTurn = 0;
        public Enemy(Player player)
        {
            if (player.Level >= 5) { Level = random.Next(player.Level - 3, player.Level + 4); }
            else { Level = 1; }

            Defence = (int)(Level * random.Next(0, 7));
            MaxHealth = random.Next(15 * Level, 70 * Level + 1);
            RewardGold = random.Next(5 * Level, 20 * Level + 1);
            RewardXp = random.Next(40 * Level, 110 * Level + 1);

            this.Health = this.MaxHealth;
            Name = names[random.Next(names.Count)];
            
        }

        public void DealDamage(Player player)
        {
            if (skipTurn <= 0) {
                if (player.isBlocking) { player.TakeDamage(random.Next(Level * 5, Level * 25) / 2); player.isBlocking = false; }
                else { player.TakeDamage(random.Next(Level * 5, Level * 25)); }
            }
            else { skipTurn--; }
        }

        public int TakeDamage(Player player, int percentDamage)
        {
            if (percentDamage <= 0)
            {
                throw new ArgumentException("percentDamage должен быть больше 0");
            }

            int PlrDealingDamage = (int)((player.DealingDamage() / 100.0) * percentDamage);
            int damage = Math.Max(0, PlrDealingDamage - Defence);

            if (this.Health > damage)
            {
                this.Health -= damage;
            }
            else
            {
                this.Health = 0;
            }

            return PlrDealingDamage;
        }
        public int TakeDamageWithPercentDefence(Player player, int percentDamage, int percentDef)
        {
            if (percentDamage <= 0)
            {
                throw new ArgumentException("percentDamage должен быть больше 0");
            }
            if (percentDef < 0)
            {
                throw new ArgumentException("percentDef не может быть меньше 0");
            }

            int PlrDealingDamage = (int)((player.DealingDamage() / 100.0) * percentDamage);

            int effectiveDefence = (int)((Defence / 100.0) * percentDef);
            int damage = Math.Max(0, PlrDealingDamage - effectiveDefence);

            if (this.Health > damage)
            {
                this.Health -= damage;
            }
            else
            {
                this.Health = 0;
            }

            return PlrDealingDamage;
        }


    }
}

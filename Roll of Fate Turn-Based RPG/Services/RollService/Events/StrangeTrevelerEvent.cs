using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace StrangeTrevelerE
{
    public class StrangeTrevelerEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        Random random = new Random();
        public override void ApplyEvent(Player player)
        {
            int potionType = random.Next(1, 3);
            string potionName;

            if (potionType == 1) { potionName = "зелье здоровья"; }
            else { potionName = "зелье маны"; }

            int cost = 0;
            if (player.Gold >= 100) { cost = random.Next(player.Gold / 20, player.Gold / 10 + 1); }
            else { cost = random.Next(1, 81); }

                DialogResult result = MessageBox.Show($"Ви встретили страствующего торговца\nОн предлагает купить у него {potionName} за {cost}\nКупить {potionName} за {cost}?", "Торговец", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (result == DialogResult.Yes)
            {
                if (potionType == 1)
                {
                    if (player.BuyWithMoney(cost)) { player.HealPotion++; messageService.GoodMessage("+1 Зелье здоровья"); }

                }
                else
                {
                    if (player.BuyWithMoney(cost)) { player.ManaPotion++; messageService.GoodMessage("+1 Зелье маны"); }
                }
            }
        }
    }
}

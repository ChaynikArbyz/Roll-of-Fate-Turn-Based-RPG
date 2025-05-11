using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace HealthPotionE
{
    public class HealthPotionEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            player.HealPotion++;
            messageService.GoodMessage("Вы нашли Зелье здоровья!\n+1 Зелье здоровья");
        }
    }
}

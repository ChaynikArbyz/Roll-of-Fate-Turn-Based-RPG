using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace GoldFoundE
{
    public class GoldFoundEvent : BaseEvent
    {
        Random random = new Random();
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            int toAdd;
            if (player.Gold >= 100)
            {
                toAdd = player.Gold / random.Next(1,11);
            }
            else { toAdd = random.Next(1,51); }

            player.IncreaseMoney(toAdd);
            messageService.GoodMessage($"Вы нашли кем-то потерянное золото\n+{toAdd} золота");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace TrapE
{
    public class TrapEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            player.TakeDamage(player.MaxHealth/5);
            messageService.BadMessage($"Вы попали в капкан!\nВам удалось выбраться но вы потеряли 20% здоровья\n-{player.MaxHealth/5} здоровья");
        }
    }
}

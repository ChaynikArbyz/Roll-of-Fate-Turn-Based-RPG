using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace AcidBerryE
{
    public class AcidBerryEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            player.TakeDamage(player.MaxHealth/10);
            messageService.BadMessage($"Вы находите куст с ягодами и решаете попробовать парочку\nЯгоды оказались ядовитыми!\n-10% здоровья");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace RoberyE
{
    public class RoberyEvent : BaseEvent
    {
        Random random = new Random();
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            int toSteal = random.Next(player.Gold/10,player.Gold + 1);
            player.Gold -= Math.Max(0, toSteal);
            messageService.BadMessage($"Вы спокойно шли по тропинке как из кустов выпригивает вор и ухватывает часть вашего золота!\n-{toSteal} золота");
        }
    }
}

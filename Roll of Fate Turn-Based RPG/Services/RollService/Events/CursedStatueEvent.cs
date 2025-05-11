using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace CursedStatueE
{
    public class CursedStatueEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            player.AddStrength(-1);
            player.AddEndurance(-1);
            messageService.BadMessage($"Вы натыкаетесь на древнюю статую с древними символами\n Когда вы приблизились, из неё вылетела волна тьмы, ослабляющая вас\nВы чуствуeте как силы покидают вас...\n-1 силы\n-1 выносливости");
        }
    }
}

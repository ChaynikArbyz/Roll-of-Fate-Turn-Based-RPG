using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace FreeManaE
{
    public class FreeManaEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            player.HealMana(player.MaxMana);
            messageService.GoodMessage("Вы нашли таинственный колодец и решили попыть с него\nМагический колодец востановил всю вашу ману!\n+100% к мане");
        }
    }
}
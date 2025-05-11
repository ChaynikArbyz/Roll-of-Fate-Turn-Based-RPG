using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace IntelligenceStoneE
{
    public class IntelligenceStoneEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            player.AddIntelligence(2);
            messageService.GoodMessage("Вы нашли таинственный камень и решили его подобрать\nКамень одарил вас интелектом!\n+2 к интелекту");
        }
    }
}

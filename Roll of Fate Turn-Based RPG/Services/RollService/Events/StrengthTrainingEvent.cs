using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseE;
using MesService;
using PlayerClass;

namespace StrengthTrainingE
{
    public class StrengthTrainingEvent : BaseEvent
    {
        MessageService messageService = new MessageService();
        public override void ApplyEvent(Player player)
        {
            player.AddStrength(1);
            messageService.GoodMessage("Вас переполняют силы, так что вы решили подкачаться!\n+1 к силе");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClass;

namespace BaseE
{
    public abstract class BaseEvent
    {
        public abstract void ApplyEvent(Player player);
    }
}

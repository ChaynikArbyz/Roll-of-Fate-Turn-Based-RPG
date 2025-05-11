using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesService
{
    public class MessageService
    {
        public void GoodMessage(string text) => MessageBox.Show(text,"Отлично",MessageBoxButtons.OK,MessageBoxIcon.None);

        public void BadMessage(string text) => MessageBox.Show(text, "Плохо", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

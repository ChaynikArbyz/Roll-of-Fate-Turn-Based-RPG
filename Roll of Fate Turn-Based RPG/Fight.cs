using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerClass;

namespace Roll_of_Fate_Turn_Based_RPG
{
    public partial class Fight : Form
    {
        Player player;
        public Fight(Player newPlayer)
        {
            InitializeComponent();
            player = newPlayer;
            MessageBox.Show("На вас напали!","Fight time!", MessageBoxButtons.OK);
            //ShowStats();
        }

        private void Fight_Load(object sender, EventArgs e)
        {

        }
    }
}

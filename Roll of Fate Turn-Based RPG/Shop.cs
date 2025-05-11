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
    public partial class Shop : Form
    {
        Player player;
        public Shop(Player newPlayer)
        {
            InitializeComponent();
            player = newPlayer;
            ShowGold();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(player);
            this.Close();
            form.Show();
        }

        void ShowGold()
        {
            goldLabel.Text = $"Золото: {player.Gold}";
        }

    }
}

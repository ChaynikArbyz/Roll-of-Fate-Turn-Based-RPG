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
    public partial class MainForm : Form
    {
        Player player;
        public MainForm(Player newPlayer)
        {
            InitializeComponent();
            player = newPlayer;
            ShowStats();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

        private void ShowStats()
        {
            nameLabel.Text = $"- {player.Name} -";
        }


        
    }
}

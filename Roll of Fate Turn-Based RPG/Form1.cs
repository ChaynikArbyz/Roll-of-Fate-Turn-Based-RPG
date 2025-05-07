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
    public partial class Form1 : Form
    {
        Player player;
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createButton.Visible = false;
            realCreateButton.Visible = true;
            nameBox.Visible = true;
            enterNameLabel.Visible = true;
        }

        private void realCreateButton_Click(object sender, EventArgs e)
        {
            player = new Player();
            player.Name = nameBox.Text;
            MainForm form = new MainForm(player);
            this.Hide();
            form.Show();
        }
    }
}

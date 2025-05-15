using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonService;
using MSPlayer;
using PlayerClass;

namespace Roll_of_Fate_Turn_Based_RPG
{
    public partial class Form1 : Form
    {
        Player player = new Player();

 
        
        SaveLoadService SLService = new SaveLoadService();
        public Form1()
        {
            InitializeComponent();
        }


        private void existsSave()
        {
            if (File.Exists("save.json"))
            { player = SLService.Load(); }
            else { loadButton.Enabled = false; }
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

        private void loadButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(SLService.Load());
            this.Hide();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySoundPlayer.PlayLoginMusic();
            existsSave();
            if (player.died)
            {
                player.died = false; 
                MessageBox.Show("Вы вернулись во времени", "Re:Zero reference", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SLService.Save(player);
            }
        }
    }
}

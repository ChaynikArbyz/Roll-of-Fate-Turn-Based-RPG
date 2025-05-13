using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemsGeneratorNameSpace;
using PlayerClass;
using WeaponClass;
using ArmorClass;
using MSPlayer;

namespace Roll_of_Fate_Turn_Based_RPG
{
    public partial class Shop : Form
    {
        Random random = new Random();
        ItemsGeneratorService generator = new ItemsGeneratorService();
        Player player;

        Weapon Lot1W = null;
        Weapon Lot2W = null;
        Weapon Lot3W = null;
        Weapon Lot4W = null;

        Armor Lot1A = null;
        Armor Lot2A = null;
        Armor Lot3A = null;
        Armor Lot4A = null;



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

        private void Shop_Load(object sender, EventArgs e)
        {
            MySoundPlayer.PlayShopMusic();
            GenerateItems();
            GeneratePotions();
        }




        void GenerateItems()
        {
            int LotType1 = random.Next(1,3);

            if (LotType1 == 1)
            {
                Lot1W = generator.WeaponGenerator(player);
                Lot1.Text = Lot1W.Name;
                DescriptionLot1.Text = $"Бонус к урону: {Lot1W.AttackBonus}\nСпособность: {Lot1W.AbilityDescription}";
                PriceLot1.Text = "Цена: " + Lot1W.Price;
            }
            else if (LotType1 == 2)
            {
                Lot1A = generator.ArmorGenerator(player);
                Lot1.Text = Lot1A.Name;
                DescriptionLot1.Text = $"Бонус к Защите: {Lot1A.DefenseBonus}";
                PriceLot1.Text = "Цена: " + Lot1A.Price;
            }

            int LotType2 = random.Next(3, 5);

            if (LotType2 == 3)
            {
                Lot2W = generator.WeaponGenerator(player);
                Lot2.Text = Lot2W.Name;
                DescriptionLot2.Text = $"Бонус к урону: {Lot2W.AttackBonus}\nСпособность: {Lot2W.AbilityDescription}";
                PriceLot2.Text = "Цена: " + Lot2W.Price;
            }
            else if (LotType2 == 4)
            {
                Lot2A = generator.ArmorGenerator(player);
                Lot2.Text = Lot2A.Name;
                DescriptionLot2.Text = $"Бонус к Защите: {Lot2A.DefenseBonus}";
                PriceLot2.Text = "Цена: " + Lot2A.Price;
            }

            int LotType3 = random.Next(5, 7);

            if (LotType3 == 5)
            {
                Lot3W = generator.WeaponGenerator(player);
                Lot3.Text = Lot3W.Name;
                DescriptionLot3.Text = $"Бонус к урону: {Lot3W.AttackBonus}\nСпособность: {Lot3W.AbilityDescription}";
                PriceLot3.Text = "Цена: " + Lot3W.Price;
            }
            else if (LotType3 == 6)
            {
                Lot3A = generator.ArmorGenerator(player);
                Lot3.Text = Lot3A.Name;
                DescriptionLot3.Text = $"Бонус к Защите: {Lot3A.DefenseBonus}";
                PriceLot3.Text = "Цена: " + Lot3A.Price;
            }

            int LotType4 = random.Next(7, 9);

            if (LotType4 == 7)
            {
                Lot4W = generator.WeaponGenerator(player);
                Lot4.Text = Lot4W.Name;
                DescriptionLot4.Text = $"Бонус к урону: {Lot4W.AttackBonus}\nСпособность: {Lot4W.AbilityDescription}";
                PriceLot4.Text = "Цена: " + Lot4W.Price;
            }
            else if (LotType4 == 8)
            {
                Lot4A = generator.ArmorGenerator(player);
                Lot4.Text = Lot4A.Name;
                DescriptionLot4.Text = $"Бонус к Защите: {Lot4A.DefenseBonus}";
                PriceLot4.Text = "Цена: " + Lot4A.Price;
            }


        }


        int Mlot1 = 0;
        int Mlot2 = 0;
        int Mlot3 = 0;
        int Mlot1Type = 0;
        int Mlot2Type = 0;
        int Mlot3Type = 0;
        int Mlot1Price = 0;
        int Mlot2Price = 0;
        int Mlot3Price = 0;

        void GeneratePotions()
        {

           Mlot1Type = random.Next(1, 3);
           Mlot2Type = random.Next(3, 5);
           Mlot3Type = random.Next(5, 7);
            Mlot1 = random.Next(1,11);
            Mlot2 = random.Next(1,11);
            Mlot3 = random.Next(1,11);
            Mlot1Price = Mlot1 * random.Next(1, 176);
            Mlot2Price = Mlot1 * random.Next(1, 176);
            Mlot3Price = Mlot1 * random.Next(1, 176);

            if (Mlot1Type == 1)
            {
                MiniLot1.Text = $"Зелье здоровья {Mlot1}x\nЦена:{Mlot1Price}";
            }
            else if (Mlot1Type == 2) 
            {
                MiniLot1.Text = $"Зелье маны {Mlot1}x\nЦена:{Mlot1Price}";
            }
            if (Mlot2Type == 3)
            {
                MiniLot2.Text = $"Зелье здоровья {Mlot2}x\nЦена:{Mlot2Price}";
            }
            else if (Mlot2Type == 4)
            {
                MiniLot2.Text = $"Зелье маны {Mlot2}x\nЦена:{Mlot2Price}";
            }
            if (Mlot3Type == 5)
            {
                MiniLot3.Text = $"Зелье здоровья {Mlot3}x\nЦена:{Mlot3Price}";
            }
            else if (Mlot3Type == 6)
            {
                MiniLot3.Text = $"Зелье маны {Mlot3}x\nЦена:{Mlot3Price}";
            }


        }
        private void BuyMiniLot1_Click(object sender, EventArgs e)
        { if (Mlot1Type == 1)
                if (player.BuyWithMoney(Mlot1Price) & !purchased5)
                {
                    player.HealPotion += Mlot1; ShowGold();
                    purchased5 = true; MiniLot1.Text = ""; BuyMiniLot1.Visible = false; MessageBox.Show("Успешно куплено!");
                } else { }
          else
          {
              if (player.BuyWithMoney(Mlot1Price) & !purchased5)
              {
                  player.ManaPotion += Mlot1; ShowGold();
                  purchased5 = true; MiniLot1.Text = ""; BuyMiniLot1.Visible = false; MessageBox.Show("Успешно куплено!");
              } else { }
          }
        }

        private void BuyMiniLot2_Click(object sender, EventArgs e)
        {
            {
                if (Mlot2Type == 3)
                    if (player.BuyWithMoney(Mlot2Price) & !purchased6)
                    {
                        player.HealPotion += Mlot2; ShowGold();
                        purchased6 = true; MiniLot2.Text = ""; BuyMiniLot2.Visible = false; MessageBox.Show("Успешно куплено!");
                    }
                    else { }
                else
                {
                    if (player.BuyWithMoney(Mlot2Price) & !purchased6)
                    {
                        player.ManaPotion += Mlot2; ShowGold();
                        purchased6 = true; MiniLot2.Text = ""; BuyMiniLot2.Visible = false; MessageBox.Show("Успешно куплено!");
                    }
                    else { }
                }
            }
        }

        private void BuyMiniLot3_Click(object sender, EventArgs e)
        {
            {
                if (Mlot3Type == 5)
                    if (player.BuyWithMoney(Mlot3Price) & !purchased7)
                    {
                        player.HealPotion += Mlot3; ShowGold();
                        purchased7 = true; MiniLot3.Text = ""; BuyMiniLot3.Visible = false; MessageBox.Show("Успешно куплено!");
                    }
                    else { }
                else
                {
                    if (player.BuyWithMoney(Mlot3Price) & !purchased7)
                    {
                        player.ManaPotion += Mlot3; ShowGold();
                        purchased7 = true; MiniLot3.Text = ""; BuyMiniLot3.Visible = false; MessageBox.Show("Успешно куплено!");
                    }
                    else { }
                }
            }
        }

        bool purchased1 = false;
        bool purchased2 = false;
        bool purchased3 = false;
        bool purchased4 = false;

        bool purchased5 = false;
        bool purchased6 = false;
        bool purchased7 = false;

        private void BuyLot1_Click(object sender, EventArgs e)
        {
            if (Lot1A == null)
            {
                if (player.BuyWithMoney(Lot1W.Price) & !purchased1) { player.Weapon = Lot1W; ShowGold();
                    purchased1 = true;Lot1.Text = "";DescriptionLot1.Text = ""; PriceLot1.Text = ""; BuyLot1.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
            else
            {
                if (player.BuyWithMoney(Lot1A.Price) & !purchased1) { player.Armor = Lot1A; ShowGold();
                    purchased1 = true; Lot1.Text = ""; DescriptionLot1.Text = ""; PriceLot1.Text = ""; BuyLot1.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
        }

        private void BuyLot2_Click(object sender, EventArgs e)
        {
            if (Lot2A == null)
            {
                if (player.BuyWithMoney(Lot2W.Price) & !purchased2) { player.Weapon = Lot2W; ShowGold();
                    purchased2 = true; Lot2.Text = ""; DescriptionLot2.Text = ""; PriceLot2.Text = ""; BuyLot2.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
            else
            {
                if (player.BuyWithMoney(Lot2A.Price) & !purchased2) { player.Armor = Lot2A; ShowGold();
                    purchased2 = true; Lot2.Text = ""; DescriptionLot2.Text = ""; PriceLot2.Text = ""; BuyLot2.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
        }

        private void BuyLot3_Click(object sender, EventArgs e)
        {
            if (Lot3A == null)
            {
                if (player.BuyWithMoney(Lot3W.Price) & !purchased3) { player.Weapon = Lot3W; ShowGold();
                    purchased3 = true; Lot3.Text = ""; DescriptionLot3.Text = ""; PriceLot3.Text = ""; BuyLot3.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
            else
            {
                if (player.BuyWithMoney(Lot3A.Price) & !purchased3) { player.Armor = Lot3A; ShowGold();
                    purchased3 = true; Lot3.Text = ""; DescriptionLot3.Text = ""; PriceLot3.Text = ""; BuyLot3.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
        }

        private void BuyLot4_Click(object sender, EventArgs e)
        {
            if (Lot4A == null)
            {
                if (player.BuyWithMoney(Lot4W.Price) & !purchased4) { player.Weapon = Lot4W; ShowGold();
                    purchased4 = true; Lot4.Text = ""; DescriptionLot4.Text = ""; PriceLot4.Text = ""; BuyLot4.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
            else
            {
                if (player.BuyWithMoney(Lot4A.Price) & !purchased4) { player.Armor = Lot4A; ShowGold();
                    purchased4 = true; Lot4.Text = ""; DescriptionLot4.Text = ""; PriceLot4.Text = ""; BuyLot4.Visible = false; MessageBox.Show("Успешно куплено!");
                }
            }
        }
    }
}

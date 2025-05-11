using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcidBerryE;
using BaseE;
using CursedStatueE;
using FreeManaE;
using GoldFoundE;
using HealthPotionE;
using IntelligenceStoneE;
using PlayerClass;
using RoberyE;
using Roll_of_Fate_Turn_Based_RPG;
using StrangeTrevelerE;
using StrengthTrainingE;
using TrapE;

namespace RollServ
{
    public class RollService
    {
         Random random = new Random();

        private List<BaseEvent> events = new List<BaseEvent>
        {
            new AcidBerryEvent(),
            new CursedStatueEvent(),
            new FreeManaEvent(),
            new GoldFoundEvent(),
            new HealthPotionEvent(),
            new IntelligenceStoneEvent(),
            new RoberyEvent(),
            new StrangeTrevelerEvent(),
            new StrengthTrainingEvent(),
            new TrapEvent()
        };

        public void RollRandom(Player player, MainForm mainForm)
        {
            int rollType = random.Next(1, 11);
            switch (rollType)
            {
                case 10:
                    NothingRolled(player);
                    break;
                case 9:
                    ShopRolled(player, mainForm);
                    break;
                case 8:
                case 7:
                case 6:
                    FightRolled(player);
                    break;
                default:
                    EventRolled(player);
                    break;
            }
        }

        private void NothingRolled(Player player)
        { MessageBox.Show("Поздравляем! Вы выкинули... ничего. Удачи в следующий раз", "Just Nothing",MessageBoxButtons.OK); }
        private void ShopRolled(Player player, MainForm mainForm)
        {
            DialogResult result = MessageBox.Show("Вы наткнулись на лавку торговца\nХотите посмотреть ассортимент?","Shop founded",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Shop form = new Shop(player);
                mainForm.Hide();
                form.Show();
            }
        }
        private void FightRolled(Player player)
        { }
        private void EventRolled(Player player) => events[random.Next(0, events.Count)].ApplyEvent(player);

    }
}

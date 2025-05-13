using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Roll_of_Fate_Turn_Based_RPG.Properties;

namespace MSPlayer
{
    public static class MySoundPlayer
    {
        static SoundPlayer Splayer = new SoundPlayer();

        public static void PlayDeadSound()
        {
            Splayer.Stop();
            Splayer.SoundLocation = "../../Resources/deadSound.wav";
            Splayer.Play();
        }
        public static void PlayLoginMusic()
        {
            Splayer.Stop();
            Splayer.SoundLocation = "../../Resources/LoginTheme.wav";
            Splayer.PlayLooping();
        }
        public static void PlayMainMusic()
        {
            Splayer.Stop();
            Splayer.SoundLocation = "../../Resources/MainTheme.wav";
            Splayer.PlayLooping();
        }
        public static void PlayShopMusic()
        {
            Splayer.Stop();
            Splayer.SoundLocation = "../../Resources/ShopTheme.wav";
            Splayer.PlayLooping();
        }
        public static void PlayBattleMusic()
        {
            Splayer.Stop();
            Splayer.SoundLocation = "../../Resources/FightTheme.wav";
            Splayer.PlayLooping();
        }

        public static void StopMusic() => Splayer.Stop();

    }
}

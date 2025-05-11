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

        static void PlayLoginMusic()
        {
            Splayer.Stop();
            //Splayer.SoundLocation = Resources.;
        }

        static void StopMusic() => Splayer.Stop();

    }
}

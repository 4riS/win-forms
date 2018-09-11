using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifnos1
{
    class music
    {
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public static bool isOn = false;

        public static void addPlayer()
        {
            player.SoundLocation = "nisi.wav";
        }

        public static void playMusic()
        {
            player.Play();
            isOn = true;
        }

        public static void stopMusic()
        {
            player.Stop();
            isOn = false;
        }
    }
}

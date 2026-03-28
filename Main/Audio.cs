using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessChatbot.Main
{
    internal class Audio
    {
        // Plays a greeting audio when the chatbot starts
        public static void GreetingAudio()
        {
            try
            {
                // Create a SoundPlayer object and loads the Greeting.wav audio file

                SoundPlayer player = new SoundPlayer("Assets/Greeting.wav");
                player.PlaySync();
            }
            catch
            {
                // Display an error message if the audio file cannot be found

                Console.WriteLine("Audio file not found.");
            }
        }

    }
}

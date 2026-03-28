using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessChatbot.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Displays the programs header
            UserInterface.Header();

            // Plays the greeting audio when the program starts

            Audio.GreetingAudio();
            // Displays the welcome message

            UserInterface.WelcomeMessage();

        }
    }
}

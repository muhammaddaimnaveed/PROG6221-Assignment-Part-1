using CybersecurityAwarenessChatbot.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessChatbot.Main
{
    internal class UserInterface
    {
        
        
            // Sets the text color for the ASCII Art header
            public static void Header()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(ASCII.Logo);
            Console.ResetColor();
        }


        // Sets the text color for the welcome message
        public static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(ASCII.WelcomeMessage);
            Console.ResetColor();
        }



    }
}

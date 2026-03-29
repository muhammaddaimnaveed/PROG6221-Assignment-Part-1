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

        // Formats and displays the user input
        public static void UserInput()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("You: ");
            Console.ResetColor();
        }

        // Formats and displays the chatbots response
        public static void ChatbotOutput(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Bot: ");
            Console.ResetColor();
            Console.WriteLine(message);
        }

        
        


    }
}

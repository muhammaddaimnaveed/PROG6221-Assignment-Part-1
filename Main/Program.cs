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

            // Requests users to enter their name 

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("[Bot]");
            Console.ResetColor();
            Console.Write(" Enter your name: ");
            string name = Console.ReadLine();

            UserInterface.ChatbotOutput($"Hello {name}! How can I assist you today?");

            // Displays a list of queries that users can ask the chatbot

            Chatbot.DisplayOptions();

            // Allows the user to interact with the chatbot

            Chatbot.LaunchChatbot();

        }
    }
}

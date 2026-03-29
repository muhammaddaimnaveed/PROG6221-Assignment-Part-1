using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityAwarenessChatbot.Main
{
    internal class Chatbot
    {
        public static void LaunchChatbot()
        {
            while (true)
            {
                UserInterface.UserInput();
                string input = Console.ReadLine();

                // Checks if the user input is empty

                if (string.IsNullOrWhiteSpace(input))
                {
                    UserInterface.ChatbotOutput("I didn’t quite understand that. Could you rephrase?");
                    continue;
                }

                // Converts user input to lowercase

                input = input.ToLower();

                // Checks if the user wants to exit the chatbot

                if (input == "exit")
                {
                    UserInterface.ChatbotOutput("Goodbye! Stay safe online.");
                    break;
                }

                // Handles user input by checking for specific keywords and responds with predefined chatbot answers that relate to the users questions

                else if (input.Contains("how are you"))
                {
                    UserInterface.ChatbotOutput("I'm doing great! I'm here to help you stay safe online.");
                }

                else if (input.Contains("purpose"))
                {
                    UserInterface.ChatbotOutput("My purpose is to educate you about cybersecurity and help you stay protected online.");
                }

                else if (input.Contains("what can i ask"))
                {
                    DisplayOptions();
                }

                else if (input.Contains("password safety"))
                {
                    UserInterface.ChatbotOutput("Password safety means creating strong, unique passwords and keeping them private to protect your accounts.");
                }

                else if (input.Contains("phishing"))
                {
                    UserInterface.ChatbotOutput("Phishing is when scammers trick you into giving your personal information through fake emails or websites.");
                }

                else if (input.Contains("safe browsing"))
                {
                    UserInterface.ChatbotOutput("Only visit trusted websites, avoid suspicious links, and look for HTTPS in the web address.");
                }

                else if (input.Contains("strong password"))
                {
                    UserInterface.ChatbotOutput("Use a mix of uppercase, lowercase, numbers, and symbols to create your password.");
                }

                else if (input.Contains("authentication"))
                {
                    UserInterface.ChatbotOutput("It is an extra layer of security where you use a second step, such as a code sent to your phone, to log in.");
                }

                else if (input.Contains("secure website"))
                {
                    UserInterface.ChatbotOutput("Check for HTTPS and a padlock icon in the browser.");
                }

                else if (input.Contains("personal information"))
                {
                    UserInterface.ChatbotOutput("Avoid sharing sensitive details, use strong passwords, and keep your accounts private and secure.");
                }
                
                else
                {
                    UserInterface.ChatbotOutput("I didn’t quite understand that. Could you rephrase?");
                }
            }
        }
   
        // Displays a set of questions that users can ask the chatbot
        public static void DisplayOptions()
        {
            UserInterface.ChatbotOutput("Select an Option:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║           CHATBOT OPTIONS           ║");
            Console.WriteLine("╠═════════════════════════════════════╣");
            Console.WriteLine("║ 1) How are you?                     ║");
            Console.WriteLine("║ 2) What is your purpose?            ║");
            Console.WriteLine("║ 3) What can I ask you?              ║");
            Console.WriteLine("║ 4) What is password safety?         ║");
            Console.WriteLine("║ 5) What is phishing?                ║");
            Console.WriteLine("║ 6) Safe browsing tips               ║");
            Console.WriteLine("║ 7) Strong password                  ║");
            Console.WriteLine("║ 8) Two-factor authentication        ║");
            Console.WriteLine("║ 9) Recognize secure website         ║");
            Console.WriteLine("║10) Protect personal information     ║");
            Console.WriteLine("║11) Type 'exit' to quit              ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Console.WriteLine("---------------------------------------");
        }

       
    }
}

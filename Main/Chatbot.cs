using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

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
                    UserInterface.ChatbotOutput("- I'm doing great! I'm here to help you stay safe online.");
                }

                else if (input.Contains("purpose"))
                {
                    UserInterface.ChatbotOutput("- My purpose is to educate you about cybersecurity and help you stay protected online.");
                }

                else if (input.Contains("what can i ask"))
                {
                    DisplayOptions();
                }

                else if (input.Contains("password safety"))
                {
                    UserInterface.ChatbotOutput("- Password safety means creating and managing passwords to protect your accounts from unauthorised access.\n\n      - This involes using a mix of uppercase, lowercase, numbers, and symbols to create your password.\n\n      - Avoid reusing same passwords across different accounts.\n\n      - Enable two-factor authentication for extra security.\n\n      - Keep passwords private and don’t share them with others. ");
                }

                else if (input.Contains("phishing"))
                {
                    UserInterface.ChatbotOutput("- Phishing is when scammers trick you into giving personal information such as your passwords or banking details.\n\n      - This happens through fake emails, messages, or websites that look legitimate.\n\n      - The goal is to steal your sensitive information and access your accounts.");
                }  

                else if (input.Contains("safe browsing"))
                {
                    UserInterface.ChatbotOutput("- Only visit trusted and secure websites.\n\n      - Avoid clicking on suspicious links or pop-ups.\n\n      - Keep your browser and software updated.\n\n      - Use strong passwords and enable two-factor authentication.\n\n      - Be careful when downloading files from the internet.");
                }

                else if (input.Contains("strong password"))
                {
                    UserInterface.ChatbotOutput("- Use a mix of uppercase, lowercase, numbers, and symbols to create your password.\n\n      - Use at least 12–16 characters.\n\n      - Avoid personal information.\n\n      - Don’t use common words or easy patterns.\n\n      - Use a unique password for each account.");
                }

                else if (input.Contains("authentication"))
                {
                    UserInterface.ChatbotOutput("- Two-factor authentication is a security method that requires two ways to verify your identity.\n\n      - This involves a second step such as a code sent to your phone to log in.\n\n      - This adds an extra layer of protection to your accounts.");
                }

                else if (input.Contains("secure website"))
                {
                    UserInterface.ChatbotOutput("- Check for HTTPS and a padlock icon in the browser.\n\n      - Avoid sites with warning messages about insecure connections.\n\n      - Trust websites with reputable domain names and official certificates.");
                }

                else if (input.Contains("personal information"))
                {
                    UserInterface.ChatbotOutput("- Share personal information only on trusted websites or with trusted people.\n\n      - Avoid posting sensitive details on social media.\n\n      - Use strong, unique passwords for each account.\n\n      - Enable two-factor authentication.");
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
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("╔═══════════════════════════════════════════════╗");
            Console.WriteLine("║                  CHATBOT OPTIONS              ║");
            Console.WriteLine("╠═══════════════════════════════════════════════╣");
            Console.WriteLine("║ 1) How are you?                               ║");
            Console.WriteLine("║ 2) What is your purpose?                      ║");
            Console.WriteLine("║ 3) What can I ask you?                        ║");
            Console.WriteLine("║ 4) What is password safety?                   ║");
            Console.WriteLine("║ 5) What is phishing?                          ║");
            Console.WriteLine("║ 6) How can I practice safe browsing?          ║");
            Console.WriteLine("║ 7) How do I create a strong password?         ║");
            Console.WriteLine("║ 8) What is two-factor authentication?         ║");
            Console.WriteLine("║ 9) How do I recognise a secure website?       ║");
            Console.WriteLine("║10) How can I protect my personal information? ║");
            Console.WriteLine("║11) Type 'exit' to quit                        ║");
            Console.WriteLine("╚═══════════════════════════════════════════════╝");
            Console.WriteLine("-------------------------------------------------");
        }

    }
}

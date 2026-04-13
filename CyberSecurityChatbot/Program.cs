using CyberSecurityChatbot;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";

        // Voice greeting (simulated due to VM limitations)
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Playing voice greeting... greeting.wav");
        Console.ResetColor();
        Thread.Sleep(1500);

        // ASCII ART HEADER
        DisplayAsciiArt();

        // Text-based greeting
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Hello! Welcome to the Cybersecurity Awareness Bot. I help you stay safe online and avoid cyber threats.");
        Console.ResetColor();

        // Get user name with validation
        Console.Write("Enter your name: "); 
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Please enter a valid name: ");
            name = Console.ReadLine();
        }

        ChatBot bot = new ChatBot(name);

        Console.Clear();

        // Welcome screen
        Console.ForegroundColor = ConsoleColor.Cyan;
        DisplayAsciiArt();
        Console.WriteLine($"Welcome {name}!");
        Console.WriteLine("You can ask me about phishing scams, password safety, and safe internet browsing.");
        Console.WriteLine("Type 'exit' to quit.");
        Console.WriteLine("====================================");
        Console.ResetColor();

        bot.GreetUser();

        // Chat loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: I didn’t quite understand that. Please rephrase.");
                continue;
            }

            string response = bot.GetResponse(input.ToLower());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bot: " + response);

            if (input.ToLower() == "exit")
                break;
        }
    }

    static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"
====================================
   CYBER SECURITY BOT
====================================
        ");
        Console.ResetColor();
    }
}

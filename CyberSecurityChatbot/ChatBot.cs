using System;

namespace CyberSecurityChatbot
{
    internal class ChatBot 
    {
    
        public string UserName { get; set; }

        public ChatBot(string name)
        {
            UserName = name;
        }

        public void GreetUser()
        {
            Console.WriteLine($"Hello {UserName}! I'm your Cybersecurity Assistant.");
            Console.WriteLine("You can ask me about passwords, phishing, or safe browsing.");
        }

        public string GetResponse(string input)
        {
            // Handles user input and returns cybersecurity-related responses
            if (input.Contains("how are you"))
                return "I'm functioning well and ready to help you stay safe online.";

            if (input.Contains("purpose"))
                return "My purpose is to educate you about cybersecurity and online safety.";

            if (input.Contains("password"))
                return "Always make sure to use strong passwords with a mix of letters, numbers, and symbols.";

            if (input.Contains("phishing"))
                return "Phishing scams trick you into giving personal information. Always verify emails.";

            if (input.Contains("safe browsing"))
                return "Avoid clicking on suspicious links and make sure websites are secure (https).";

            if (input.Contains("exit"))
                return "Goodbye! Stay safe online.";

            return "I didn’t quite understand that. Could you rephrase?";
        }
    }
}


using System;

namespace SecureNetAssistant
{
    public class Chatbot
    {
        private string name = "User";

        public void Run()
        {
            AskName();

            while (true)
            {
                ConsoleUI.UserPrompt();
                string input = Console.ReadLine();

                if (!InputValidator.Check(input))
                {
                    ConsoleUI.BotReply("Please type something so I can assist you.");
                    continue;
                }

                string response = ResponseHandler.Handle(input.ToLower(), name);

                ConsoleUI.BotReply(response);

                if (input.ToLower() == "exit")
                    break;
            }
        }

        private void AskName()
        {
            ConsoleUI.BotReply("Hello!");
            ConsoleUI.BotReply("I am your SecureNet Assistant, here to guide you on staying safe online.");
            ConsoleUI.BotReply("Please enter your name:");

            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
                name = input.Trim();

            ConsoleUI.BotReply($"Welcome, {name}! Feel free to ask me anything about cybersecurity.");
        }
    }
}
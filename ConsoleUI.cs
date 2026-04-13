using System;
using System.Threading;

namespace SecureNetAssistant
{
    public static class ConsoleUI
    {
        public static void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   _____                            _   _      _   
  / ____|                          | \ | |    | |  
 | (___   ___  ___ _   _ _ __ ___  |  \| | ___| |_ 
  \___ \ / _ \/ __| | | | '__/ _ \ | . ` |/ _ \ __|
  ____) |  __/ (__| |_| | | |  __/ | |\  |  __/ |_ 
 |_____/ \___|\___|\__,_|_|  \___| |_| \_|\___|\__|

        SECURE NET ASSISTANT
----------------------------------------------------
 Stay Safe | Stay Smart | Stay Protected
----------------------------------------------------
Type 'exit' anytime to quit
");

            Console.ResetColor();
        }

        public static void BotReply(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (char c in "Bot ➤ " + message)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public static void UserPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You ➤ ");
            Console.ResetColor();
        }
    }
}
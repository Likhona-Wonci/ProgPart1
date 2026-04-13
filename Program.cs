using SecureNetAssistant;

ConsoleUI.ShowHeader();
AudioPlayer.PlayGreeting();

var bot = new Chatbot();
bot.Run();
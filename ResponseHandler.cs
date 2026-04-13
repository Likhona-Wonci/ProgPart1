namespace SecureNetAssistant
{
    public static class ResponseHandler
    {
        public static string Handle(string input, string name)
        {
            if (input.Contains("how are you"))
                return $"I'm doing very well, {name}, thank you for asking. I'm here and ready to help you learn more about how to stay safe and secure while using the internet.";

            if (input.Contains("purpose"))
                return "My purpose is to provide you with useful knowledge about cybersecurity and help you understand how to protect your personal data, devices, and online accounts from potential threats.";

            if (input.Contains("what can i ask") || input.Contains("help"))
                return "You can ask me about important cybersecurity topics such as how to create strong passwords, how phishing scams work, and how to browse the internet safely without risking your personal information.";

            if (input.Contains("password"))
                return "A strong password should be long and complex, including a mix of uppercase letters, lowercase letters, numbers, and special characters. It is also very important not to reuse passwords across different accounts.";

            if (input.Contains("phishing"))
                return "Phishing is a common cyber attack where scammers attempt to trick you into revealing sensitive information by pretending to be a trustworthy source. Always double-check emails and links before clicking on them.";

            if (input.Contains("browsing"))
                return "Safe browsing means ensuring that you only visit secure websites that use HTTPS, avoiding suspicious downloads, and being cautious when clicking on links, especially from unknown sources.";

            if (input == "exit")
                return "It was great assisting you today. Goodbye, and remember to always stay safe online.";

            return $"I'm not sure I fully understood that, {name}. You can try asking me about passwords, phishing, or safe browsing, and I will gladly assist you.";
        }
    }
}
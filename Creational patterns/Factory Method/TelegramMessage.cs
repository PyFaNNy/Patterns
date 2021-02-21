using System;

namespace Factory_Method
{
    public class TelegramMessage : MessageBase
    {
        public TelegramMessage(string text, string source, string target) : base(text, source, target) { }
        public override void Send()
        {
            Console.WriteLine($"Telegram: Текст от @{Source} для @{Target}: {Text}");
        }
    }
}

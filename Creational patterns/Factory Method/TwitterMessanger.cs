using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class TwitterMessanger : MessangerBase
    {
        public TwitterMessanger(string name, string password) : base(name, password)
        {
        }
        public override bool Authorize()
        {
            Console.WriteLine($"Авторизация в Twitter пользователя с именем {UserName} и паролем {Password}");
            return true;
        }
        public override IMessage CreateMessage(string text, string source, string target)
        {
            var message = new TwitterMessage(text, source, target);
            return message;
        }
    }
}

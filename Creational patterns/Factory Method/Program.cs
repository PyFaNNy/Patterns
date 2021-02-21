namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {   
            Creator creator = new ConcreteCreator();
            IProduct product = creator.FactoryMethod();
            product.DoWork();

            var twitter = new TwitterMessanger("admin", "admin");
            var twit = twitter.CreateMessage("Hi, Bro!", "admin", "John Doe");
            twit.Send();

            var telegram = new TelegramMessanger("admin", "admin");
            var text = telegram.CreateMessage("Hi, Man!", "admin", "John Doe");
            text.Send();
        }
    }
}

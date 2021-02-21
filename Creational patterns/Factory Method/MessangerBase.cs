namespace Factory_Method
{
    public abstract class MessangerBase : IMessanger
    {
        public string UserName { get; }
        public string Password { get; }
        public bool Connected { get; }

        public MessangerBase(string name, string password)
        {
            if (!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = Authorize();
            }
            else
            {
                Connected = false;
            }
        }
        public abstract bool Authorize();
        public abstract IMessage CreateMessage(string text, string source, string target);
    }
}

using System;

namespace Strategy
{
    public class Сlient
    {
        private IStrategy _strategy;
        public Сlient(){ }
        public Сlient(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void DoWork()
        {
            if(_strategy != null)
            {
                Console.WriteLine(_strategy.DoWork());
            }
            else
            {
                Console.WriteLine("Стратегия не установлена");
            }
        }
    }
}

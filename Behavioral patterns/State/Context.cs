using System;

namespace State
{
    // Контекст определяет интерфейс, представляющий интерес для клиентов. Он
    // также хранит ссылку на экземпляр подкласса Состояния, который отображает
    // текущее состояние Контекста.
    public class Context
    {
        // Ссылка на текущее состояние Контекста.
        private State _state = null;

        public Context (State state)
        {
            this.TransitionTo(state);
        }
        // Контекст позволяет изменять объект Состояния во время выполнения.
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }
        public void Request1()
        {
            this._state.Handle1();
        }
        public void Request2()
        {
            this._state.Handle2();
        }
    }
}

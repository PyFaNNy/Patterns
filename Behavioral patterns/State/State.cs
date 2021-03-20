﻿namespace State
{
    // Базовый класс Состояния объявляет методы, которые должны реализовать все
    // Конкретные Состояния, а также предоставляет обратную ссылку на объект
    // Контекст, связанный с Состоянием. Эта обратная ссылка может
    // использоваться Состояниями для передачи Контекста другому Состоянию.
    public abstract class State
    {
        protected Context _context;
        public void SetContext(Context context)
        {
            this._context = context;
        }
        public abstract void Handle1();

        public abstract void Handle2();
    }
}

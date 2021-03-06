# Фабричный метод
Фабричный метод — это порождающий паттерн проектирования, который определяет общий интерфейс для создания объектов в суперклассе, позволяя подклассам изменять тип создаваемых объектов.
# Применимость
- Когда заранее неизвестны типы и зависимости объектов, с которыми должен работать ваш код.
- Когда вы хотите дать возможность пользователям расширять части вашего фреймворка или библиотеки.
- Когда вы хотите экономить системные ресурсы, повторно используя уже созданные объекты, вместо порождения новых.
# Преимущества и недостатки
- :white_check_mark: Избавляет класс от привязки к конкретным классам продуктов.
- :white_check_mark: Выделяет код производства продуктов в одно место, упрощая поддержку кода.
- :white_check_mark: Упрощает добавление новых продуктов в программу.
- :white_check_mark: Реализует принцип открытости/закрытости.
- :negative_squared_cross_mark: Может привести к созданию больших параллельных иерархий классов, так как для каждого класса продукта надо создать свой подкласс создателя.

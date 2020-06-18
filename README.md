# DiscountCard

Имплементация на Factory Method Pattern:
- Card - интерфейсът, който се използва за имплементирането на класовете на 3 вида карти за отстъпка
- BronzeCard, SilverCard, GoldCard - 3те класа, наследяващи интерфейса Card
- CardFactory - абстактен клас, осъществяващ фабриката
- BronzeCardFactory, SilverCardFactory, GoldCardFactory - трите класа, съфържащи създаващата функционалност на на класовете на 3те карти

Имплементация на Memento Pattern:
- Client - клас, съдържащ свойствата на клиента, включително и обект Card
- Memento - клас, съдържащ минало състояние на обект от класа Client
- Caretaker - клас, грижещ се за това да пази обект от класа Memento, без да го променя

Имплементация на Dependency Injection (Ninject)
- IClient - интерфейсът, имплементиран от класа Client, с цел да се изпълни написването на шаблона
- Bindings - тук се задава с кои класове да работи "Ninject"

// Использование нескольких универсальных параметров
using Example03;

Messenger<Message, Person> telegram = new Messenger<Message, Person>();
Person tom = new Person("Tom");
Person bob = new Person("Bob");
Message hello = new Message("Hello, Bob!");
telegram.SendMessage(tom, bob, hello);

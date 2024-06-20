// Сравнение на равенство
using Example02;

var person1 = new Person("Tom");
var person2 = new Person("Tom");
Console.WriteLine(person1.Equals(person2));
Console.WriteLine(person1 == person2);

var user1 = new User("Tom");
var user2 = new User("Tom");
Console.WriteLine(user1.Equals(user2));
Console.WriteLine(user1 == user2);

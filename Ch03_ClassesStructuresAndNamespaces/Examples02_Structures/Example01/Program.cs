// Копирование структуры с помощью with
using Example01;

Person tom = new Person { name = "Tom", age = 22 };
Person bob = tom with { name = "Bob" };
bob.Print();

// Наследование обобщенных типов
using Example01;

Person<string> person1 = new Person<string>("34");
Person<int> person2 = new Person<int>(45);
Person<int> person3 = new UniversalPerson<int>(45);
Console.WriteLine(person1.Id);
Console.WriteLine(person2.Id);
Console.WriteLine(person3.Id);

StringPerson person4 = new StringPerson("438767");
Person<string> person5 = new StringPerson("43875");
//Person<int> person6 = new StringPerson("45545");
Console.WriteLine(person4.Id);
Console.WriteLine(person5.Id);

IntPerson<string> person7 = new IntPerson<string>(5, "r4556");
Person<int> person8 = new IntPerson<long>(7, 4587);
Console.WriteLine(person7.Id);
Console.WriteLine(person8.Id);

MixedPerson<string, int> person9 = new MixedPerson<string, int>("456", 356);
Person<string> person10 = new MixedPerson<string, int>("9867", 35678);
Console.WriteLine(person9.Id);
Console.WriteLine(person10.Id);

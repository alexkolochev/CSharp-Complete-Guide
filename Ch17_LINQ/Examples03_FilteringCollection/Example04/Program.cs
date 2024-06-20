// Фильтрация по типу данных
using Example04;

var people = new List<Person>
{
    new Student("Tom"),
    new Person("Sam"),
    new Student("Bob"),
    new Employee("Mike")
};

var students = people.OfType<Student>();

foreach (var student in students)
    Console.WriteLine(student.Name);

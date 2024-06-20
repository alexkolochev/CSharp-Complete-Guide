// Метод Zip
using Example03;

List<Course> courses = [new("C#"), new("Java")];
List<Student> students = [new("Tom"), new("Bob")];

var enrollments = courses.Zip(students);

foreach (var enrollment in enrollments)
    Console.WriteLine($"{enrollment.First} - {enrollment.Second}");

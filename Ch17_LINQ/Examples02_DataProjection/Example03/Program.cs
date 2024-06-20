// Выборка из нескольких источников
using Example03;

var courses = new List<Course> { new("C#"), new("Java") };
var students = new List<Student> { new("Tom"), new("Bob") };

var enrollments = from course in courses
                  from student in students
                  select new { Student = student.Name, Course = course.Title };

foreach (var enrollment in enrollments)
    Console.WriteLine($"{enrollment.Student} - {enrollment.Course}");

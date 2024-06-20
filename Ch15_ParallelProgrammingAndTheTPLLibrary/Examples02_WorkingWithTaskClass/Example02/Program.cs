// Массив задач
Task[] tasks1 =
[
    new(() => Console.WriteLine("First Task")),
    new(() => Console.WriteLine("Second Task")),
    new(() => Console.WriteLine("Third Task"))
];

foreach (var task in tasks1)
    task.Start();

Task[] tasks2 = new Task[3];
int j = 1;
for (int i = 0; i < tasks2.Length; i++)
    tasks2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));

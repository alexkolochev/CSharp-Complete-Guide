Task task1 = new(() => Console.WriteLine($"Current Task: {Task.CurrentId}"));
Task task2 = task1.ContinueWith(t => Console.WriteLine($"Current Task: {Task.CurrentId}  Previous Task: {t.Id}"));
Task task3 = task2.ContinueWith(t => Console.WriteLine($"Current Task: {Task.CurrentId}  Previous Task: {t.Id}"));
Task task4 = task3.ContinueWith(t => Console.WriteLine($"Current Task: {Task.CurrentId}  Previous Task: {t.Id}"));

task1.Start();
task4.Wait();
Console.WriteLine("Конец метода Main");

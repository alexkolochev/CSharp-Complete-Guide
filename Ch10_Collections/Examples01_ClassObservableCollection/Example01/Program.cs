// Уведомление об измении коллекции
using Example01;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

var people = new ObservableCollection<Person>()
{
    new Person("Tom"),
    new Person("Sam")
};
people.CollectionChanged += PeopleCollectionChanged;

people.Add(new Person("Bob"));

people.RemoveAt(1);
people[0] = new Person("Eugene");

Console.WriteLine("\nСписок пользователей:");
foreach (var person in people)
{
    Console.WriteLine(person.Name);
}

void PeopleCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    switch (e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            if (e.NewItems?[0] is Person newPerson)
                Console.WriteLine($"Добавлен новый объект: {newPerson.Name}");
            break;
        case NotifyCollectionChangedAction.Remove:
            if (e.OldItems?[0] is Person oldPerson)
                Console.WriteLine($"Удален объект: {oldPerson.Name}");
            break;
        case NotifyCollectionChangedAction.Replace:
            if ((e.NewItems?[0] is Person replacingPerson) && (e.OldItems?[0] is Person replacedPerson))
                Console.WriteLine($"Объект {replacedPerson.Name} заменен объектом {replacingPerson.Name}");
            break;
    }
}
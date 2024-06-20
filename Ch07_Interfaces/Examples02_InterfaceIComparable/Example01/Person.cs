﻿namespace Example01
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person? other)
        {
            if (other is null)
                throw new ArgumentNullException("Некорректное значение параметра");

            return Name.CompareTo(other.Name);
            //return Age - other.Age;
        }
    }
}

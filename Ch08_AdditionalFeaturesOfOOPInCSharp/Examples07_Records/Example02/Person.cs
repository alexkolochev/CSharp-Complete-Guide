﻿namespace Example02
{
    internal record Person
    {
        public string Name { get; init; }

        public Person(string name) => Name = name;
    }
}

namespace Example02
{
    internal class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x is null || y is null)
                throw new NotImplementedException("Некорректное значение параметра");

            return x.Name.Length - y.Name.Length;
        }
    }
}

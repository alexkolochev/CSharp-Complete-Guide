namespace Example01
{
    internal class Company
    {
        private Person[] _personal;

        public Company(Person[] people) => _personal = people;

        public Person this[int index]
        {
            get
            {
                if (index >= 0 && index < _personal.Length)
                    return _personal[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < _personal.Length)
                    _personal[index] = value;
            }
        }
    }
}

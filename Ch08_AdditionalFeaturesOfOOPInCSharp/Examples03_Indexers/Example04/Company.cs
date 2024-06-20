namespace Example04
{
    internal class Company
    {
        private Person[] _personal;

        public Company(Person[] people)
        {
            _personal = people;
        }

        public Person this[int index]
        {
            get => _personal[index];
            set => _personal[index] = value;
        }

        public Person this[string name]
        {
            get
            {
                foreach (Person person in _personal)
                {
                    if (person.Name == name)
                        return person;
                }

                throw new Exception("Unknown name");
            }
        }
    }
}

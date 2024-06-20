namespace Example01
{
    internal class Company
    {
        private Person[] personnel;

        public int Length => personnel.Length;

        public Company(Person[] personnel) => this.personnel = personnel;

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < personnel.Length; i++)
                yield return personnel[i];
        }
    }
}

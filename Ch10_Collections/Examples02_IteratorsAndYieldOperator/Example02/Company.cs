namespace Example02
{
    internal class Company
    {
        private Person[] personnel;

        public int Length => personnel.Length;

        public Company(Person[] personnel) => this.personnel = personnel;

        public IEnumerable<Person> GetPersonnel(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == personnel.Length)
                    yield break;
                else
                    yield return personnel[i];
            }
        }
    }
}

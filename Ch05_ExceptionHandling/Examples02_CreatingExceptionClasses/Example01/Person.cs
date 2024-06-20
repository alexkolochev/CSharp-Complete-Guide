namespace Example01
{
    internal class Person
    {
        private int age;

        public string Name { get; set; } = string.Empty;

        public int Age
        { 
            get => age;
            set
            {
                if (value < 18)
                    throw new PersonException("Лицам до 18 регистрация запрещена", value);
                else
                    age = value;
            }
        }
    }
}

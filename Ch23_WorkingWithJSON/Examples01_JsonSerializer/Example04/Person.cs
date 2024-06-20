using System.Text.Json.Serialization;

namespace Example04
{
    internal class Person
    {
        [JsonPropertyName("firstname")]
        public string Name { get; }

        [JsonIgnore]
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

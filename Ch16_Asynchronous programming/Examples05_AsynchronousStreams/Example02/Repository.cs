namespace Example02
{
    internal class Repository
    {
        private string[] data = ["Tom", "Sam", "Kate", "Alice", "Bob"];

        public async IAsyncEnumerable<string> GetDataAsync()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Получаем {i + 1} элемент");
                await Task.Delay(1000);
                yield return data[i];
            }
        }
    }
}

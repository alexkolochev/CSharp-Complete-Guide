namespace Example01
{
    internal class Reader
    {
        private Lazy<Library> library = new Lazy<Library>();

        public void ReadBook()
        {
            library.Value.GetBook();
            Console.WriteLine("Читаем бумажную книгу");
        }

        public void ReadEBook()
        {
            Console.WriteLine("Читаем книгу на компьютере");
        }
    }
}

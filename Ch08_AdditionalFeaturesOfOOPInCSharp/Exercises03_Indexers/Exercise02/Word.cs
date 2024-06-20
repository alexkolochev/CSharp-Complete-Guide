namespace Exercise02
{
    internal class Word
    {
        public string Source { get; set; }
        public string Target { get; set; }

        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
}

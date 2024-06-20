namespace Exercise02
{
    internal class Dictionary
    {
        private Word[] _words;

        public Dictionary()
        {
            _words = [new Word("red", "красный"), new Word("blue", "синий"), new Word("green", "зеленый")];
        }

        public string this[string source]
        {
            get
            {
                foreach (var word in _words)
                {
                    if (word.Source == source)
                    {
                        return word.Target;
                    }
                }

                throw new Exception();
            }

            set
            {
                foreach(var word in _words)
                {
                    if (word.Source == source)
                    {
                        word.Target = value;
                        break;
                    }
                }
            }
        }
    }
}

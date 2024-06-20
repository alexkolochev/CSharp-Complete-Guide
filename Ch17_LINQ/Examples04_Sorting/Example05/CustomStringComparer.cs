namespace Example05
{
    internal class CustomStringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            int xLength = x?.Length ?? 0;
            int yLength = y?.Length ?? 0;
            return xLength - yLength;
        }
    }
}

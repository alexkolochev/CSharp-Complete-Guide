using System.Diagnostics.CodeAnalysis;

namespace Example03
{
    internal class CustomStringComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x is null || y is null) return false;
            return x.ToLower() == y.ToLower();
        }

        public int GetHashCode([DisallowNull] string obj) => obj.ToLower().GetHashCode();
    }
}

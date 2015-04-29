namespace AdapterPattern
{
    public class DefaultLibraryAdapter : ILibraryAdapter
    {
        public LegacyLibrary LegacyLibrary { get; set; }

        public DefaultLibraryAdapter(LegacyLibrary legacyLibrary)
        {
            LegacyLibrary = legacyLibrary;
        }

        public int Add(int x, int y)
        {
            int sum;
            LegacyLibrary.Add(x, y, out sum);
            return sum;
        }

        public int Subtract(int x, int y)
        {
            int diff;
            LegacyLibrary.Subtract(x, y, out diff);
            return diff;
        }
    }
}

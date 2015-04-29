namespace AdapterPattern
{
    public class LegacyLibrary
    {
        public void Add(int x, int y, out int sum)
        {
            sum = x + y;
        }
        
        public void Subtract(int x, int y, out int diff)
        {
            diff = x - y;
        }
    }
}

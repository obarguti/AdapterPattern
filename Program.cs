using System;

namespace AdapterPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int sum, diff, x = 4, y = 3;
            
            var legacyLibrary = new LegacyLibrary();
            var defaultLibraryAdapter = new DefaultLibraryAdapter(legacyLibrary);
            var newLibrary = new NewLibrary(defaultLibraryAdapter);
            
            sum = newLibrary.Add(x, y);
            Console.WriteLine("x + y = " + sum);

            diff = newLibrary.Subtract(x, y);
            Console.WriteLine("x - y = " + diff);

            Console.Read();
        }
    }
}

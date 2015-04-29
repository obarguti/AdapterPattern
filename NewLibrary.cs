namespace AdapterPattern
{
    public class NewLibrary : ILibraryAdapter
    {
        public ILibraryAdapter AdapterLibrary { get; set; }

        public NewLibrary(ILibraryAdapter adapterLibrary)
        {
            AdapterLibrary = adapterLibrary;
        }

        public int Add(int x, int y)
        {
            return AdapterLibrary.Add(x, y);
        }

        public int Subtract(int x, int y)
        {
            return AdapterLibrary.Subtract(x, y);
        }
    }
}

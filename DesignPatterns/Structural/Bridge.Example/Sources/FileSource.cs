using Bridge.Example.Interfaces;

namespace Bridge.Example.Sources
{
    public class FileSource : IDataSource
    {
        public string GetData()
        {
            // Simulate fetching data from a file
            return "Data from file";
        }
    }
}
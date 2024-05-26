using Bridge.Example.Interfaces;

namespace Bridge.Example.Sources
{
    public class DatabaseSource : IDataSource
    {
        public string GetData()
        {
            // Simulate fetching data from a database
            return "Data from database";
        }
    }
}

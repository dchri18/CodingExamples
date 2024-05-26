using Bridge.Example.Interfaces;

namespace Bridge.Example.Reports
{
    public class HTMLReport : Report
    {
        public HTMLReport(IDataSource dataSource) : base(dataSource) { }

        public override void Generate()
        {
            string data = _dataSource.GetData();
            // Simulate generating an HTML report
            Console.WriteLine($"Generating HTML report with data: {data}");
        }
    }
}

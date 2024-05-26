using Bridge.Example.Interfaces;

namespace Bridge.Example.Reports
{
    public class PDFReport : Report
    {
        public PDFReport(IDataSource dataSource) : base(dataSource) { }

        public override void Generate()
        {
            string data = _dataSource.GetData();
            // Simulate generating a PDF report
            Console.WriteLine($"Generating PDF report with data: {data}");
        }
    }
}

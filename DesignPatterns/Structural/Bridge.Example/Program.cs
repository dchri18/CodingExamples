using Bridge.Example.Interfaces;
using Bridge.Example.Reports;
using Bridge.Example.Sources;

namespace Bridge.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataSource databaseSource = new DatabaseSource();
            IDataSource fileSource = new FileSource();

            Report pdfReportFromDatabase = new PDFReport(databaseSource);
            pdfReportFromDatabase.Generate();

            Report htmlReportFromFile = new HTMLReport(fileSource);
            htmlReportFromFile.Generate();
        }
    }
}

namespace TemplateMethod.Example.Reports
{
    public class PdfReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data for PDF report...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting report in PDF format...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as PDF file...");
        }
    }
}

namespace TemplateMethod.Example.Reports
{
    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data for Excel report...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting report in Excel format...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting report as Excel file...");
        }
    }
}

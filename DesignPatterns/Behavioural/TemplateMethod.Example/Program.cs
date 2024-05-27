using TemplateMethod.Example.Reports

namespace TemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator pdfReport = new PdfReportGenerator();
            pdfReport.GenerateReport();

            Console.WriteLine();

            ReportGenerator excelReport = new ExcelReportGenerator();
            excelReport.GenerateReport();
        }
    }
}

namespace TemplateMethod.Example.Reports
{
    public abstract class ReportGenerator
    {
        // Template method
        public void GenerateReport()
        {
            CollectData();
            FormatReport();
            ExportReport();
        }

        protected abstract void CollectData();
        protected abstract void FormatReport();
        protected abstract void ExportReport();
    }
}

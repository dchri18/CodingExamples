using Bridge.Example.Interfaces;

namespace Bridge.Example.Reports
{
    public abstract class Report
    {
        protected IDataSource _dataSource;

        protected Report(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public abstract void Generate();
    }
}

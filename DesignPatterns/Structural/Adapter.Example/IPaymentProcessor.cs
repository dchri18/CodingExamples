namespace Adapter.Example
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(string account, decimal amount);
    }
}

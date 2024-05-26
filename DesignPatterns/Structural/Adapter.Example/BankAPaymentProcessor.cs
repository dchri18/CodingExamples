namespace Adapter.Example
{
    public class BankAPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(string account, decimal amount)
        {
            // Implementation for processing payment with BankA
            Console.WriteLine($"Processing payment of {amount} to {account} using BankA.");
        }
    }
}

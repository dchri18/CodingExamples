namespace Adapter.Example
{
    public class BankBPaymentService
    {
        public void MakePayment(string customerAccount, decimal money)
        {
            // Implementation for processing payment with BankB
            Console.WriteLine($"Processing payment of {money} to {customerAccount} using BankB.");
        }
    }
}

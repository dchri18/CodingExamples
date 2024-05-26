namespace Adapter.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor bankAPaymentProcessor = new BankAPaymentProcessor();
            bankAPaymentProcessor.ProcessPayment("123-456", 100.00m);

            BankBPaymentService bankBPaymentService = new BankBPaymentService();
            IPaymentProcessor bankBPaymentAdapter = new BankBPaymentAdapter(bankBPaymentService);
            bankBPaymentAdapter.ProcessPayment("789-012", 200.00m);
        }
    }
}

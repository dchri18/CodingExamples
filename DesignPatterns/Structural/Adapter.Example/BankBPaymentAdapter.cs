namespace Adapter.Example
{
    public class BankBPaymentAdapter : IPaymentProcessor
    {
        private readonly BankBPaymentService _bankBPaymentService;

        public BankBPaymentAdapter(BankBPaymentService bankBPaymentService)
        {
            _bankBPaymentService = bankBPaymentService;
        }

        public void ProcessPayment(string account, decimal amount)
        {
            // Adapting the interface to match the expected method signature
            _bankBPaymentService.MakePayment(account, amount);
        }
    }
}

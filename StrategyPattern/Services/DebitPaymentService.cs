using StrategyPattern.Enumerators;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Services
{
    public class DebitPaymentService : IPaymentMethod
    {
        public PaymentMethodEnum GetPaymentMethod() => PaymentMethodEnum.Debit;

        public (bool success, string message) ProcessPayment(object paymentPayload)
        {
            return (true, $"Payment Successful - Method: {GetPaymentMethod().ToString()}");
        }
    }
}

using StrategyPattern.Enumerators;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Services
{
    public class CreditPaymentService : IPaymentMethod
    {
        public PaymentMethodEnum GetPaymentMethod() => PaymentMethodEnum.Credit;

        public (bool success, string message) ProcessPayment(object paymentPayload)
        {
            return (true, $"Payment Successful - Method: {GetPaymentMethod().ToString()}");
        }
    }
}

using StrategyPattern.Enumerators;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Services
{
    public class PixPaymentService : IPaymentMethod
    {
        public PaymentMethodEnum GetPaymentMethod() => PaymentMethodEnum.Pix;

        public (bool success, string message) ProcessPayment(object paymentPayload)
        {
            return (false, "Method unavailable");
        }
    }
}

using StrategyPattern.Enumerators;

namespace StrategyPattern.Interfaces
{
    public interface IPaymentMethod
    {
        (bool success, string message) ProcessPayment(object paymentPayload);

        PaymentMethodEnum GetPaymentMethod();
    }
}

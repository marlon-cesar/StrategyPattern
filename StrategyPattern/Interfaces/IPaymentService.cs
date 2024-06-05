using StrategyPattern.Enumerators;

namespace StrategyPattern.Interfaces
{
    public interface IPaymentService
    {
        IPaymentMethod? GetPaymentMethodByPaymentMethod(PaymentMethodEnum paymentMethod);
    }
}

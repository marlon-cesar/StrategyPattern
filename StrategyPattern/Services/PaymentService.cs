using StrategyPattern.Enumerators;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IEnumerable<IPaymentMethod> paymentMethods;

        public PaymentService(IEnumerable<IPaymentMethod> paymentMethods) =>
            this.paymentMethods = paymentMethods;

        public IPaymentMethod? GetPaymentMethodByPaymentMethod(PaymentMethodEnum paymentMethod) =>
            this.paymentMethods.FirstOrDefault(x => x.GetPaymentMethod() == paymentMethod);

    }
}

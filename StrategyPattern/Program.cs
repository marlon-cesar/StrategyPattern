using Microsoft.Extensions.DependencyInjection;
using StrategyPattern.Enumerators;
using StrategyPattern.Interfaces;
using StrategyPattern.Services;

var serviceCollection = new ServiceCollection();

ConfigureServies(serviceCollection);

var serviceProvider = serviceCollection.BuildServiceProvider();

var appService = serviceProvider.GetRequiredService<Application>();

appService!.CreatePayment();

static void ConfigureServies(IServiceCollection services)
{
    services.AddScoped<IPaymentService, PaymentService>();

    var paymentMethodServices = typeof(IPaymentMethod).Assembly
                                .GetTypes()
                                .Where(x => !x.IsAbstract && x.IsClass && x.IsAssignableTo(typeof(IPaymentMethod)));

    foreach (var paymentMethodService in paymentMethodServices)
        services.AddScoped(typeof(IPaymentMethod), paymentMethodService);

    services.AddSingleton<Application>();
}


public class Application
{
    private readonly IPaymentService _paymentService;

    public Application(IPaymentService paymentService) =>
        _paymentService = paymentService;

    public void CreatePayment()
    {
        Console.WriteLine("Select your Payment Method:");
        Console.WriteLine("\t1) Credit card");
        Console.WriteLine("\t2) Debit card");
        Console.WriteLine("\t3) Pix");
        Console.WriteLine("\t4) Boleto");
        Console.Write("\nYour option:");

        var option = int.Parse(Console.ReadLine());

        var paymentMethod = (PaymentMethodEnum)option;

        var paymentService = _paymentService.GetPaymentMethodByPaymentMethod(paymentMethod);

        if (paymentService == null)
        {
            Console.WriteLine("Payment Method not found");
            return;
        }

        var paymentResult = paymentService.ProcessPayment("");

        Console.WriteLine(paymentResult.message);
    }
}
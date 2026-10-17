using FruitVendor.AWS.NimbusFactory.CLI.Core.Wiring;

namespace FruitVendor.AWS.NimbusFactory.CLI;

public static class Program
{
    public static void Main()
    {
        var serviceProvider = ServiceProviderBuilder.Build();
        var core = serviceProvider.GetRequiredService<NimbusFactoryCore>();

        core.Create();
    }
}
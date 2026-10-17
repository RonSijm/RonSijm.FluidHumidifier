using FruitVendor.AWS.NimbusFactory.CLI.Core.Wiring;
using RonSijm.FluidHumidifier.Features.Consumer;
using RonSijm.FluidHumidifier.Features.Consumer.Environment;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Factories.Base;

namespace FruitVendor.AWS.NimbusFactory.Tests.Base;

public abstract class BaseBuilderBuilderTest<T> : BaseStackBuilderTest
{
    public T SUT { get; private set; }

    protected BaseBuilderBuilderTest()
    {
        var serviceProvider = ServiceProviderBuilder.Build();
        SUT = serviceProvider.GetRequiredService<T>();

        if (SUT is IHaveDecorators haveDecorators)
        {
            haveDecorators.Decorator = new DecoratorOrchestrator([]);
        }

        if (SUT is IHaveEnvironmentConfig haveEnvironmentConfig)
        {
            haveEnvironmentConfig.Environment = new EnvironmentConfig("dev", "1234", "eu-central-1");
        }
    }
}
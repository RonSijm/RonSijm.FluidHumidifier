// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceServiceObservabilityConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.ServiceObservabilityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.ServiceObservabilityConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.ServiceObservabilityConfiguration Create()
    {
        var serviceObservabilityConfigurationResult = CreateServiceObservabilityConfiguration();
        factoryAction?.Invoke(serviceObservabilityConfigurationResult);

        return serviceObservabilityConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.ServiceObservabilityConfiguration CreateServiceObservabilityConfiguration()
    {
        var serviceObservabilityConfigurationResult = new Humidifier.AppRunner.ServiceTypes.ServiceObservabilityConfiguration();

        return serviceObservabilityConfigurationResult;
    }

} // End Of Class

public static class InnerServiceServiceObservabilityConfigurationFactoryExtensions
{
}

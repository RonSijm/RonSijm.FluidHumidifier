// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCapacityProviderCapacityProviderLoggingConfigFactory(Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig>
{

    protected override Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig Create()
    {
        var capacityProviderLoggingConfigResult = CreateCapacityProviderLoggingConfig();
        factoryAction?.Invoke(capacityProviderLoggingConfigResult);

        return capacityProviderLoggingConfigResult;
    }

    private Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig CreateCapacityProviderLoggingConfig()
    {
        var capacityProviderLoggingConfigResult = new Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig();

        return capacityProviderLoggingConfigResult;
    }

} // End Of Class

public static class InnerCapacityProviderCapacityProviderLoggingConfigFactoryExtensions
{
}

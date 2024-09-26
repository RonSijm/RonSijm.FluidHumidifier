// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerVersionProvisionedConcurrencyConfigurationFactory(Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration>
{

    protected override Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration Create()
    {
        var provisionedConcurrencyConfigurationResult = CreateProvisionedConcurrencyConfiguration();
        factoryAction?.Invoke(provisionedConcurrencyConfigurationResult);

        return provisionedConcurrencyConfigurationResult;
    }

    private Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration CreateProvisionedConcurrencyConfiguration()
    {
        var provisionedConcurrencyConfigurationResult = new Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration();

        return provisionedConcurrencyConfigurationResult;
    }

} // End Of Class

public static class InnerVersionProvisionedConcurrencyConfigurationFactoryExtensions
{
}

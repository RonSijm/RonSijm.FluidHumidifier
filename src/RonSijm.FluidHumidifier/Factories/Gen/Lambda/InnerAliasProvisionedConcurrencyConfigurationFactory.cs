// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerAliasProvisionedConcurrencyConfigurationFactory(Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration>
{

    protected override Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration Create()
    {
        var provisionedConcurrencyConfigurationResult = CreateProvisionedConcurrencyConfiguration();
        factoryAction?.Invoke(provisionedConcurrencyConfigurationResult);

        return provisionedConcurrencyConfigurationResult;
    }

    private Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration CreateProvisionedConcurrencyConfiguration()
    {
        var provisionedConcurrencyConfigurationResult = new Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration();

        return provisionedConcurrencyConfigurationResult;
    }

} // End Of Class

public static class InnerAliasProvisionedConcurrencyConfigurationFactoryExtensions
{
}

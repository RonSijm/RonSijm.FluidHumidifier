// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.HealthLake;

public class InnerFHIRDatastoreIdentityProviderConfigurationFactory(Action<Humidifier.HealthLake.FHIRDatastoreTypes.IdentityProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.HealthLake.FHIRDatastoreTypes.IdentityProviderConfiguration>
{

    protected override Humidifier.HealthLake.FHIRDatastoreTypes.IdentityProviderConfiguration Create()
    {
        var identityProviderConfigurationResult = CreateIdentityProviderConfiguration();
        factoryAction?.Invoke(identityProviderConfigurationResult);

        return identityProviderConfigurationResult;
    }

    private Humidifier.HealthLake.FHIRDatastoreTypes.IdentityProviderConfiguration CreateIdentityProviderConfiguration()
    {
        var identityProviderConfigurationResult = new Humidifier.HealthLake.FHIRDatastoreTypes.IdentityProviderConfiguration();

        return identityProviderConfigurationResult;
    }

} // End Of Class

public static class InnerFHIRDatastoreIdentityProviderConfigurationFactoryExtensions
{
}

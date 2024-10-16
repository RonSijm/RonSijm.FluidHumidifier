// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProvisionedProductProvisioningPreferencesFactory(Action<Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningPreferences> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningPreferences>
{

    protected override Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningPreferences Create()
    {
        var provisioningPreferencesResult = CreateProvisioningPreferences();
        factoryAction?.Invoke(provisioningPreferencesResult);

        return provisioningPreferencesResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningPreferences CreateProvisioningPreferences()
    {
        var provisioningPreferencesResult = new Humidifier.ServiceCatalog.CloudFormationProvisionedProductTypes.ProvisioningPreferences();

        return provisioningPreferencesResult;
    }

} // End Of Class

public static class InnerCloudFormationProvisionedProductProvisioningPreferencesFactoryExtensions
{
}

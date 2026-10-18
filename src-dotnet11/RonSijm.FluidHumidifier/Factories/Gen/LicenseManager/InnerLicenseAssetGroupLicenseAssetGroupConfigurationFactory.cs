// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactory(Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration>
{

    protected override Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration Create()
    {
        var licenseAssetGroupConfigurationResult = CreateLicenseAssetGroupConfiguration();
        factoryAction?.Invoke(licenseAssetGroupConfigurationResult);

        return licenseAssetGroupConfigurationResult;
    }

    private Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration CreateLicenseAssetGroupConfiguration()
    {
        var licenseAssetGroupConfigurationResult = new Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupConfiguration();

        return licenseAssetGroupConfigurationResult;
    }

} // End Of Class

public static class InnerLicenseAssetGroupLicenseAssetGroupConfigurationFactoryExtensions
{
}

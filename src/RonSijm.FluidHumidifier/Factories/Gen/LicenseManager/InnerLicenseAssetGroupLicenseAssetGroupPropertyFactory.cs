// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseAssetGroupLicenseAssetGroupPropertyFactory(Action<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty>
{

    protected override Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty Create()
    {
        var licenseAssetGroupPropertyResult = CreateLicenseAssetGroupProperty();
        factoryAction?.Invoke(licenseAssetGroupPropertyResult);

        return licenseAssetGroupPropertyResult;
    }

    private Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty CreateLicenseAssetGroupProperty()
    {
        var licenseAssetGroupPropertyResult = new Humidifier.LicenseManager.LicenseAssetGroupTypes.LicenseAssetGroupProperty();

        return licenseAssetGroupPropertyResult;
    }

} // End Of Class

public static class InnerLicenseAssetGroupLicenseAssetGroupPropertyFactoryExtensions
{
}

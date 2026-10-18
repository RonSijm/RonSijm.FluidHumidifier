// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseMetadataFactory(Action<Humidifier.LicenseManager.LicenseTypes.Metadata> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseTypes.Metadata>
{

    protected override Humidifier.LicenseManager.LicenseTypes.Metadata Create()
    {
        var metadataResult = CreateMetadata();
        factoryAction?.Invoke(metadataResult);

        return metadataResult;
    }

    private Humidifier.LicenseManager.LicenseTypes.Metadata CreateMetadata()
    {
        var metadataResult = new Humidifier.LicenseManager.LicenseTypes.Metadata();

        return metadataResult;
    }

} // End Of Class

public static class InnerLicenseMetadataFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerStudioComponentLicenseServiceConfigurationFactory(Action<Humidifier.NimbleStudio.StudioComponentTypes.LicenseServiceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.StudioComponentTypes.LicenseServiceConfiguration>
{

    protected override Humidifier.NimbleStudio.StudioComponentTypes.LicenseServiceConfiguration Create()
    {
        var licenseServiceConfigurationResult = CreateLicenseServiceConfiguration();
        factoryAction?.Invoke(licenseServiceConfigurationResult);

        return licenseServiceConfigurationResult;
    }

    private Humidifier.NimbleStudio.StudioComponentTypes.LicenseServiceConfiguration CreateLicenseServiceConfiguration()
    {
        var licenseServiceConfigurationResult = new Humidifier.NimbleStudio.StudioComponentTypes.LicenseServiceConfiguration();

        return licenseServiceConfigurationResult;
    }

} // End Of Class

public static class InnerStudioComponentLicenseServiceConfigurationFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerLicenseProvisionalConfigurationFactory(Action<Humidifier.LicenseManager.LicenseTypes.ProvisionalConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.LicenseTypes.ProvisionalConfiguration>
{

    protected override Humidifier.LicenseManager.LicenseTypes.ProvisionalConfiguration Create()
    {
        var provisionalConfigurationResult = CreateProvisionalConfiguration();
        factoryAction?.Invoke(provisionalConfigurationResult);

        return provisionalConfigurationResult;
    }

    private Humidifier.LicenseManager.LicenseTypes.ProvisionalConfiguration CreateProvisionalConfiguration()
    {
        var provisionalConfigurationResult = new Humidifier.LicenseManager.LicenseTypes.ProvisionalConfiguration();

        return provisionalConfigurationResult;
    }

} // End Of Class

public static class InnerLicenseProvisionalConfigurationFactoryExtensions
{
}

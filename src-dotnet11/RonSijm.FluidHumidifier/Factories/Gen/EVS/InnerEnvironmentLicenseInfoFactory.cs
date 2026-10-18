// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EVS;

public class InnerEnvironmentLicenseInfoFactory(Action<Humidifier.EVS.EnvironmentTypes.LicenseInfo> factoryAction = null) : SubResourceFactory<Humidifier.EVS.EnvironmentTypes.LicenseInfo>
{

    protected override Humidifier.EVS.EnvironmentTypes.LicenseInfo Create()
    {
        var licenseInfoResult = CreateLicenseInfo();
        factoryAction?.Invoke(licenseInfoResult);

        return licenseInfoResult;
    }

    private Humidifier.EVS.EnvironmentTypes.LicenseInfo CreateLicenseInfo()
    {
        var licenseInfoResult = new Humidifier.EVS.EnvironmentTypes.LicenseInfo();

        return licenseInfoResult;
    }

} // End Of Class

public static class InnerEnvironmentLicenseInfoFactoryExtensions
{
}

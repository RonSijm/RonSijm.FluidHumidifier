// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class LicenseEndpointFactory(string resourceName = null, Action<Humidifier.Deadline.LicenseEndpoint> factoryAction = null) : ResourceFactory<Humidifier.Deadline.LicenseEndpoint>(resourceName)
{

    protected override Humidifier.Deadline.LicenseEndpoint Create()
    {
        var licenseEndpointResult = CreateLicenseEndpoint();
        factoryAction?.Invoke(licenseEndpointResult);

        return licenseEndpointResult;
    }

    private Humidifier.Deadline.LicenseEndpoint CreateLicenseEndpoint()
    {
        var licenseEndpointResult = new Humidifier.Deadline.LicenseEndpoint
        {
            GivenName = InputResourceName,
        };

        return licenseEndpointResult;
    }

} // End Of Class

public static class LicenseEndpointFactoryExtensions
{
}

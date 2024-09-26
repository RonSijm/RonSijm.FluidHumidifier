// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class SoftwarePackageVersionFactory(string resourceName = null, Action<Humidifier.IoT.SoftwarePackageVersion> factoryAction = null) : ResourceFactory<Humidifier.IoT.SoftwarePackageVersion>(resourceName)
{

    protected override Humidifier.IoT.SoftwarePackageVersion Create()
    {
        var softwarePackageVersionResult = CreateSoftwarePackageVersion();
        factoryAction?.Invoke(softwarePackageVersionResult);

        return softwarePackageVersionResult;
    }

    private Humidifier.IoT.SoftwarePackageVersion CreateSoftwarePackageVersion()
    {
        var softwarePackageVersionResult = new Humidifier.IoT.SoftwarePackageVersion
        {
            GivenName = InputResourceName,
        };

        return softwarePackageVersionResult;
    }

} // End Of Class

public static class SoftwarePackageVersionFactoryExtensions
{
}

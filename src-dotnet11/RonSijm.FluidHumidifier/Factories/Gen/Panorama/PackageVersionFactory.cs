// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Panorama;

public class PackageVersionFactory(string resourceName = null, Action<Humidifier.Panorama.PackageVersion> factoryAction = null) : ResourceFactory<Humidifier.Panorama.PackageVersion>(resourceName)
{

    protected override Humidifier.Panorama.PackageVersion Create()
    {
        var packageVersionResult = CreatePackageVersion();
        factoryAction?.Invoke(packageVersionResult);

        return packageVersionResult;
    }

    private Humidifier.Panorama.PackageVersion CreatePackageVersion()
    {
        var packageVersionResult = new Humidifier.Panorama.PackageVersion
        {
            GivenName = InputResourceName,
        };

        return packageVersionResult;
    }

} // End Of Class

public static class PackageVersionFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class SoftwarePackageFactory(string resourceName = null, Action<Humidifier.IoT.SoftwarePackage> factoryAction = null) : ResourceFactory<Humidifier.IoT.SoftwarePackage>(resourceName)
{

    protected override Humidifier.IoT.SoftwarePackage Create()
    {
        var softwarePackageResult = CreateSoftwarePackage();
        factoryAction?.Invoke(softwarePackageResult);

        return softwarePackageResult;
    }

    private Humidifier.IoT.SoftwarePackage CreateSoftwarePackage()
    {
        var softwarePackageResult = new Humidifier.IoT.SoftwarePackage
        {
            GivenName = InputResourceName,
        };

        return softwarePackageResult;
    }

} // End Of Class

public static class SoftwarePackageFactoryExtensions
{
}

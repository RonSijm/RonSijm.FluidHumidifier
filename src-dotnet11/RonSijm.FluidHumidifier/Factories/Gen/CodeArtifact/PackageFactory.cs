// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeArtifact;

public class PackageFactory(string resourceName = null, Action<Humidifier.CodeArtifact.Package> factoryAction = null) : ResourceFactory<Humidifier.CodeArtifact.Package>(resourceName)
{

    protected override Humidifier.CodeArtifact.Package Create()
    {
        var packageResult = CreatePackage();
        factoryAction?.Invoke(packageResult);

        return packageResult;
    }

    private Humidifier.CodeArtifact.Package CreatePackage()
    {
        var packageResult = new Humidifier.CodeArtifact.Package
        {
            GivenName = InputResourceName,
        };

        return packageResult;
    }

} // End Of Class

public static class PackageFactoryExtensions
{
}

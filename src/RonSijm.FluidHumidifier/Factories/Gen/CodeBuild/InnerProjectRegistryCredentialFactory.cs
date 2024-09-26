// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectRegistryCredentialFactory(Action<Humidifier.CodeBuild.ProjectTypes.RegistryCredential> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.RegistryCredential>
{

    protected override Humidifier.CodeBuild.ProjectTypes.RegistryCredential Create()
    {
        var registryCredentialResult = CreateRegistryCredential();
        factoryAction?.Invoke(registryCredentialResult);

        return registryCredentialResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.RegistryCredential CreateRegistryCredential()
    {
        var registryCredentialResult = new Humidifier.CodeBuild.ProjectTypes.RegistryCredential();

        return registryCredentialResult;
    }

} // End Of Class

public static class InnerProjectRegistryCredentialFactoryExtensions
{
}

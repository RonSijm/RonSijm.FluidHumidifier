// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionRepositoryCredentialsFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.RepositoryCredentials> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.RepositoryCredentials>
{

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.RepositoryCredentials Create()
    {
        var repositoryCredentialsResult = CreateRepositoryCredentials();
        factoryAction?.Invoke(repositoryCredentialsResult);

        return repositoryCredentialsResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.RepositoryCredentials CreateRepositoryCredentials()
    {
        var repositoryCredentialsResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.RepositoryCredentials();

        return repositoryCredentialsResult;
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionRepositoryCredentialsFactoryExtensions
{
}

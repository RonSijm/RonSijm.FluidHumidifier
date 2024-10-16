// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionRepositoryCredentialsFactory(Action<Humidifier.ECS.TaskDefinitionTypes.RepositoryCredentials> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.RepositoryCredentials>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.RepositoryCredentials Create()
    {
        var repositoryCredentialsResult = CreateRepositoryCredentials();
        factoryAction?.Invoke(repositoryCredentialsResult);

        return repositoryCredentialsResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.RepositoryCredentials CreateRepositoryCredentials()
    {
        var repositoryCredentialsResult = new Humidifier.ECS.TaskDefinitionTypes.RepositoryCredentials();

        return repositoryCredentialsResult;
    }

} // End Of Class

public static class InnerTaskDefinitionRepositoryCredentialsFactoryExtensions
{
}

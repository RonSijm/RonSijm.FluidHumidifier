// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionRepositoryCredentialsFactory(Action<Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials>
{

    protected override Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials Create()
    {
        var repositoryCredentialsResult = CreateRepositoryCredentials();
        factoryAction?.Invoke(repositoryCredentialsResult);

        return repositoryCredentialsResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials CreateRepositoryCredentials()
    {
        var repositoryCredentialsResult = new Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials();

        return repositoryCredentialsResult;
    }

} // End Of Class

public static class InnerJobDefinitionRepositoryCredentialsFactoryExtensions
{
}

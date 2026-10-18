// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeArtifact;

public class RepositoryFactory(string resourceName = null, Action<Humidifier.CodeArtifact.Repository> factoryAction = null) : ResourceFactory<Humidifier.CodeArtifact.Repository>(resourceName)
{

    protected override Humidifier.CodeArtifact.Repository Create()
    {
        var repositoryResult = CreateRepository();
        factoryAction?.Invoke(repositoryResult);

        return repositoryResult;
    }

    private Humidifier.CodeArtifact.Repository CreateRepository()
    {
        var repositoryResult = new Humidifier.CodeArtifact.Repository
        {
            GivenName = InputResourceName,
        };

        return repositoryResult;
    }

} // End Of Class

public static class RepositoryFactoryExtensions
{
}

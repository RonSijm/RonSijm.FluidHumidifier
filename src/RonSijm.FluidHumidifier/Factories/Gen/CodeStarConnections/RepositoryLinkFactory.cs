// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStarConnections;

public class RepositoryLinkFactory(string resourceName = null, Action<Humidifier.CodeStarConnections.RepositoryLink> factoryAction = null) : ResourceFactory<Humidifier.CodeStarConnections.RepositoryLink>(resourceName)
{

    protected override Humidifier.CodeStarConnections.RepositoryLink Create()
    {
        var repositoryLinkResult = CreateRepositoryLink();
        factoryAction?.Invoke(repositoryLinkResult);

        return repositoryLinkResult;
    }

    private Humidifier.CodeStarConnections.RepositoryLink CreateRepositoryLink()
    {
        var repositoryLinkResult = new Humidifier.CodeStarConnections.RepositoryLink
        {
            GivenName = InputResourceName,
        };

        return repositoryLinkResult;
    }

} // End Of Class

public static class RepositoryLinkFactoryExtensions
{
}

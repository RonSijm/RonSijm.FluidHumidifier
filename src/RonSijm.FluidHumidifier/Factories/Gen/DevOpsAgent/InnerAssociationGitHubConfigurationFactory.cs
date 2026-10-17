// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationGitHubConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.GitHubConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.GitHubConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.GitHubConfiguration Create()
    {
        var gitHubConfigurationResult = CreateGitHubConfiguration();
        factoryAction?.Invoke(gitHubConfigurationResult);

        return gitHubConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.GitHubConfiguration CreateGitHubConfiguration()
    {
        var gitHubConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.GitHubConfiguration();

        return gitHubConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationGitHubConfigurationFactoryExtensions
{
}

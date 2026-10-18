// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationGitLabConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.GitLabConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.GitLabConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.GitLabConfiguration Create()
    {
        var gitLabConfigurationResult = CreateGitLabConfiguration();
        factoryAction?.Invoke(gitLabConfigurationResult);

        return gitLabConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.GitLabConfiguration CreateGitLabConfiguration()
    {
        var gitLabConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.GitLabConfiguration();

        return gitLabConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationGitLabConfigurationFactoryExtensions
{
}

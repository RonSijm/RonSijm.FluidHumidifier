// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceGitLabDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.GitLabDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.GitLabDetails>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.GitLabDetails Create()
    {
        var gitLabDetailsResult = CreateGitLabDetails();
        factoryAction?.Invoke(gitLabDetailsResult);

        return gitLabDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.GitLabDetails CreateGitLabDetails()
    {
        var gitLabDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.GitLabDetails();

        return gitLabDetailsResult;
    }

} // End Of Class

public static class InnerServiceGitLabDetailsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceGitHubPatDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails Create()
    {
        var gitHubPatDetailsResult = CreateGitHubPatDetails();
        factoryAction?.Invoke(gitHubPatDetailsResult);

        return gitHubPatDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails CreateGitHubPatDetails()
    {
        var gitHubPatDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails();

        return gitHubPatDetailsResult;
    }

} // End Of Class

public static class InnerServiceGitHubPatDetailsFactoryExtensions
{
}

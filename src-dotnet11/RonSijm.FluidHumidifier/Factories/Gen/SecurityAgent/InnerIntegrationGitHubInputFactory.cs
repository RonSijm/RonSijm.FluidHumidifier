// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerIntegrationGitHubInputFactory(Action<Humidifier.SecurityAgent.IntegrationTypes.GitHubInput> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.IntegrationTypes.GitHubInput>
{

    protected override Humidifier.SecurityAgent.IntegrationTypes.GitHubInput Create()
    {
        var gitHubInputResult = CreateGitHubInput();
        factoryAction?.Invoke(gitHubInputResult);

        return gitHubInputResult;
    }

    private Humidifier.SecurityAgent.IntegrationTypes.GitHubInput CreateGitHubInput()
    {
        var gitHubInputResult = new Humidifier.SecurityAgent.IntegrationTypes.GitHubInput();

        return gitHubInputResult;
    }

} // End Of Class

public static class InnerIntegrationGitHubInputFactoryExtensions
{
}

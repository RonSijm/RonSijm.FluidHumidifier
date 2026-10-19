// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerIntegrationGitLabInputFactory(Action<Humidifier.SecurityAgent.IntegrationTypes.GitLabInput> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.IntegrationTypes.GitLabInput>
{

    protected override Humidifier.SecurityAgent.IntegrationTypes.GitLabInput Create()
    {
        var gitLabInputResult = CreateGitLabInput();
        factoryAction?.Invoke(gitLabInputResult);

        return gitLabInputResult;
    }

    private Humidifier.SecurityAgent.IntegrationTypes.GitLabInput CreateGitLabInput()
    {
        var gitLabInputResult = new Humidifier.SecurityAgent.IntegrationTypes.GitLabInput();

        return gitLabInputResult;
    }

} // End Of Class

public static class InnerIntegrationGitLabInputFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceGitHubAppVerificationDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails>
{

    protected override Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails Create()
    {
        var gitHubAppVerificationDetailsResult = CreateGitHubAppVerificationDetails();
        factoryAction?.Invoke(gitHubAppVerificationDetailsResult);

        return gitHubAppVerificationDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails CreateGitHubAppVerificationDetails()
    {
        var gitHubAppVerificationDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails();

        return gitHubAppVerificationDetailsResult;
    }

} // End Of Class

public static class InnerServiceGitHubAppVerificationDetailsFactoryExtensions
{
}

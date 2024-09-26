// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupGitHubLocationFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation Create()
    {
        var gitHubLocationResult = CreateGitHubLocation();
        factoryAction?.Invoke(gitHubLocationResult);

        return gitHubLocationResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation CreateGitHubLocation()
    {
        var gitHubLocationResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.GitHubLocation();

        return gitHubLocationResult;
    }

} // End Of Class

public static class InnerDeploymentGroupGitHubLocationFactoryExtensions
{
}

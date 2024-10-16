// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDeploymentDeploymentCanarySettingsFactory(Action<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings>
{

    protected override Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings Create()
    {
        var deploymentCanarySettingsResult = CreateDeploymentCanarySettings();
        factoryAction?.Invoke(deploymentCanarySettingsResult);

        return deploymentCanarySettingsResult;
    }

    private Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings CreateDeploymentCanarySettings()
    {
        var deploymentCanarySettingsResult = new Humidifier.ApiGateway.DeploymentTypes.DeploymentCanarySettings();

        return deploymentCanarySettingsResult;
    }

} // End Of Class

public static class InnerDeploymentDeploymentCanarySettingsFactoryExtensions
{
}

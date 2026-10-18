// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class InnerDeploymentDeploymentConfigurationFactory(Action<Humidifier.NetworkSecurityManager.DeploymentTypes.DeploymentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NetworkSecurityManager.DeploymentTypes.DeploymentConfiguration>
{

    protected override Humidifier.NetworkSecurityManager.DeploymentTypes.DeploymentConfiguration Create()
    {
        var deploymentConfigurationResult = CreateDeploymentConfiguration();
        factoryAction?.Invoke(deploymentConfigurationResult);

        return deploymentConfigurationResult;
    }

    private Humidifier.NetworkSecurityManager.DeploymentTypes.DeploymentConfiguration CreateDeploymentConfiguration()
    {
        var deploymentConfigurationResult = new Humidifier.NetworkSecurityManager.DeploymentTypes.DeploymentConfiguration();

        return deploymentConfigurationResult;
    }

} // End Of Class

public static class InnerDeploymentDeploymentConfigurationFactoryExtensions
{
}

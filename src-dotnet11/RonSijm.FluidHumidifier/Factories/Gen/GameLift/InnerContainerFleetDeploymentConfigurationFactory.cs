// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetDeploymentConfigurationFactory(Action<Humidifier.GameLift.ContainerFleetTypes.DeploymentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.DeploymentConfiguration>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.DeploymentConfiguration Create()
    {
        var deploymentConfigurationResult = CreateDeploymentConfiguration();
        factoryAction?.Invoke(deploymentConfigurationResult);

        return deploymentConfigurationResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.DeploymentConfiguration CreateDeploymentConfiguration()
    {
        var deploymentConfigurationResult = new Humidifier.GameLift.ContainerFleetTypes.DeploymentConfiguration();

        return deploymentConfigurationResult;
    }

} // End Of Class

public static class InnerContainerFleetDeploymentConfigurationFactoryExtensions
{
}

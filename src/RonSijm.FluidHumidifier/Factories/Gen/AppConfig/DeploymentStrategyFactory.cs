// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class DeploymentStrategyFactory(string resourceName = null, Action<Humidifier.AppConfig.DeploymentStrategy> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.DeploymentStrategy>(resourceName)
{

    protected override Humidifier.AppConfig.DeploymentStrategy Create()
    {
        var deploymentStrategyResult = CreateDeploymentStrategy();
        factoryAction?.Invoke(deploymentStrategyResult);

        return deploymentStrategyResult;
    }

    private Humidifier.AppConfig.DeploymentStrategy CreateDeploymentStrategy()
    {
        var deploymentStrategyResult = new Humidifier.AppConfig.DeploymentStrategy
        {
            GivenName = InputResourceName,
        };

        return deploymentStrategyResult;
    }

} // End Of Class

public static class DeploymentStrategyFactoryExtensions
{
}

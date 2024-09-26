// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentConfigTimeBasedCanaryFactory(Action<Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedCanary> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedCanary>
{

    protected override Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedCanary Create()
    {
        var timeBasedCanaryResult = CreateTimeBasedCanary();
        factoryAction?.Invoke(timeBasedCanaryResult);

        return timeBasedCanaryResult;
    }

    private Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedCanary CreateTimeBasedCanary()
    {
        var timeBasedCanaryResult = new Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedCanary();

        return timeBasedCanaryResult;
    }

} // End Of Class

public static class InnerDeploymentConfigTimeBasedCanaryFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceDeploymentAlarmsFactory(Action<Humidifier.ECS.ServiceTypes.DeploymentAlarms> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.DeploymentAlarms>
{

    protected override Humidifier.ECS.ServiceTypes.DeploymentAlarms Create()
    {
        var deploymentAlarmsResult = CreateDeploymentAlarms();
        factoryAction?.Invoke(deploymentAlarmsResult);

        return deploymentAlarmsResult;
    }

    private Humidifier.ECS.ServiceTypes.DeploymentAlarms CreateDeploymentAlarms()
    {
        var deploymentAlarmsResult = new Humidifier.ECS.ServiceTypes.DeploymentAlarms();

        return deploymentAlarmsResult;
    }

} // End Of Class

public static class InnerServiceDeploymentAlarmsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class DaemonDeploymentFactory(string resourceName = null, Action<Humidifier.ECS.DaemonDeployment> factoryAction = null) : ResourceFactory<Humidifier.ECS.DaemonDeployment>(resourceName)
{

    protected override Humidifier.ECS.DaemonDeployment Create()
    {
        var daemonDeploymentResult = CreateDaemonDeployment();
        factoryAction?.Invoke(daemonDeploymentResult);

        return daemonDeploymentResult;
    }

    private Humidifier.ECS.DaemonDeployment CreateDaemonDeployment()
    {
        var daemonDeploymentResult = new Humidifier.ECS.DaemonDeployment
        {
            GivenName = InputResourceName,
        };

        return daemonDeploymentResult;
    }

} // End Of Class

public static class DaemonDeploymentFactoryExtensions
{
}

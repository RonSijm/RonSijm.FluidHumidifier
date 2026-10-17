// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceRunInstancesMonitoringEnabledFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.RunInstancesMonitoringEnabled> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.RunInstancesMonitoringEnabled>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.RunInstancesMonitoringEnabled Create()
    {
        var runInstancesMonitoringEnabledResult = CreateRunInstancesMonitoringEnabled();
        factoryAction?.Invoke(runInstancesMonitoringEnabledResult);

        return runInstancesMonitoringEnabledResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.RunInstancesMonitoringEnabled CreateRunInstancesMonitoringEnabled()
    {
        var runInstancesMonitoringEnabledResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.RunInstancesMonitoringEnabled();

        return runInstancesMonitoringEnabledResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceRunInstancesMonitoringEnabledFactoryExtensions
{
}

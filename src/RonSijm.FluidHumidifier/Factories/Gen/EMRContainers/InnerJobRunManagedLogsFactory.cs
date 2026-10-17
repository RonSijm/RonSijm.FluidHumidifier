// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunManagedLogsFactory(Action<Humidifier.EMRContainers.JobRunTypes.ManagedLogs> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.ManagedLogs>
{

    protected override Humidifier.EMRContainers.JobRunTypes.ManagedLogs Create()
    {
        var managedLogsResult = CreateManagedLogs();
        factoryAction?.Invoke(managedLogsResult);

        return managedLogsResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.ManagedLogs CreateManagedLogs()
    {
        var managedLogsResult = new Humidifier.EMRContainers.JobRunTypes.ManagedLogs();

        return managedLogsResult;
    }

} // End Of Class

public static class InnerJobRunManagedLogsFactoryExtensions
{
}

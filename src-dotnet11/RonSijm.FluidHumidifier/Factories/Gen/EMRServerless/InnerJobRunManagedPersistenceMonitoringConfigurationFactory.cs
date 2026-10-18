// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerJobRunManagedPersistenceMonitoringConfigurationFactory(Action<Humidifier.EMRServerless.JobRunTypes.ManagedPersistenceMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.JobRunTypes.ManagedPersistenceMonitoringConfiguration>
{

    protected override Humidifier.EMRServerless.JobRunTypes.ManagedPersistenceMonitoringConfiguration Create()
    {
        var managedPersistenceMonitoringConfigurationResult = CreateManagedPersistenceMonitoringConfiguration();
        factoryAction?.Invoke(managedPersistenceMonitoringConfigurationResult);

        return managedPersistenceMonitoringConfigurationResult;
    }

    private Humidifier.EMRServerless.JobRunTypes.ManagedPersistenceMonitoringConfiguration CreateManagedPersistenceMonitoringConfiguration()
    {
        var managedPersistenceMonitoringConfigurationResult = new Humidifier.EMRServerless.JobRunTypes.ManagedPersistenceMonitoringConfiguration();

        return managedPersistenceMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerJobRunManagedPersistenceMonitoringConfigurationFactoryExtensions
{
}

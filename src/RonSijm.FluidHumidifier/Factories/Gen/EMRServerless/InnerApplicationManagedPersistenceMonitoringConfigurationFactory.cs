// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationManagedPersistenceMonitoringConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration Create()
    {
        var managedPersistenceMonitoringConfigurationResult = CreateManagedPersistenceMonitoringConfiguration();
        factoryAction?.Invoke(managedPersistenceMonitoringConfigurationResult);

        return managedPersistenceMonitoringConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration CreateManagedPersistenceMonitoringConfiguration()
    {
        var managedPersistenceMonitoringConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.ManagedPersistenceMonitoringConfiguration();

        return managedPersistenceMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationManagedPersistenceMonitoringConfigurationFactoryExtensions
{
}

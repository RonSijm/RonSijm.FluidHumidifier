// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupManagedLoggingConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.ManagedLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.ManagedLoggingConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.ManagedLoggingConfiguration Create()
    {
        var managedLoggingConfigurationResult = CreateManagedLoggingConfiguration();
        factoryAction?.Invoke(managedLoggingConfigurationResult);

        return managedLoggingConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.ManagedLoggingConfiguration CreateManagedLoggingConfiguration()
    {
        var managedLoggingConfigurationResult = new Humidifier.Athena.WorkGroupTypes.ManagedLoggingConfiguration();

        return managedLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupManagedLoggingConfigurationFactoryExtensions
{
}

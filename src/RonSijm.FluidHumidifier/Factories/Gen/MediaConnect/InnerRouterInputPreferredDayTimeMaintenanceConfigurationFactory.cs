// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration Create()
    {
        var preferredDayTimeMaintenanceConfigurationResult = CreatePreferredDayTimeMaintenanceConfiguration();
        factoryAction?.Invoke(preferredDayTimeMaintenanceConfigurationResult);

        return preferredDayTimeMaintenanceConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration CreatePreferredDayTimeMaintenanceConfiguration()
    {
        var preferredDayTimeMaintenanceConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.PreferredDayTimeMaintenanceConfiguration();

        return preferredDayTimeMaintenanceConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputPreferredDayTimeMaintenanceConfigurationFactoryExtensions
{
}

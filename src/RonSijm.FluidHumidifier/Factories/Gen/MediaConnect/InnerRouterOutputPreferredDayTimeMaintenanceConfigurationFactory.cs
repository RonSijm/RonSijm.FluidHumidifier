// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration>
{

    protected override Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration Create()
    {
        var preferredDayTimeMaintenanceConfigurationResult = CreatePreferredDayTimeMaintenanceConfiguration();
        factoryAction?.Invoke(preferredDayTimeMaintenanceConfigurationResult);

        return preferredDayTimeMaintenanceConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration CreatePreferredDayTimeMaintenanceConfiguration()
    {
        var preferredDayTimeMaintenanceConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.PreferredDayTimeMaintenanceConfiguration();

        return preferredDayTimeMaintenanceConfigurationResult;
    }

} // End Of Class

public static class InnerRouterOutputPreferredDayTimeMaintenanceConfigurationFactoryExtensions
{
}

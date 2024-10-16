// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelMaintenanceCreateSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.MaintenanceCreateSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.MaintenanceCreateSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.MaintenanceCreateSettings Create()
    {
        var maintenanceCreateSettingsResult = CreateMaintenanceCreateSettings();
        factoryAction?.Invoke(maintenanceCreateSettingsResult);

        return maintenanceCreateSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.MaintenanceCreateSettings CreateMaintenanceCreateSettings()
    {
        var maintenanceCreateSettingsResult = new Humidifier.MediaLive.ChannelTypes.MaintenanceCreateSettings();

        return maintenanceCreateSettingsResult;
    }

} // End Of Class

public static class InnerChannelMaintenanceCreateSettingsFactoryExtensions
{
}

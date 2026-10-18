// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelDisabledLockingSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.DisabledLockingSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.DisabledLockingSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.DisabledLockingSettings Create()
    {
        var disabledLockingSettingsResult = CreateDisabledLockingSettings();
        factoryAction?.Invoke(disabledLockingSettingsResult);

        return disabledLockingSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.DisabledLockingSettings CreateDisabledLockingSettings()
    {
        var disabledLockingSettingsResult = new Humidifier.MediaLive.ChannelTypes.DisabledLockingSettings();

        return disabledLockingSettingsResult;
    }

} // End Of Class

public static class InnerChannelDisabledLockingSettingsFactoryExtensions
{
}

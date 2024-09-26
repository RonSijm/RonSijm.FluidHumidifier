// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelEpochLockingSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.EpochLockingSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.EpochLockingSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.EpochLockingSettings Create()
    {
        var epochLockingSettingsResult = CreateEpochLockingSettings();
        factoryAction?.Invoke(epochLockingSettingsResult);

        return epochLockingSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.EpochLockingSettings CreateEpochLockingSettings()
    {
        var epochLockingSettingsResult = new Humidifier.MediaLive.ChannelTypes.EpochLockingSettings();

        return epochLockingSettingsResult;
    }

} // End Of Class

public static class InnerChannelEpochLockingSettingsFactoryExtensions
{
}

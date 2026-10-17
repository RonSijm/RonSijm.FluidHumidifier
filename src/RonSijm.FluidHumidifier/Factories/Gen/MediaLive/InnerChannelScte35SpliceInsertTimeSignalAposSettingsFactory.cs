// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelScte35SpliceInsertTimeSignalAposSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsertTimeSignalAposSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsertTimeSignalAposSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsertTimeSignalAposSettings Create()
    {
        var scte35SpliceInsertTimeSignalAposSettingsResult = CreateScte35SpliceInsertTimeSignalAposSettings();
        factoryAction?.Invoke(scte35SpliceInsertTimeSignalAposSettingsResult);

        return scte35SpliceInsertTimeSignalAposSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsertTimeSignalAposSettings CreateScte35SpliceInsertTimeSignalAposSettings()
    {
        var scte35SpliceInsertTimeSignalAposSettingsResult = new Humidifier.MediaLive.ChannelTypes.Scte35SpliceInsertTimeSignalAposSettings();

        return scte35SpliceInsertTimeSignalAposSettingsResult;
    }

} // End Of Class

public static class InnerChannelScte35SpliceInsertTimeSignalAposSettingsFactoryExtensions
{
}

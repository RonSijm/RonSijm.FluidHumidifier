// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelScte35TimeSignalAposFactory(Action<Humidifier.MediaLive.ChannelTypes.Scte35TimeSignalApos> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.Scte35TimeSignalApos>
{

    protected override Humidifier.MediaLive.ChannelTypes.Scte35TimeSignalApos Create()
    {
        var scte35TimeSignalAposResult = CreateScte35TimeSignalApos();
        factoryAction?.Invoke(scte35TimeSignalAposResult);

        return scte35TimeSignalAposResult;
    }

    private Humidifier.MediaLive.ChannelTypes.Scte35TimeSignalApos CreateScte35TimeSignalApos()
    {
        var scte35TimeSignalAposResult = new Humidifier.MediaLive.ChannelTypes.Scte35TimeSignalApos();

        return scte35TimeSignalAposResult;
    }

} // End Of Class

public static class InnerChannelScte35TimeSignalAposFactoryExtensions
{
}

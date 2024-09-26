// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactory(Action<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings>
{

    protected override Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings Create()
    {
        var multiplexStatmuxVideoSettingsResult = CreateMultiplexStatmuxVideoSettings();
        factoryAction?.Invoke(multiplexStatmuxVideoSettingsResult);

        return multiplexStatmuxVideoSettingsResult;
    }

    private Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings CreateMultiplexStatmuxVideoSettings()
    {
        var multiplexStatmuxVideoSettingsResult = new Humidifier.MediaLive.MultiplexprogramTypes.MultiplexStatmuxVideoSettings();

        return multiplexStatmuxVideoSettingsResult;
    }

} // End Of Class

public static class InnerMultiplexprogramMultiplexStatmuxVideoSettingsFactoryExtensions
{
}

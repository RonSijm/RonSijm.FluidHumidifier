// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexMultiplexSettingsFactory(Action<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings>
{

    protected override Humidifier.MediaLive.MultiplexTypes.MultiplexSettings Create()
    {
        var multiplexSettingsResult = CreateMultiplexSettings();
        factoryAction?.Invoke(multiplexSettingsResult);

        return multiplexSettingsResult;
    }

    private Humidifier.MediaLive.MultiplexTypes.MultiplexSettings CreateMultiplexSettings()
    {
        var multiplexSettingsResult = new Humidifier.MediaLive.MultiplexTypes.MultiplexSettings();

        return multiplexSettingsResult;
    }

} // End Of Class

public static class InnerMultiplexMultiplexSettingsFactoryExtensions
{
}

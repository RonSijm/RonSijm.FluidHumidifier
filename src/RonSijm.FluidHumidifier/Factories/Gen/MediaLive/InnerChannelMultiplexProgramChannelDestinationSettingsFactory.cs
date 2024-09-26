// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelMultiplexProgramChannelDestinationSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings Create()
    {
        var multiplexProgramChannelDestinationSettingsResult = CreateMultiplexProgramChannelDestinationSettings();
        factoryAction?.Invoke(multiplexProgramChannelDestinationSettingsResult);

        return multiplexProgramChannelDestinationSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings CreateMultiplexProgramChannelDestinationSettings()
    {
        var multiplexProgramChannelDestinationSettingsResult = new Humidifier.MediaLive.ChannelTypes.MultiplexProgramChannelDestinationSettings();

        return multiplexProgramChannelDestinationSettingsResult;
    }

} // End Of Class

public static class InnerChannelMultiplexProgramChannelDestinationSettingsFactoryExtensions
{
}

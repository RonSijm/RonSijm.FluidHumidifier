// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactory(Action<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings>
{

    protected override Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings Create()
    {
        var multiplexMediaConnectOutputDestinationSettingsResult = CreateMultiplexMediaConnectOutputDestinationSettings();
        factoryAction?.Invoke(multiplexMediaConnectOutputDestinationSettingsResult);

        return multiplexMediaConnectOutputDestinationSettingsResult;
    }

    private Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings CreateMultiplexMediaConnectOutputDestinationSettings()
    {
        var multiplexMediaConnectOutputDestinationSettingsResult = new Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings();

        return multiplexMediaConnectOutputDestinationSettingsResult;
    }

} // End Of Class

public static class InnerMultiplexMultiplexMediaConnectOutputDestinationSettingsFactoryExtensions
{
}

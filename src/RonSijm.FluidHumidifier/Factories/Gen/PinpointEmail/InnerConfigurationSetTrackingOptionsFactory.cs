// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PinpointEmail;

public class InnerConfigurationSetTrackingOptionsFactory(Action<Humidifier.PinpointEmail.ConfigurationSetTypes.TrackingOptions> factoryAction = null) : SubResourceFactory<Humidifier.PinpointEmail.ConfigurationSetTypes.TrackingOptions>
{

    protected override Humidifier.PinpointEmail.ConfigurationSetTypes.TrackingOptions Create()
    {
        var trackingOptionsResult = CreateTrackingOptions();
        factoryAction?.Invoke(trackingOptionsResult);

        return trackingOptionsResult;
    }

    private Humidifier.PinpointEmail.ConfigurationSetTypes.TrackingOptions CreateTrackingOptions()
    {
        var trackingOptionsResult = new Humidifier.PinpointEmail.ConfigurationSetTypes.TrackingOptions();

        return trackingOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetTrackingOptionsFactoryExtensions
{
}

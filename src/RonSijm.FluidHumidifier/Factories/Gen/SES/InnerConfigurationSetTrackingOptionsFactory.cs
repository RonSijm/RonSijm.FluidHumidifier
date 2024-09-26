// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetTrackingOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.TrackingOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.TrackingOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.TrackingOptions Create()
    {
        var trackingOptionsResult = CreateTrackingOptions();
        factoryAction?.Invoke(trackingOptionsResult);

        return trackingOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.TrackingOptions CreateTrackingOptions()
    {
        var trackingOptionsResult = new Humidifier.SES.ConfigurationSetTypes.TrackingOptions();

        return trackingOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetTrackingOptionsFactoryExtensions
{
}

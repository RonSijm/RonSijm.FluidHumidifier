// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigTrackingConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.TrackingConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.TrackingConfig>
{

    protected override Humidifier.GroundStation.ConfigTypes.TrackingConfig Create()
    {
        var trackingConfigResult = CreateTrackingConfig();
        factoryAction?.Invoke(trackingConfigResult);

        return trackingConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.TrackingConfig CreateTrackingConfig()
    {
        var trackingConfigResult = new Humidifier.GroundStation.ConfigTypes.TrackingConfig();

        return trackingConfigResult;
    }

} // End Of Class

public static class InnerConfigTrackingConfigFactoryExtensions
{
}

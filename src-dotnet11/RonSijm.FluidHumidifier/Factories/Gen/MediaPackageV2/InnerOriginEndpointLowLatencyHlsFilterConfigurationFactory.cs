// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointLowLatencyHlsFilterConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsFilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsFilterConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsFilterConfiguration Create()
    {
        var lowLatencyHlsFilterConfigurationResult = CreateLowLatencyHlsFilterConfiguration();
        factoryAction?.Invoke(lowLatencyHlsFilterConfigurationResult);

        return lowLatencyHlsFilterConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsFilterConfiguration CreateLowLatencyHlsFilterConfiguration()
    {
        var lowLatencyHlsFilterConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.LowLatencyHlsFilterConfiguration();

        return lowLatencyHlsFilterConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointLowLatencyHlsFilterConfigurationFactoryExtensions
{
}

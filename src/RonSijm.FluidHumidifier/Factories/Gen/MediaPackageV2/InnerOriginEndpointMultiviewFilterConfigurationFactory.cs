// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointMultiviewFilterConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration Create()
    {
        var multiviewFilterConfigurationResult = CreateMultiviewFilterConfiguration();
        factoryAction?.Invoke(multiviewFilterConfigurationResult);

        return multiviewFilterConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration CreateMultiviewFilterConfiguration()
    {
        var multiviewFilterConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.MultiviewFilterConfiguration();

        return multiviewFilterConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointMultiviewFilterConfigurationFactoryExtensions
{
}

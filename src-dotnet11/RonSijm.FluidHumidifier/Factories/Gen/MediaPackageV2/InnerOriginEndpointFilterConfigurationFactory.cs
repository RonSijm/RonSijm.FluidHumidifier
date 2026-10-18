// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointFilterConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration Create()
    {
        var filterConfigurationResult = CreateFilterConfiguration();
        factoryAction?.Invoke(filterConfigurationResult);

        return filterConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration CreateFilterConfiguration()
    {
        var filterConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.FilterConfiguration();

        return filterConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointFilterConfigurationFactoryExtensions
{
}

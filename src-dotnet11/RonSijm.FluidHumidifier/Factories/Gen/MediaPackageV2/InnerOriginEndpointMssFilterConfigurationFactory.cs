// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointMssFilterConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration Create()
    {
        var mssFilterConfigurationResult = CreateMssFilterConfiguration();
        factoryAction?.Invoke(mssFilterConfigurationResult);

        return mssFilterConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration CreateMssFilterConfiguration()
    {
        var mssFilterConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.MssFilterConfiguration();

        return mssFilterConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointMssFilterConfigurationFactoryExtensions
{
}

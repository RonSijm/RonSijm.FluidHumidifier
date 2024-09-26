// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointDashUtcTimingFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.DashUtcTiming> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.DashUtcTiming>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.DashUtcTiming Create()
    {
        var dashUtcTimingResult = CreateDashUtcTiming();
        factoryAction?.Invoke(dashUtcTimingResult);

        return dashUtcTimingResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.DashUtcTiming CreateDashUtcTiming()
    {
        var dashUtcTimingResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.DashUtcTiming();

        return dashUtcTimingResult;
    }

} // End Of Class

public static class InnerOriginEndpointDashUtcTimingFactoryExtensions
{
}

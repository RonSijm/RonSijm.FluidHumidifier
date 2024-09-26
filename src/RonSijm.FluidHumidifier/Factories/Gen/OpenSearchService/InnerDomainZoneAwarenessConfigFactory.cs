// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainZoneAwarenessConfigFactory(Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig>
{

    protected override Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig Create()
    {
        var zoneAwarenessConfigResult = CreateZoneAwarenessConfig();
        factoryAction?.Invoke(zoneAwarenessConfigResult);

        return zoneAwarenessConfigResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig CreateZoneAwarenessConfig()
    {
        var zoneAwarenessConfigResult = new Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig();

        return zoneAwarenessConfigResult;
    }

} // End Of Class

public static class InnerDomainZoneAwarenessConfigFactoryExtensions
{
}

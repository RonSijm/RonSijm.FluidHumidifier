// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Elasticsearch;

public class InnerDomainZoneAwarenessConfigFactory(Action<Humidifier.Elasticsearch.DomainTypes.ZoneAwarenessConfig> factoryAction = null) : SubResourceFactory<Humidifier.Elasticsearch.DomainTypes.ZoneAwarenessConfig>
{

    protected override Humidifier.Elasticsearch.DomainTypes.ZoneAwarenessConfig Create()
    {
        var zoneAwarenessConfigResult = CreateZoneAwarenessConfig();
        factoryAction?.Invoke(zoneAwarenessConfigResult);

        return zoneAwarenessConfigResult;
    }

    private Humidifier.Elasticsearch.DomainTypes.ZoneAwarenessConfig CreateZoneAwarenessConfig()
    {
        var zoneAwarenessConfigResult = new Humidifier.Elasticsearch.DomainTypes.ZoneAwarenessConfig();

        return zoneAwarenessConfigResult;
    }

} // End Of Class

public static class InnerDomainZoneAwarenessConfigFactoryExtensions
{
}

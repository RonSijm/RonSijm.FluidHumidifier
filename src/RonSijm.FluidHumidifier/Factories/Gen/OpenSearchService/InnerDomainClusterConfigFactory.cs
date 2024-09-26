// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainClusterConfigFactory(Action<Humidifier.OpenSearchService.DomainTypes.ClusterConfig> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.ClusterConfig>
{

    internal InnerDomainZoneAwarenessConfigFactory ZoneAwarenessConfigFactory { get; set; }

    internal InnerDomainColdStorageOptionsFactory ColdStorageOptionsFactory { get; set; }

    protected override Humidifier.OpenSearchService.DomainTypes.ClusterConfig Create()
    {
        var clusterConfigResult = CreateClusterConfig();
        factoryAction?.Invoke(clusterConfigResult);

        return clusterConfigResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.ClusterConfig CreateClusterConfig()
    {
        var clusterConfigResult = new Humidifier.OpenSearchService.DomainTypes.ClusterConfig();

        return clusterConfigResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchService.DomainTypes.ClusterConfig result)
    {
        base.CreateChildren(result);

        result.ZoneAwarenessConfig ??= ZoneAwarenessConfigFactory?.Build();
        result.ColdStorageOptions ??= ColdStorageOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDomainClusterConfigFactoryExtensions
{
    public static CombinedResult<InnerDomainClusterConfigFactory, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig(this InnerDomainClusterConfigFactory parentFactory, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null)
    {
        parentFactory.ZoneAwarenessConfigFactory = new InnerDomainZoneAwarenessConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ZoneAwarenessConfigFactory);
    }

    public static CombinedResult<InnerDomainClusterConfigFactory, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions(this InnerDomainClusterConfigFactory parentFactory, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null)
    {
        parentFactory.ColdStorageOptionsFactory = new InnerDomainColdStorageOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ColdStorageOptionsFactory);
    }

    public static CombinedResult<InnerDomainClusterConfigFactory, T1, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1>(this CombinedResult<InnerDomainClusterConfigFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1>(this CombinedResult<T1, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainClusterConfigFactory, T1, T2, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2>(this CombinedResult<InnerDomainClusterConfigFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, T2, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2>(this CombinedResult<T1, InnerDomainClusterConfigFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainClusterConfigFactory, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2>(this CombinedResult<T1, T2, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3>(this CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3>(this CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3, T4, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3, T4>(this CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3, T4, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3, T4, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory, T4, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainClusterConfigFactory, InnerDomainZoneAwarenessConfigFactory> WithZoneAwarenessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ZoneAwarenessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithZoneAwarenessConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDomainClusterConfigFactory, T1, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1>(this CombinedResult<InnerDomainClusterConfigFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1>(this CombinedResult<T1, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainClusterConfigFactory, T1, T2, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2>(this CombinedResult<InnerDomainClusterConfigFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, T2, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2>(this CombinedResult<T1, InnerDomainClusterConfigFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainClusterConfigFactory, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2>(this CombinedResult<T1, T2, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3>(this CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3>(this CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3, T4, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3, T4>(this CombinedResult<InnerDomainClusterConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3, T4, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainClusterConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3, T4, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainClusterConfigFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory, T4, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainClusterConfigFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainClusterConfigFactory, InnerDomainColdStorageOptionsFactory> WithColdStorageOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainClusterConfigFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.ColdStorageOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColdStorageOptions(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class BridgeFactory(string resourceName = null, Action<Humidifier.MediaConnect.Bridge> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.Bridge>(resourceName)
{

    internal List<InnerBridgeBridgeOutputFactory> OutputsFactories { get; set; } = [];

    internal List<InnerBridgeBridgeSourceFactory> SourcesFactories { get; set; } = [];

    internal InnerBridgeFailoverConfigFactory SourceFailoverConfigFactory { get; set; }

    internal InnerBridgeIngressGatewayBridgeFactory IngressGatewayBridgeFactory { get; set; }

    internal InnerBridgeEgressGatewayBridgeFactory EgressGatewayBridgeFactory { get; set; }

    protected override Humidifier.MediaConnect.Bridge Create()
    {
        var bridgeResult = CreateBridge();
        factoryAction?.Invoke(bridgeResult);

        return bridgeResult;
    }

    private Humidifier.MediaConnect.Bridge CreateBridge()
    {
        var bridgeResult = new Humidifier.MediaConnect.Bridge
        {
            GivenName = InputResourceName,
        };

        return bridgeResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.Bridge result)
    {
        base.CreateChildren(result);

        result.Outputs = OutputsFactories.Any() ? OutputsFactories.Select(x => x.Build()).ToList() : null;
        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
        result.SourceFailoverConfig ??= SourceFailoverConfigFactory?.Build();
        result.IngressGatewayBridge ??= IngressGatewayBridgeFactory?.Build();
        result.EgressGatewayBridge ??= EgressGatewayBridgeFactory?.Build();
    }

} // End Of Class

public static class BridgeFactoryExtensions
{
    public static CombinedResult<BridgeFactory, InnerBridgeBridgeOutputFactory> WithOutputs(this BridgeFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null)
    {
        var factory = new InnerBridgeBridgeOutputFactory(subFactoryAction);
        parentFactory.OutputsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BridgeFactory, InnerBridgeBridgeSourceFactory> WithSources(this BridgeFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null)
    {
        var factory = new InnerBridgeBridgeSourceFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BridgeFactory, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig(this BridgeFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null)
    {
        parentFactory.SourceFailoverConfigFactory = new InnerBridgeFailoverConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFailoverConfigFactory);
    }

    public static CombinedResult<BridgeFactory, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge(this BridgeFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null)
    {
        parentFactory.IngressGatewayBridgeFactory = new InnerBridgeIngressGatewayBridgeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IngressGatewayBridgeFactory);
    }

    public static CombinedResult<BridgeFactory, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge(this BridgeFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null)
    {
        parentFactory.EgressGatewayBridgeFactory = new InnerBridgeEgressGatewayBridgeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EgressGatewayBridgeFactory);
    }

    public static CombinedResult<BridgeFactory, T1, InnerBridgeBridgeOutputFactory> WithOutputs<T1>(this CombinedResult<BridgeFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, InnerBridgeBridgeOutputFactory> WithOutputs<T1>(this CombinedResult<T1, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2>(this CombinedResult<BridgeFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2>(this CombinedResult<T1, BridgeFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2>(this CombinedResult<T1, T2, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<BridgeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, BridgeFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, T2, BridgeFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, T4, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<BridgeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, T4, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, BridgeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, T4, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, T4, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeFactory, InnerBridgeBridgeOutputFactory> WithOutputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputs(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, InnerBridgeBridgeSourceFactory> WithSources<T1>(this CombinedResult<BridgeFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, InnerBridgeBridgeSourceFactory> WithSources<T1>(this CombinedResult<T1, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, InnerBridgeBridgeSourceFactory> WithSources<T1, T2>(this CombinedResult<BridgeFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, InnerBridgeBridgeSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, BridgeFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, InnerBridgeBridgeSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<BridgeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, BridgeFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, BridgeFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, T4, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<BridgeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, T4, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, BridgeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, T4, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, T4, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeFactory, InnerBridgeBridgeSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1>(this CombinedResult<BridgeFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1>(this CombinedResult<T1, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2>(this CombinedResult<BridgeFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2>(this CombinedResult<T1, BridgeFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2>(this CombinedResult<T1, T2, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3>(this CombinedResult<BridgeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3>(this CombinedResult<T1, BridgeFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3>(this CombinedResult<T1, T2, BridgeFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, T4, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3, T4>(this CombinedResult<BridgeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, T4, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, BridgeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, T4, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, T4, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeFactory, InnerBridgeFailoverConfigFactory> WithSourceFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceFailoverConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1>(this CombinedResult<BridgeFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1>(this CombinedResult<T1, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2>(this CombinedResult<BridgeFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2>(this CombinedResult<T1, BridgeFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2>(this CombinedResult<T1, T2, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3>(this CombinedResult<BridgeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3>(this CombinedResult<T1, BridgeFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3>(this CombinedResult<T1, T2, BridgeFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, T4, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<BridgeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, T4, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, BridgeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, T4, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, T4, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeFactory, InnerBridgeIngressGatewayBridgeFactory> WithIngressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.IngressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIngressGatewayBridge(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1>(this CombinedResult<BridgeFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1>(this CombinedResult<T1, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2>(this CombinedResult<BridgeFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2>(this CombinedResult<T1, BridgeFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2>(this CombinedResult<T1, T2, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3>(this CombinedResult<BridgeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3>(this CombinedResult<T1, BridgeFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3>(this CombinedResult<T1, T2, BridgeFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeFactory, T1, T2, T3, T4, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<BridgeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeFactory, T2, T3, T4, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, BridgeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeFactory, T3, T4, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeFactory, T4, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeFactory, InnerBridgeEgressGatewayBridgeFactory> WithEgressGatewayBridge<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.EgressGatewayBridge> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEgressGatewayBridge(combinedResult.T5, subFactoryAction));
}

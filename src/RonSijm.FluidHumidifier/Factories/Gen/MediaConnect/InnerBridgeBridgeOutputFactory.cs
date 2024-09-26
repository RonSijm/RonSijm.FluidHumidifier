// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeBridgeOutputFactory(Action<Humidifier.MediaConnect.BridgeTypes.BridgeOutput> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.BridgeOutput>
{

    internal InnerBridgeBridgeNetworkOutputFactory NetworkOutputFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeTypes.BridgeOutput Create()
    {
        var bridgeOutputResult = CreateBridgeOutput();
        factoryAction?.Invoke(bridgeOutputResult);

        return bridgeOutputResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.BridgeOutput CreateBridgeOutput()
    {
        var bridgeOutputResult = new Humidifier.MediaConnect.BridgeTypes.BridgeOutput();

        return bridgeOutputResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeTypes.BridgeOutput result)
    {
        base.CreateChildren(result);

        result.NetworkOutput ??= NetworkOutputFactory?.Build();
    }

} // End Of Class

public static class InnerBridgeBridgeOutputFactoryExtensions
{
    public static CombinedResult<InnerBridgeBridgeOutputFactory, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput(this InnerBridgeBridgeOutputFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null)
    {
        parentFactory.NetworkOutputFactory = new InnerBridgeBridgeNetworkOutputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkOutputFactory);
    }

    public static CombinedResult<InnerBridgeBridgeOutputFactory, T1, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1>(this CombinedResult<InnerBridgeBridgeOutputFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeOutputFactory, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1>(this CombinedResult<T1, InnerBridgeBridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeOutputFactory, T1, T2, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2>(this CombinedResult<InnerBridgeBridgeOutputFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeOutputFactory, T2, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2>(this CombinedResult<T1, InnerBridgeBridgeOutputFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeOutputFactory, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2>(this CombinedResult<T1, T2, InnerBridgeBridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeOutputFactory, T1, T2, T3, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<InnerBridgeBridgeOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeOutputFactory, T2, T3, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<T1, InnerBridgeBridgeOutputFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeOutputFactory, T3, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeBridgeOutputFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeOutputFactory, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeOutputFactory, T1, T2, T3, T4, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<InnerBridgeBridgeOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeOutputFactory, T2, T3, T4, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeBridgeOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeOutputFactory, T3, T4, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeBridgeOutputFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeOutputFactory, T4, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeOutputFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeOutputFactory, InnerBridgeBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T5, subFactoryAction));
}

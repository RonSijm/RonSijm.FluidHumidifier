// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class BridgeOutputFactory(string resourceName = null, Action<Humidifier.MediaConnect.BridgeOutput> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.BridgeOutput>(resourceName)
{

    internal InnerBridgeOutputBridgeNetworkOutputFactory NetworkOutputFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeOutput Create()
    {
        var bridgeOutputResult = CreateBridgeOutput();
        factoryAction?.Invoke(bridgeOutputResult);

        return bridgeOutputResult;
    }

    private Humidifier.MediaConnect.BridgeOutput CreateBridgeOutput()
    {
        var bridgeOutputResult = new Humidifier.MediaConnect.BridgeOutput
        {
            GivenName = InputResourceName,
        };

        return bridgeOutputResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeOutput result)
    {
        base.CreateChildren(result);

        result.NetworkOutput ??= NetworkOutputFactory?.Build();
    }

} // End Of Class

public static class BridgeOutputFactoryExtensions
{
    public static CombinedResult<BridgeOutputFactory, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput(this BridgeOutputFactory parentFactory, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null)
    {
        parentFactory.NetworkOutputFactory = new InnerBridgeOutputBridgeNetworkOutputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkOutputFactory);
    }

    public static CombinedResult<BridgeOutputFactory, T1, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1>(this CombinedResult<BridgeOutputFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeOutputFactory, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1>(this CombinedResult<T1, BridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeOutputFactory, T1, T2, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2>(this CombinedResult<BridgeOutputFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeOutputFactory, T2, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2>(this CombinedResult<T1, BridgeOutputFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeOutputFactory, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2>(this CombinedResult<T1, T2, BridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeOutputFactory, T1, T2, T3, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<BridgeOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeOutputFactory, T2, T3, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<T1, BridgeOutputFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeOutputFactory, T3, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<T1, T2, BridgeOutputFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeOutputFactory, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeOutputFactory, T1, T2, T3, T4, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<BridgeOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeOutputFactory, T2, T3, T4, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, BridgeOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeOutputFactory, T3, T4, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeOutputFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeOutputFactory, T4, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeOutputFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeOutputFactory, InnerBridgeOutputBridgeNetworkOutputFactory> WithNetworkOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeOutputFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkOutput(combinedResult.T5, subFactoryAction));
}

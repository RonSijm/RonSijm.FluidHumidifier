// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class FlowSourceFactory(string resourceName = null, Action<Humidifier.MediaConnect.FlowSource> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.FlowSource>(resourceName)
{

    internal InnerFlowSourceEncryptionFactory DecryptionFactory { get; set; }

    internal InnerFlowSourceGatewayBridgeSourceFactory GatewayBridgeSourceFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowSource Create()
    {
        var flowSourceResult = CreateFlowSource();
        factoryAction?.Invoke(flowSourceResult);

        return flowSourceResult;
    }

    private Humidifier.MediaConnect.FlowSource CreateFlowSource()
    {
        var flowSourceResult = new Humidifier.MediaConnect.FlowSource
        {
            GivenName = InputResourceName,
        };

        return flowSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowSource result)
    {
        base.CreateChildren(result);

        result.Decryption ??= DecryptionFactory?.Build();
        result.GatewayBridgeSource ??= GatewayBridgeSourceFactory?.Build();
    }

} // End Of Class

public static class FlowSourceFactoryExtensions
{
    public static CombinedResult<FlowSourceFactory, InnerFlowSourceEncryptionFactory> WithDecryption(this FlowSourceFactory parentFactory, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null)
    {
        parentFactory.DecryptionFactory = new InnerFlowSourceEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DecryptionFactory);
    }

    public static CombinedResult<FlowSourceFactory, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource(this FlowSourceFactory parentFactory, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null)
    {
        parentFactory.GatewayBridgeSourceFactory = new InnerFlowSourceGatewayBridgeSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GatewayBridgeSourceFactory);
    }

    public static CombinedResult<FlowSourceFactory, T1, InnerFlowSourceEncryptionFactory> WithDecryption<T1>(this CombinedResult<FlowSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, InnerFlowSourceEncryptionFactory> WithDecryption<T1>(this CombinedResult<T1, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowSourceFactory, T1, T2, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2>(this CombinedResult<FlowSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, T2, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2>(this CombinedResult<T1, FlowSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowSourceFactory, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2>(this CombinedResult<T1, T2, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowSourceFactory, T1, T2, T3, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<FlowSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, T2, T3, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, FlowSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowSourceFactory, T3, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, FlowSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowSourceFactory, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowSourceFactory, T1, T2, T3, T4, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<FlowSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, T2, T3, T4, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, FlowSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowSourceFactory, T3, T4, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowSourceFactory, T4, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowSourceFactory, InnerFlowSourceEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FlowSourceFactory, T1, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1>(this CombinedResult<FlowSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1>(this CombinedResult<T1, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlowSourceFactory, T1, T2, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2>(this CombinedResult<FlowSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, T2, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2>(this CombinedResult<T1, FlowSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowSourceFactory, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2>(this CombinedResult<T1, T2, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlowSourceFactory, T1, T2, T3, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<FlowSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, T2, T3, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<T1, FlowSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowSourceFactory, T3, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<T1, T2, FlowSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowSourceFactory, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlowSourceFactory, T1, T2, T3, T4, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<FlowSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlowSourceFactory, T2, T3, T4, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, FlowSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlowSourceFactory, T3, T4, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlowSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlowSourceFactory, T4, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlowSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlowSourceFactory, InnerFlowSourceGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T5, subFactoryAction));
}

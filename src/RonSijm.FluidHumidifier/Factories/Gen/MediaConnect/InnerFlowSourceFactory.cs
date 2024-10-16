// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowSourceFactory(Action<Humidifier.MediaConnect.FlowTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.Source>
{

    internal InnerFlowEncryptionFactory DecryptionFactory { get; set; }

    internal InnerFlowGatewayBridgeSourceFactory GatewayBridgeSourceFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.MediaConnect.FlowTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.MediaConnect.FlowTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowTypes.Source result)
    {
        base.CreateChildren(result);

        result.Decryption ??= DecryptionFactory?.Build();
        result.GatewayBridgeSource ??= GatewayBridgeSourceFactory?.Build();
    }

} // End Of Class

public static class InnerFlowSourceFactoryExtensions
{
    public static CombinedResult<InnerFlowSourceFactory, InnerFlowEncryptionFactory> WithDecryption(this InnerFlowSourceFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null)
    {
        parentFactory.DecryptionFactory = new InnerFlowEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DecryptionFactory);
    }

    public static CombinedResult<InnerFlowSourceFactory, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource(this InnerFlowSourceFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null)
    {
        parentFactory.GatewayBridgeSourceFactory = new InnerFlowGatewayBridgeSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GatewayBridgeSourceFactory);
    }

    public static CombinedResult<InnerFlowSourceFactory, T1, InnerFlowEncryptionFactory> WithDecryption<T1>(this CombinedResult<InnerFlowSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, InnerFlowEncryptionFactory> WithDecryption<T1>(this CombinedResult<T1, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFactory, T1, T2, InnerFlowEncryptionFactory> WithDecryption<T1, T2>(this CombinedResult<InnerFlowSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, T2, InnerFlowEncryptionFactory> WithDecryption<T1, T2>(this CombinedResult<T1, InnerFlowSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFactory, InnerFlowEncryptionFactory> WithDecryption<T1, T2>(this CombinedResult<T1, T2, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFactory, T1, T2, T3, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<InnerFlowSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, T2, T3, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, InnerFlowSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFactory, T3, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFactory, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFactory, T1, T2, T3, T4, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<InnerFlowSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, T2, T3, T4, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFactory, T3, T4, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFactory, T4, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSourceFactory, InnerFlowEncryptionFactory> WithDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDecryption(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFactory, T1, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1>(this CombinedResult<InnerFlowSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1>(this CombinedResult<T1, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFactory, T1, T2, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2>(this CombinedResult<InnerFlowSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, T2, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2>(this CombinedResult<T1, InnerFlowSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFactory, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2>(this CombinedResult<T1, T2, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFactory, T1, T2, T3, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<InnerFlowSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, T2, T3, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<T1, InnerFlowSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFactory, T3, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFactory, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSourceFactory, T1, T2, T3, T4, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<InnerFlowSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceFactory, T2, T3, T4, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceFactory, T3, T4, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceFactory, T4, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSourceFactory, InnerFlowGatewayBridgeSourceFactory> WithGatewayBridgeSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayBridgeSource(combinedResult.T5, subFactoryAction));
}

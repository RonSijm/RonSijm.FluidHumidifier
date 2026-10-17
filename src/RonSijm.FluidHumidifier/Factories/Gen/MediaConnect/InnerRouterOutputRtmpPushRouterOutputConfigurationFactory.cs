// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputRtmpPushRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.RtmpPushRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.RtmpPushRouterOutputConfiguration>
{

    internal InnerRouterOutputTlsEncryptionFactory TlsEncryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.RtmpPushRouterOutputConfiguration Create()
    {
        var rtmpPushRouterOutputConfigurationResult = CreateRtmpPushRouterOutputConfiguration();
        factoryAction?.Invoke(rtmpPushRouterOutputConfigurationResult);

        return rtmpPushRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.RtmpPushRouterOutputConfiguration CreateRtmpPushRouterOutputConfiguration()
    {
        var rtmpPushRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.RtmpPushRouterOutputConfiguration();

        return rtmpPushRouterOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.RtmpPushRouterOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.TlsEncryption ??= TlsEncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputRtmpPushRouterOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption(this InnerRouterOutputRtmpPushRouterOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null)
    {
        parentFactory.TlsEncryptionFactory = new InnerRouterOutputTlsEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TlsEncryptionFactory);
    }

    public static CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1>(this CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithTlsEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1>(this CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithTlsEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1, T2, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2>(this CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T2, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2>(this CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1, T2, T3, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3>(this CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T2, T3, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T3, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T2, T3, T4, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T3, T4, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T4, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory, InnerRouterOutputTlsEncryptionFactory> WithTlsEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputRtmpPushRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.TlsEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTlsEncryption(combinedResult.T5, subFactoryAction).T2);
}

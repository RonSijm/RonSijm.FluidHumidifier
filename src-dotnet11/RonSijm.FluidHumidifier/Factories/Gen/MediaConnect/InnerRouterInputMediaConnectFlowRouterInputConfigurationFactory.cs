// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration>
{

    internal InnerRouterInputFlowTransitEncryptionFactory SourceTransitDecryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration Create()
    {
        var mediaConnectFlowRouterInputConfigurationResult = CreateMediaConnectFlowRouterInputConfiguration();
        factoryAction?.Invoke(mediaConnectFlowRouterInputConfigurationResult);

        return mediaConnectFlowRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration CreateMediaConnectFlowRouterInputConfiguration()
    {
        var mediaConnectFlowRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration();

        return mediaConnectFlowRouterInputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.MediaConnectFlowRouterInputConfiguration result)
    {
        base.CreateChildren(result);

        result.SourceTransitDecryption ??= SourceTransitDecryptionFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputMediaConnectFlowRouterInputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption(this InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null)
    {
        parentFactory.SourceTransitDecryptionFactory = new InnerRouterInputFlowTransitEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceTransitDecryptionFactory);
    }

    public static CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1>(this CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1>(this CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1, T2, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T2, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1, T2, T3, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T2, T3, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T3, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1, T2, T3, T4, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T2, T3, T4, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T3, T4, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T4, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory, InnerRouterInputFlowTransitEncryptionFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputMediaConnectFlowRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T5, subFactoryAction).T2);
}

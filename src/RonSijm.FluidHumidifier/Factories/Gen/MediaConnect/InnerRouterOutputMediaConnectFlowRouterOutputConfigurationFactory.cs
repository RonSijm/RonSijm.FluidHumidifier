// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.MediaConnectFlowRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.MediaConnectFlowRouterOutputConfiguration>
{

    internal InnerRouterOutputFlowTransitEncryptionFactory DestinationTransitEncryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.MediaConnectFlowRouterOutputConfiguration Create()
    {
        var mediaConnectFlowRouterOutputConfigurationResult = CreateMediaConnectFlowRouterOutputConfiguration();
        factoryAction?.Invoke(mediaConnectFlowRouterOutputConfigurationResult);

        return mediaConnectFlowRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.MediaConnectFlowRouterOutputConfiguration CreateMediaConnectFlowRouterOutputConfiguration()
    {
        var mediaConnectFlowRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.MediaConnectFlowRouterOutputConfiguration();

        return mediaConnectFlowRouterOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.MediaConnectFlowRouterOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.DestinationTransitEncryption ??= DestinationTransitEncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption(this InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null)
    {
        parentFactory.DestinationTransitEncryptionFactory = new InnerRouterOutputFlowTransitEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationTransitEncryptionFactory);
    }

    public static CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1>(this CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1>(this CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1, T2, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T2, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1, T2, T3, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T2, T3, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T3, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T3, T4, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T4, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory, InnerRouterOutputFlowTransitEncryptionFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputMediaConnectFlowRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T5, subFactoryAction).T2);
}

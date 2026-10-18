// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputFlowTransitEncryptionFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption>
{

    internal InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory EncryptionKeyConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption Create()
    {
        var flowTransitEncryptionResult = CreateFlowTransitEncryption();
        factoryAction?.Invoke(flowTransitEncryptionResult);

        return flowTransitEncryptionResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption CreateFlowTransitEncryption()
    {
        var flowTransitEncryptionResult = new Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption();

        return flowTransitEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionKeyConfiguration ??= EncryptionKeyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputFlowTransitEncryptionFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration(this InnerRouterOutputFlowTransitEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyConfigurationFactory = new InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyConfigurationFactory);
    }

    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionFactory, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1, T2, T3, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory, T2, T3, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionFactory, T3, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionFactory, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionFactory, T3, T4, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionFactory, T4, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionFactory, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T5, subFactoryAction).T2);
}

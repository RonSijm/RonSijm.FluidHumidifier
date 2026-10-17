// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputFlowTransitEncryptionFactory(Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption>
{

    internal InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory EncryptionKeyConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption Create()
    {
        var flowTransitEncryptionResult = CreateFlowTransitEncryption();
        factoryAction?.Invoke(flowTransitEncryptionResult);

        return flowTransitEncryptionResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption CreateFlowTransitEncryption()
    {
        var flowTransitEncryptionResult = new Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption();

        return flowTransitEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionKeyConfiguration ??= EncryptionKeyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputFlowTransitEncryptionFactoryExtensions
{
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration(this InnerRouterInputFlowTransitEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyConfigurationFactory = new InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyConfigurationFactory);
    }

    public static CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionFactory, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1, T2, T3, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory, T2, T3, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionFactory, T3, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionFactory, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1, T2, T3, T4, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputFlowTransitEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory, T2, T3, T4, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionFactory, T3, T4, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionFactory, T4, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputFlowTransitEncryptionFactory, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T5, subFactoryAction).T2);
}

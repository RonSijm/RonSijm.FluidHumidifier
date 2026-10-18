// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowOutputFlowTransitEncryptionFactory(Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryption>
{

    internal InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory EncryptionKeyConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryption Create()
    {
        var flowTransitEncryptionResult = CreateFlowTransitEncryption();
        factoryAction?.Invoke(flowTransitEncryptionResult);

        return flowTransitEncryptionResult;
    }

    private Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryption CreateFlowTransitEncryption()
    {
        var flowTransitEncryptionResult = new Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryption();

        return flowTransitEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionKeyConfiguration ??= EncryptionKeyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFlowOutputFlowTransitEncryptionFactoryExtensions
{
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration(this InnerFlowOutputFlowTransitEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyConfigurationFactory = new InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyConfigurationFactory);
    }

    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionFactory, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1, T2, T3, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory, T2, T3, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionFactory, T3, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionFactory, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1, T2, T3, T4, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory, T2, T3, T4, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionFactory, T3, T4, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionFactory, T4, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFlowOutputFlowTransitEncryptionFactory, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowOutputFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T5, subFactoryAction).T2);
}

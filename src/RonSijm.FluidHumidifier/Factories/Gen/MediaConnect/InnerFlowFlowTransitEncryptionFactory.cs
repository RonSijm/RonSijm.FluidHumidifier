// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowFlowTransitEncryptionFactory(Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption>
{

    internal InnerFlowFlowTransitEncryptionKeyConfigurationFactory EncryptionKeyConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption Create()
    {
        var flowTransitEncryptionResult = CreateFlowTransitEncryption();
        factoryAction?.Invoke(flowTransitEncryptionResult);

        return flowTransitEncryptionResult;
    }

    private Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption CreateFlowTransitEncryption()
    {
        var flowTransitEncryptionResult = new Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption();

        return flowTransitEncryptionResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowTypes.FlowTransitEncryption result)
    {
        base.CreateChildren(result);

        result.EncryptionKeyConfiguration ??= EncryptionKeyConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerFlowFlowTransitEncryptionFactoryExtensions
{
    public static CombinedResult<InnerFlowFlowTransitEncryptionFactory, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration(this InnerFlowFlowTransitEncryptionFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionKeyConfigurationFactory = new InnerFlowFlowTransitEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionKeyConfigurationFactory);
    }

    public static CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionFactory, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1, T2, T3, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory, T2, T3, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionFactory, T3, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionFactory, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1, T2, T3, T4, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerFlowFlowTransitEncryptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory, T2, T3, T4, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionFactory, T3, T4, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionFactory, T4, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFlowFlowTransitEncryptionFactory, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> WithEncryptionKeyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowFlowTransitEncryptionFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionKeyConfiguration(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration>
{

    internal InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration Create()
    {
        var flowTransitEncryptionKeyConfigurationResult = CreateFlowTransitEncryptionKeyConfiguration();
        factoryAction?.Invoke(flowTransitEncryptionKeyConfigurationResult);

        return flowTransitEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration CreateFlowTransitEncryptionKeyConfiguration()
    {
        var flowTransitEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration();

        return flowTransitEncryptionKeyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowOutputTypes.FlowTransitEncryptionKeyConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager(this InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T2, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T3, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T3, T4, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T4, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory, InnerFlowOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}

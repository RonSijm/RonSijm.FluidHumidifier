// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowFlowTransitEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration>
{

    internal InnerFlowSecretsManagerEncryptionKeyConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration Create()
    {
        var flowTransitEncryptionKeyConfigurationResult = CreateFlowTransitEncryptionKeyConfiguration();
        factoryAction?.Invoke(flowTransitEncryptionKeyConfigurationResult);

        return flowTransitEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration CreateFlowTransitEncryptionKeyConfiguration()
    {
        var flowTransitEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration();

        return flowTransitEncryptionKeyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowTypes.FlowTransitEncryptionKeyConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerFlowFlowTransitEncryptionKeyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager(this InnerFlowFlowTransitEncryptionKeyConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerFlowSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1, T2, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T2, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T2, T3, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T3, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T3, T4, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T4, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerFlowFlowTransitEncryptionKeyConfigurationFactory, InnerFlowSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}

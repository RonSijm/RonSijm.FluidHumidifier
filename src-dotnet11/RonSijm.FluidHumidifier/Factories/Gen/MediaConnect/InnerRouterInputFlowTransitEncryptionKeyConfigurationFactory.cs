// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration>
{

    internal InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration Create()
    {
        var flowTransitEncryptionKeyConfigurationResult = CreateFlowTransitEncryptionKeyConfiguration();
        factoryAction?.Invoke(flowTransitEncryptionKeyConfigurationResult);

        return flowTransitEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration CreateFlowTransitEncryptionKeyConfiguration()
    {
        var flowTransitEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration();

        return flowTransitEncryptionKeyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.FlowTransitEncryptionKeyConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputFlowTransitEncryptionKeyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager(this InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T2, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T3, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T3, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T4, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterInputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}

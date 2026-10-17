// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration>
{

    internal InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory SecretsManagerFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration Create()
    {
        var flowTransitEncryptionKeyConfigurationResult = CreateFlowTransitEncryptionKeyConfiguration();
        factoryAction?.Invoke(flowTransitEncryptionKeyConfigurationResult);

        return flowTransitEncryptionKeyConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration CreateFlowTransitEncryptionKeyConfiguration()
    {
        var flowTransitEncryptionKeyConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration();

        return flowTransitEncryptionKeyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.FlowTransitEncryptionKeyConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManager ??= SecretsManagerFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager(this InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerFactory = new InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerFactory);
    }

    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T2, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T3, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T3, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T4, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory, InnerRouterOutputSecretsManagerEncryptionKeyConfigurationFactory> WithSecretsManager<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputFlowTransitEncryptionKeyConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.SecretsManagerEncryptionKeyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManager(combinedResult.T5, subFactoryAction).T2);
}

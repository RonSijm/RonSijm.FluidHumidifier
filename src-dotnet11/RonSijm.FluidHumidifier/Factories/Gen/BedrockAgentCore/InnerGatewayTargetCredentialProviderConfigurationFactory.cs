// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetCredentialProviderConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration>
{

    internal InnerGatewayTargetCredentialProviderFactory CredentialProviderFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration Create()
    {
        var credentialProviderConfigurationResult = CreateCredentialProviderConfiguration();
        factoryAction?.Invoke(credentialProviderConfigurationResult);

        return credentialProviderConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration CreateCredentialProviderConfiguration()
    {
        var credentialProviderConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration();

        return credentialProviderConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration result)
    {
        base.CreateChildren(result);

        result.CredentialProvider ??= CredentialProviderFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayTargetCredentialProviderConfigurationFactoryExtensions
{
    public static CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider(this InnerGatewayTargetCredentialProviderConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null)
    {
        parentFactory.CredentialProviderFactory = new InnerGatewayTargetCredentialProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialProviderFactory);
    }

    public static CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1>(this CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentialProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1>(this CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentialProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1, T2, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2>(this CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory, T2, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2>(this CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetCredentialProviderConfigurationFactory, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2>(this CombinedResult<T1, T2, InnerGatewayTargetCredentialProviderConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1, T2, T3, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3>(this CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory, T2, T3, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3>(this CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetCredentialProviderConfigurationFactory, T3, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayTargetCredentialProviderConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetCredentialProviderConfigurationFactory, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayTargetCredentialProviderConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1, T2, T3, T4, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3, T4>(this CombinedResult<InnerGatewayTargetCredentialProviderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory, T2, T3, T4, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayTargetCredentialProviderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayTargetCredentialProviderConfigurationFactory, T3, T4, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayTargetCredentialProviderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayTargetCredentialProviderConfigurationFactory, T4, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayTargetCredentialProviderConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayTargetCredentialProviderConfigurationFactory, InnerGatewayTargetCredentialProviderFactory> WithCredentialProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayTargetCredentialProviderConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialProvider(combinedResult.T5, subFactoryAction).T2);
}

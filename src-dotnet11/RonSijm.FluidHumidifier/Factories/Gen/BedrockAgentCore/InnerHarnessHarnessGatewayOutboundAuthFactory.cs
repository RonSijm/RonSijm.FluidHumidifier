// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessGatewayOutboundAuthFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth>
{

    internal InnerHarnessOAuthCredentialProviderFactory OauthFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth Create()
    {
        var harnessGatewayOutboundAuthResult = CreateHarnessGatewayOutboundAuth();
        factoryAction?.Invoke(harnessGatewayOutboundAuthResult);

        return harnessGatewayOutboundAuthResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth CreateHarnessGatewayOutboundAuth()
    {
        var harnessGatewayOutboundAuthResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth();

        return harnessGatewayOutboundAuthResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessGatewayOutboundAuth result)
    {
        base.CreateChildren(result);

        result.Oauth ??= OauthFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessGatewayOutboundAuthFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, InnerHarnessOAuthCredentialProviderFactory> WithOauth(this InnerHarnessHarnessGatewayOutboundAuthFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null)
    {
        parentFactory.OauthFactory = new InnerHarnessOAuthCredentialProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OauthFactory);
    }

    public static CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1>(this CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithOauth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1>(this CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithOauth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1, T2, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2>(this CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory, T2, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessGatewayOutboundAuthFactory, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessGatewayOutboundAuthFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1, T2, T3, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory, T2, T3, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessGatewayOutboundAuthFactory, T3, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessGatewayOutboundAuthFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessGatewayOutboundAuthFactory, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessGatewayOutboundAuthFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1, T2, T3, T4, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessGatewayOutboundAuthFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory, T2, T3, T4, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessGatewayOutboundAuthFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessGatewayOutboundAuthFactory, T3, T4, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessGatewayOutboundAuthFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessGatewayOutboundAuthFactory, T4, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessGatewayOutboundAuthFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessGatewayOutboundAuthFactory, InnerHarnessOAuthCredentialProviderFactory> WithOauth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessGatewayOutboundAuthFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOauth(combinedResult.T5, subFactoryAction).T2);
}

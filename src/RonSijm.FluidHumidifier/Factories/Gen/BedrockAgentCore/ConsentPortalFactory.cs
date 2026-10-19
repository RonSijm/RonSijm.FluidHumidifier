// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class ConsentPortalFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.ConsentPortal> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.ConsentPortal>(resourceName)
{

    internal List<InnerConsentPortalConsentPortalSourceFactory> SourcesFactories { get; set; } = [];

    internal InnerConsentPortalIdpConfigFactory IdpConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.ConsentPortal Create()
    {
        var consentPortalResult = CreateConsentPortal();
        factoryAction?.Invoke(consentPortalResult);

        return consentPortalResult;
    }

    private Humidifier.BedrockAgentCore.ConsentPortal CreateConsentPortal()
    {
        var consentPortalResult = new Humidifier.BedrockAgentCore.ConsentPortal
        {
            GivenName = InputResourceName,
        };

        return consentPortalResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.ConsentPortal result)
    {
        base.CreateChildren(result);

        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
        result.IdpConfig ??= IdpConfigFactory?.Build();
    }

} // End Of Class

public static class ConsentPortalFactoryExtensions
{
    public static CombinedResult<ConsentPortalFactory, InnerConsentPortalConsentPortalSourceFactory> WithSources(this ConsentPortalFactory parentFactory, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null)
    {
        var factory = new InnerConsentPortalConsentPortalSourceFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConsentPortalFactory, InnerConsentPortalIdpConfigFactory> WithIdpConfig(this ConsentPortalFactory parentFactory, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null)
    {
        parentFactory.IdpConfigFactory = new InnerConsentPortalIdpConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdpConfigFactory);
    }

    public static CombinedResult<ConsentPortalFactory, T1, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1>(this CombinedResult<ConsentPortalFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1>(this CombinedResult<T1, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConsentPortalFactory, T1, T2, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2>(this CombinedResult<ConsentPortalFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, T2, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, ConsentPortalFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConsentPortalFactory, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConsentPortalFactory, T1, T2, T3, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<ConsentPortalFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, T2, T3, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, ConsentPortalFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConsentPortalFactory, T3, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, ConsentPortalFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConsentPortalFactory, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConsentPortalFactory, T1, T2, T3, T4, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<ConsentPortalFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, T2, T3, T4, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, ConsentPortalFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConsentPortalFactory, T3, T4, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConsentPortalFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConsentPortalFactory, T4, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConsentPortalFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConsentPortalFactory, InnerConsentPortalConsentPortalSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ConsentPortalFactory, T1, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1>(this CombinedResult<ConsentPortalFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdpConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1>(this CombinedResult<T1, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdpConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConsentPortalFactory, T1, T2, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2>(this CombinedResult<ConsentPortalFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, T2, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2>(this CombinedResult<T1, ConsentPortalFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConsentPortalFactory, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2>(this CombinedResult<T1, T2, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConsentPortalFactory, T1, T2, T3, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3>(this CombinedResult<ConsentPortalFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, T2, T3, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3>(this CombinedResult<T1, ConsentPortalFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConsentPortalFactory, T3, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3>(this CombinedResult<T1, T2, ConsentPortalFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConsentPortalFactory, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConsentPortalFactory, T1, T2, T3, T4, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3, T4>(this CombinedResult<ConsentPortalFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConsentPortalFactory, T2, T3, T4, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3, T4>(this CombinedResult<T1, ConsentPortalFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConsentPortalFactory, T3, T4, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConsentPortalFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConsentPortalFactory, T4, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConsentPortalFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConsentPortalFactory, InnerConsentPortalIdpConfigFactory> WithIdpConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConsentPortalFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdpConfig(combinedResult.T5, subFactoryAction).T2);
}

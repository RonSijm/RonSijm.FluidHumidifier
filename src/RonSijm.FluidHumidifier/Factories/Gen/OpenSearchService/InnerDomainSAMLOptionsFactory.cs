// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainSAMLOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.SAMLOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.SAMLOptions>
{

    internal InnerDomainIdpFactory IdpFactory { get; set; }

    protected override Humidifier.OpenSearchService.DomainTypes.SAMLOptions Create()
    {
        var sAMLOptionsResult = CreateSAMLOptions();
        factoryAction?.Invoke(sAMLOptionsResult);

        return sAMLOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.SAMLOptions CreateSAMLOptions()
    {
        var sAMLOptionsResult = new Humidifier.OpenSearchService.DomainTypes.SAMLOptions();

        return sAMLOptionsResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchService.DomainTypes.SAMLOptions result)
    {
        base.CreateChildren(result);

        result.Idp ??= IdpFactory?.Build();
    }

} // End Of Class

public static class InnerDomainSAMLOptionsFactoryExtensions
{
    public static CombinedResult<InnerDomainSAMLOptionsFactory, InnerDomainIdpFactory> WithIdp(this InnerDomainSAMLOptionsFactory parentFactory, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null)
    {
        parentFactory.IdpFactory = new InnerDomainIdpFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdpFactory);
    }

    public static CombinedResult<InnerDomainSAMLOptionsFactory, T1, InnerDomainIdpFactory> WithIdp<T1>(this CombinedResult<InnerDomainSAMLOptionsFactory, T1> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainSAMLOptionsFactory, InnerDomainIdpFactory> WithIdp<T1>(this CombinedResult<T1, InnerDomainSAMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainSAMLOptionsFactory, T1, T2, InnerDomainIdpFactory> WithIdp<T1, T2>(this CombinedResult<InnerDomainSAMLOptionsFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainSAMLOptionsFactory, T2, InnerDomainIdpFactory> WithIdp<T1, T2>(this CombinedResult<T1, InnerDomainSAMLOptionsFactory, T2> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainSAMLOptionsFactory, InnerDomainIdpFactory> WithIdp<T1, T2>(this CombinedResult<T1, T2, InnerDomainSAMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainSAMLOptionsFactory, T1, T2, T3, InnerDomainIdpFactory> WithIdp<T1, T2, T3>(this CombinedResult<InnerDomainSAMLOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainSAMLOptionsFactory, T2, T3, InnerDomainIdpFactory> WithIdp<T1, T2, T3>(this CombinedResult<T1, InnerDomainSAMLOptionsFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainSAMLOptionsFactory, T3, InnerDomainIdpFactory> WithIdp<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainSAMLOptionsFactory, T3> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainSAMLOptionsFactory, InnerDomainIdpFactory> WithIdp<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainSAMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainSAMLOptionsFactory, T1, T2, T3, T4, InnerDomainIdpFactory> WithIdp<T1, T2, T3, T4>(this CombinedResult<InnerDomainSAMLOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainSAMLOptionsFactory, T2, T3, T4, InnerDomainIdpFactory> WithIdp<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainSAMLOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainSAMLOptionsFactory, T3, T4, InnerDomainIdpFactory> WithIdp<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainSAMLOptionsFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainSAMLOptionsFactory, T4, InnerDomainIdpFactory> WithIdp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainSAMLOptionsFactory, T4> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainSAMLOptionsFactory, InnerDomainIdpFactory> WithIdp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainSAMLOptionsFactory> combinedResult, Action<Humidifier.OpenSearchService.DomainTypes.Idp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdp(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class DomainFactory(string resourceName = null, Action<Humidifier.DataZone.Domain> factoryAction = null) : ResourceFactory<Humidifier.DataZone.Domain>(resourceName)
{

    internal InnerDomainSingleSignOnFactory SingleSignOnFactory { get; set; }

    protected override Humidifier.DataZone.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.DataZone.Domain CreateDomain()
    {
        var domainResult = new Humidifier.DataZone.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.DataZone.Domain result)
    {
        base.CreateChildren(result);

        result.SingleSignOn ??= SingleSignOnFactory?.Build();
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainSingleSignOnFactory> WithSingleSignOn(this DomainFactory parentFactory, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null)
    {
        parentFactory.SingleSignOnFactory = new InnerDomainSingleSignOnFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SingleSignOnFactory);
    }

    public static CombinedResult<DomainFactory, T1, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithSingleSignOn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, WithSingleSignOn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainSingleSignOnFactory> WithSingleSignOn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.DataZone.DomainTypes.SingleSignOn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSingleSignOn(combinedResult.T5, subFactoryAction));
}

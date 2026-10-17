// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory(Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitPolicyGrantPrincipal> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.DomainUnitPolicyGrantPrincipal>
{

    internal InnerPolicyGrantDomainUnitGrantFilterFactory DomainUnitGrantFilterFactory { get; set; }

    protected override Humidifier.DataZone.PolicyGrantTypes.DomainUnitPolicyGrantPrincipal Create()
    {
        var domainUnitPolicyGrantPrincipalResult = CreateDomainUnitPolicyGrantPrincipal();
        factoryAction?.Invoke(domainUnitPolicyGrantPrincipalResult);

        return domainUnitPolicyGrantPrincipalResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.DomainUnitPolicyGrantPrincipal CreateDomainUnitPolicyGrantPrincipal()
    {
        var domainUnitPolicyGrantPrincipalResult = new Humidifier.DataZone.PolicyGrantTypes.DomainUnitPolicyGrantPrincipal();

        return domainUnitPolicyGrantPrincipalResult;
    }
    public override void CreateChildren(Humidifier.DataZone.PolicyGrantTypes.DomainUnitPolicyGrantPrincipal result)
    {
        base.CreateChildren(result);

        result.DomainUnitGrantFilter ??= DomainUnitGrantFilterFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactoryExtensions
{
    public static CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter(this InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory parentFactory, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null)
    {
        parentFactory.DomainUnitGrantFilterFactory = new InnerPolicyGrantDomainUnitGrantFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DomainUnitGrantFilterFactory);
    }

    public static CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1>(this CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1>(this CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1, T2, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2>(this CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T2, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2>(this CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2>(this CombinedResult<T1, T2, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1, T2, T3, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3>(this CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T2, T3, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3>(this CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T3, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1, T2, T3, T4, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3, T4>(this CombinedResult<InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T2, T3, T4, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T3, T4, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T4, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory, InnerPolicyGrantDomainUnitGrantFilterFactory> WithDomainUnitGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyGrantDomainUnitPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitGrantFilter(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantProjectGrantFilterFactory(Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter>
{

    internal InnerPolicyGrantDomainUnitFilterForProjectFactory DomainUnitFilterFactory { get; set; }

    protected override Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter Create()
    {
        var projectGrantFilterResult = CreateProjectGrantFilter();
        factoryAction?.Invoke(projectGrantFilterResult);

        return projectGrantFilterResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter CreateProjectGrantFilter()
    {
        var projectGrantFilterResult = new Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter();

        return projectGrantFilterResult;
    }
    public override void CreateChildren(Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter result)
    {
        base.CreateChildren(result);

        result.DomainUnitFilter ??= DomainUnitFilterFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyGrantProjectGrantFilterFactoryExtensions
{
    public static CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter(this InnerPolicyGrantProjectGrantFilterFactory parentFactory, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null)
    {
        parentFactory.DomainUnitFilterFactory = new InnerPolicyGrantDomainUnitFilterForProjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DomainUnitFilterFactory);
    }

    public static CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1>(this CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1>(this CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1, T2, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2>(this CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory, T2, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2>(this CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantProjectGrantFilterFactory, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2>(this CombinedResult<T1, T2, InnerPolicyGrantProjectGrantFilterFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1, T2, T3, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3>(this CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory, T2, T3, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3>(this CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantProjectGrantFilterFactory, T3, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyGrantProjectGrantFilterFactory, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyGrantProjectGrantFilterFactory, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyGrantProjectGrantFilterFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1, T2, T3, T4, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3, T4>(this CombinedResult<InnerPolicyGrantProjectGrantFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory, T2, T3, T4, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyGrantProjectGrantFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantProjectGrantFilterFactory, T3, T4, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyGrantProjectGrantFilterFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyGrantProjectGrantFilterFactory, T4, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyGrantProjectGrantFilterFactory, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyGrantProjectGrantFilterFactory, InnerPolicyGrantDomainUnitFilterForProjectFactory> WithDomainUnitFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyGrantProjectGrantFilterFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.DomainUnitFilterForProject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainUnitFilter(combinedResult.T5, subFactoryAction).T2);
}

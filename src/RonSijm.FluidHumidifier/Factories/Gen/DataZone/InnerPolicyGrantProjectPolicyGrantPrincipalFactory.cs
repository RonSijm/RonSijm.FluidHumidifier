// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerPolicyGrantProjectPolicyGrantPrincipalFactory(Action<Humidifier.DataZone.PolicyGrantTypes.ProjectPolicyGrantPrincipal> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.PolicyGrantTypes.ProjectPolicyGrantPrincipal>
{

    internal InnerPolicyGrantProjectGrantFilterFactory ProjectGrantFilterFactory { get; set; }

    protected override Humidifier.DataZone.PolicyGrantTypes.ProjectPolicyGrantPrincipal Create()
    {
        var projectPolicyGrantPrincipalResult = CreateProjectPolicyGrantPrincipal();
        factoryAction?.Invoke(projectPolicyGrantPrincipalResult);

        return projectPolicyGrantPrincipalResult;
    }

    private Humidifier.DataZone.PolicyGrantTypes.ProjectPolicyGrantPrincipal CreateProjectPolicyGrantPrincipal()
    {
        var projectPolicyGrantPrincipalResult = new Humidifier.DataZone.PolicyGrantTypes.ProjectPolicyGrantPrincipal();

        return projectPolicyGrantPrincipalResult;
    }
    public override void CreateChildren(Humidifier.DataZone.PolicyGrantTypes.ProjectPolicyGrantPrincipal result)
    {
        base.CreateChildren(result);

        result.ProjectGrantFilter ??= ProjectGrantFilterFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyGrantProjectPolicyGrantPrincipalFactoryExtensions
{
    public static CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter(this InnerPolicyGrantProjectPolicyGrantPrincipalFactory parentFactory, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null)
    {
        parentFactory.ProjectGrantFilterFactory = new InnerPolicyGrantProjectGrantFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProjectGrantFilterFactory);
    }

    public static CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1>(this CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1>(this CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1, T2, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2>(this CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T2, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2>(this CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2>(this CombinedResult<T1, T2, InnerPolicyGrantProjectPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1, T2, T3, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3>(this CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T2, T3, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3>(this CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T3, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyGrantProjectPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1, T2, T3, T4, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3, T4>(this CombinedResult<InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T2, T3, T4, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T3, T4, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T4, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyGrantProjectPolicyGrantPrincipalFactory, InnerPolicyGrantProjectGrantFilterFactory> WithProjectGrantFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyGrantProjectPolicyGrantPrincipalFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.ProjectGrantFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProjectGrantFilter(combinedResult.T5, subFactoryAction).T2);
}

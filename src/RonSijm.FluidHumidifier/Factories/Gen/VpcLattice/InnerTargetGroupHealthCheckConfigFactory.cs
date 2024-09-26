// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerTargetGroupHealthCheckConfigFactory(Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig>
{

    internal InnerTargetGroupMatcherFactory MatcherFactory { get; set; }

    protected override Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig Create()
    {
        var healthCheckConfigResult = CreateHealthCheckConfig();
        factoryAction?.Invoke(healthCheckConfigResult);

        return healthCheckConfigResult;
    }

    private Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig CreateHealthCheckConfig()
    {
        var healthCheckConfigResult = new Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig();

        return healthCheckConfigResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig result)
    {
        base.CreateChildren(result);

        result.Matcher ??= MatcherFactory?.Build();
    }

} // End Of Class

public static class InnerTargetGroupHealthCheckConfigFactoryExtensions
{
    public static CombinedResult<InnerTargetGroupHealthCheckConfigFactory, InnerTargetGroupMatcherFactory> WithMatcher(this InnerTargetGroupHealthCheckConfigFactory parentFactory, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null)
    {
        parentFactory.MatcherFactory = new InnerTargetGroupMatcherFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatcherFactory);
    }

    public static CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1, InnerTargetGroupMatcherFactory> WithMatcher<T1>(this CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1>(this CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1, T2, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory, T2, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTargetGroupHealthCheckConfigFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<T1, T2, InnerTargetGroupHealthCheckConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1, T2, T3, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory, T2, T3, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTargetGroupHealthCheckConfigFactory, T3, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, T2, InnerTargetGroupHealthCheckConfigFactory, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTargetGroupHealthCheckConfigFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTargetGroupHealthCheckConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1, T2, T3, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<InnerTargetGroupHealthCheckConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory, T2, T3, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, InnerTargetGroupHealthCheckConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTargetGroupHealthCheckConfigFactory, T3, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTargetGroupHealthCheckConfigFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTargetGroupHealthCheckConfigFactory, T4, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTargetGroupHealthCheckConfigFactory, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTargetGroupHealthCheckConfigFactory, InnerTargetGroupMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTargetGroupHealthCheckConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T5, subFactoryAction));
}

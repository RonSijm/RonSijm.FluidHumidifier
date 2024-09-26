// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerTargetGroupTargetGroupConfigFactory(Action<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig>
{

    internal InnerTargetGroupHealthCheckConfigFactory HealthCheckFactory { get; set; }

    protected override Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig Create()
    {
        var targetGroupConfigResult = CreateTargetGroupConfig();
        factoryAction?.Invoke(targetGroupConfigResult);

        return targetGroupConfigResult;
    }

    private Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig CreateTargetGroupConfig()
    {
        var targetGroupConfigResult = new Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig();

        return targetGroupConfigResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.TargetGroupTypes.TargetGroupConfig result)
    {
        base.CreateChildren(result);

        result.HealthCheck ??= HealthCheckFactory?.Build();
    }

} // End Of Class

public static class InnerTargetGroupTargetGroupConfigFactoryExtensions
{
    public static CombinedResult<InnerTargetGroupTargetGroupConfigFactory, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck(this InnerTargetGroupTargetGroupConfigFactory parentFactory, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null)
    {
        parentFactory.HealthCheckFactory = new InnerTargetGroupHealthCheckConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthCheckFactory);
    }

    public static CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1>(this CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1>(this CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1, T2, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2>(this CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory, T2, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2>(this CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory, T2> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTargetGroupTargetGroupConfigFactory, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2>(this CombinedResult<T1, T2, InnerTargetGroupTargetGroupConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1, T2, T3, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory, T2, T3, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTargetGroupTargetGroupConfigFactory, T3, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<T1, T2, InnerTargetGroupTargetGroupConfigFactory, T3> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTargetGroupTargetGroupConfigFactory, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTargetGroupTargetGroupConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1, T2, T3, T4, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<InnerTargetGroupTargetGroupConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory, T2, T3, T4, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, InnerTargetGroupTargetGroupConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTargetGroupTargetGroupConfigFactory, T3, T4, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTargetGroupTargetGroupConfigFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTargetGroupTargetGroupConfigFactory, T4, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTargetGroupTargetGroupConfigFactory, T4> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTargetGroupTargetGroupConfigFactory, InnerTargetGroupHealthCheckConfigFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTargetGroupTargetGroupConfigFactory> combinedResult, Action<Humidifier.VpcLattice.TargetGroupTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T5, subFactoryAction));
}

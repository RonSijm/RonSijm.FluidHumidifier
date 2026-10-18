// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterRollingUpdatePolicyFactory(Action<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy>
{

    internal InnerClusterCapacitySizeConfigFactory MaximumBatchSizeFactory { get; set; }

    internal InnerClusterCapacitySizeConfigFactory RollbackMaximumBatchSizeFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy Create()
    {
        var rollingUpdatePolicyResult = CreateRollingUpdatePolicy();
        factoryAction?.Invoke(rollingUpdatePolicyResult);

        return rollingUpdatePolicyResult;
    }

    private Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy CreateRollingUpdatePolicy()
    {
        var rollingUpdatePolicyResult = new Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy();

        return rollingUpdatePolicyResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy result)
    {
        base.CreateChildren(result);

        result.MaximumBatchSize ??= MaximumBatchSizeFactory?.Build();
        result.RollbackMaximumBatchSize ??= RollbackMaximumBatchSizeFactory?.Build();
    }

} // End Of Class

public static class InnerClusterRollingUpdatePolicyFactoryExtensions
{
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize(this InnerClusterRollingUpdatePolicyFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null)
    {
        parentFactory.MaximumBatchSizeFactory = new InnerClusterCapacitySizeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MaximumBatchSizeFactory);
    }

    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize(this InnerClusterRollingUpdatePolicyFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null)
    {
        parentFactory.RollbackMaximumBatchSizeFactory = new InnerClusterCapacitySizeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RollbackMaximumBatchSizeFactory);
    }

    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2>(this CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3, T4, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3, T4, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3, T4, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory, T4, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMaximumBatchSize(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2>(this CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3, T4, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<InnerClusterRollingUpdatePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3, T4, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterRollingUpdatePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3, T4, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterRollingUpdatePolicyFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory, T4, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterRollingUpdatePolicyFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterRollingUpdatePolicyFactory, InnerClusterCapacitySizeConfigFactory> WithRollbackMaximumBatchSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterRollingUpdatePolicyFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRollbackMaximumBatchSize(combinedResult.T5, subFactoryAction).T2);
}

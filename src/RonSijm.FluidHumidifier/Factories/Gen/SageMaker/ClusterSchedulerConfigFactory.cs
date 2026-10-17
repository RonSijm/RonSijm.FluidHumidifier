// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ClusterSchedulerConfigFactory(string resourceName = null, Action<Humidifier.SageMaker.ClusterSchedulerConfig> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.ClusterSchedulerConfig>(resourceName)
{

    internal InnerClusterSchedulerConfigSchedulerConfigFactory SchedulerConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterSchedulerConfig Create()
    {
        var clusterSchedulerConfigResult = CreateClusterSchedulerConfig();
        factoryAction?.Invoke(clusterSchedulerConfigResult);

        return clusterSchedulerConfigResult;
    }

    private Humidifier.SageMaker.ClusterSchedulerConfig CreateClusterSchedulerConfig()
    {
        var clusterSchedulerConfigResult = new Humidifier.SageMaker.ClusterSchedulerConfig
        {
            GivenName = InputResourceName,
        };

        return clusterSchedulerConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterSchedulerConfig result)
    {
        base.CreateChildren(result);

        result.SchedulerConfig ??= SchedulerConfigFactory?.Build();
    }

} // End Of Class

public static class ClusterSchedulerConfigFactoryExtensions
{
    public static CombinedResult<ClusterSchedulerConfigFactory, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig(this ClusterSchedulerConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null)
    {
        parentFactory.SchedulerConfigFactory = new InnerClusterSchedulerConfigSchedulerConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchedulerConfigFactory);
    }

    public static CombinedResult<ClusterSchedulerConfigFactory, T1, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1>(this CombinedResult<ClusterSchedulerConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterSchedulerConfigFactory, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1>(this CombinedResult<T1, ClusterSchedulerConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ClusterSchedulerConfigFactory, T1, T2, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2>(this CombinedResult<ClusterSchedulerConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterSchedulerConfigFactory, T2, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2>(this CombinedResult<T1, ClusterSchedulerConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterSchedulerConfigFactory, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2>(this CombinedResult<T1, T2, ClusterSchedulerConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ClusterSchedulerConfigFactory, T1, T2, T3, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3>(this CombinedResult<ClusterSchedulerConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterSchedulerConfigFactory, T2, T3, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3>(this CombinedResult<T1, ClusterSchedulerConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterSchedulerConfigFactory, T3, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3>(this CombinedResult<T1, T2, ClusterSchedulerConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterSchedulerConfigFactory, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterSchedulerConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ClusterSchedulerConfigFactory, T1, T2, T3, T4, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3, T4>(this CombinedResult<ClusterSchedulerConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterSchedulerConfigFactory, T2, T3, T4, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3, T4>(this CombinedResult<T1, ClusterSchedulerConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterSchedulerConfigFactory, T3, T4, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterSchedulerConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterSchedulerConfigFactory, T4, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterSchedulerConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ClusterSchedulerConfigFactory, InnerClusterSchedulerConfigSchedulerConfigFactory> WithSchedulerConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterSchedulerConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterSchedulerConfigTypes.SchedulerConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulerConfig(combinedResult.T5, subFactoryAction).T2);
}

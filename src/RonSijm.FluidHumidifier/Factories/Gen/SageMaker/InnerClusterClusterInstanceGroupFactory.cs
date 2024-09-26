// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterInstanceGroupFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup>
{

    internal InnerClusterClusterLifeCycleConfigFactory LifeCycleConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup Create()
    {
        var clusterInstanceGroupResult = CreateClusterInstanceGroup();
        factoryAction?.Invoke(clusterInstanceGroupResult);

        return clusterInstanceGroupResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup CreateClusterInstanceGroup()
    {
        var clusterInstanceGroupResult = new Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup();

        return clusterInstanceGroupResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup result)
    {
        base.CreateChildren(result);

        result.LifeCycleConfig ??= LifeCycleConfigFactory?.Build();
    }

} // End Of Class

public static class InnerClusterClusterInstanceGroupFactoryExtensions
{
    public static CombinedResult<InnerClusterClusterInstanceGroupFactory, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig(this InnerClusterClusterInstanceGroupFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null)
    {
        parentFactory.LifeCycleConfigFactory = new InnerClusterClusterLifeCycleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LifeCycleConfigFactory);
    }

    public static CombinedResult<InnerClusterClusterInstanceGroupFactory, T1, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1>(this CombinedResult<InnerClusterClusterInstanceGroupFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClusterInstanceGroupFactory, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1>(this CombinedResult<T1, InnerClusterClusterInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterClusterInstanceGroupFactory, T1, T2, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2>(this CombinedResult<InnerClusterClusterInstanceGroupFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClusterInstanceGroupFactory, T2, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2>(this CombinedResult<T1, InnerClusterClusterInstanceGroupFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClusterInstanceGroupFactory, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterClusterInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterClusterInstanceGroupFactory, T1, T2, T3, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3>(this CombinedResult<InnerClusterClusterInstanceGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClusterInstanceGroupFactory, T2, T3, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterClusterInstanceGroupFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClusterInstanceGroupFactory, T3, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterClusterInstanceGroupFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClusterInstanceGroupFactory, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterClusterInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterClusterInstanceGroupFactory, T1, T2, T3, T4, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterClusterInstanceGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterClusterInstanceGroupFactory, T2, T3, T4, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterClusterInstanceGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterClusterInstanceGroupFactory, T3, T4, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterClusterInstanceGroupFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterClusterInstanceGroupFactory, T4, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterClusterInstanceGroupFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterClusterInstanceGroupFactory, InnerClusterClusterLifeCycleConfigFactory> WithLifeCycleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterClusterInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLifeCycleConfig(combinedResult.T5, subFactoryAction));
}

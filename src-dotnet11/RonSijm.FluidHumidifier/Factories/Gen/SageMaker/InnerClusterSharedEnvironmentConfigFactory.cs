// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterSharedEnvironmentConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig>
{

    internal InnerClusterFSxLustreConfigFactory FSxLustreConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig Create()
    {
        var sharedEnvironmentConfigResult = CreateSharedEnvironmentConfig();
        factoryAction?.Invoke(sharedEnvironmentConfigResult);

        return sharedEnvironmentConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig CreateSharedEnvironmentConfig()
    {
        var sharedEnvironmentConfigResult = new Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig();

        return sharedEnvironmentConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig result)
    {
        base.CreateChildren(result);

        result.FSxLustreConfig ??= FSxLustreConfigFactory?.Build();
    }

} // End Of Class

public static class InnerClusterSharedEnvironmentConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterSharedEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig(this InnerClusterSharedEnvironmentConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null)
    {
        parentFactory.FSxLustreConfigFactory = new InnerClusterFSxLustreConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FSxLustreConfigFactory);
    }

    public static CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1>(this CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1>(this CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1, T2, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2>(this CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory, T2, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2>(this CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterSharedEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterSharedEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1, T2, T3, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory, T2, T3, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterSharedEnvironmentConfigFactory, T3, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterSharedEnvironmentConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterSharedEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterSharedEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1, T2, T3, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterSharedEnvironmentConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory, T2, T3, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterSharedEnvironmentConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterSharedEnvironmentConfigFactory, T3, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterSharedEnvironmentConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterSharedEnvironmentConfigFactory, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterSharedEnvironmentConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterSharedEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterSharedEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T5, subFactoryAction).T2);
}

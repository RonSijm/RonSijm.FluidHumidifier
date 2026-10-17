// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterEnvironmentConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig>
{

    internal InnerClusterFSxLustreConfigFactory FSxLustreConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.EnvironmentConfig Create()
    {
        var environmentConfigResult = CreateEnvironmentConfig();
        factoryAction?.Invoke(environmentConfigResult);

        return environmentConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.EnvironmentConfig CreateEnvironmentConfig()
    {
        var environmentConfigResult = new Humidifier.SageMaker.ClusterTypes.EnvironmentConfig();

        return environmentConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.EnvironmentConfig result)
    {
        base.CreateChildren(result);

        result.FSxLustreConfig ??= FSxLustreConfigFactory?.Build();
    }

} // End Of Class

public static class InnerClusterEnvironmentConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig(this InnerClusterEnvironmentConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null)
    {
        parentFactory.FSxLustreConfigFactory = new InnerClusterFSxLustreConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FSxLustreConfigFactory);
    }

    public static CombinedResult<InnerClusterEnvironmentConfigFactory, T1, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1>(this CombinedResult<InnerClusterEnvironmentConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1>(this CombinedResult<T1, InnerClusterEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterEnvironmentConfigFactory, T1, T2, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2>(this CombinedResult<InnerClusterEnvironmentConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterEnvironmentConfigFactory, T2, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2>(this CombinedResult<T1, InnerClusterEnvironmentConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterEnvironmentConfigFactory, T1, T2, T3, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<InnerClusterEnvironmentConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterEnvironmentConfigFactory, T2, T3, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterEnvironmentConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterEnvironmentConfigFactory, T3, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterEnvironmentConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterEnvironmentConfigFactory, T1, T2, T3, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterEnvironmentConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterEnvironmentConfigFactory, T2, T3, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterEnvironmentConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterEnvironmentConfigFactory, T3, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterEnvironmentConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterEnvironmentConfigFactory, T4, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterEnvironmentConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterEnvironmentConfigFactory, InnerClusterFSxLustreConfigFactory> WithFSxLustreConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterEnvironmentConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.FSxLustreConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFSxLustreConfig(combinedResult.T5, subFactoryAction).T2);
}

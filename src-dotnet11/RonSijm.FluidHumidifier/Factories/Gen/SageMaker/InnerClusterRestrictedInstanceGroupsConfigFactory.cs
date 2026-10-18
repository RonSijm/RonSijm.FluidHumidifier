// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterRestrictedInstanceGroupsConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.RestrictedInstanceGroupsConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.RestrictedInstanceGroupsConfig>
{

    internal InnerClusterSharedEnvironmentConfigFactory SharedEnvironmentConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.RestrictedInstanceGroupsConfig Create()
    {
        var restrictedInstanceGroupsConfigResult = CreateRestrictedInstanceGroupsConfig();
        factoryAction?.Invoke(restrictedInstanceGroupsConfigResult);

        return restrictedInstanceGroupsConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.RestrictedInstanceGroupsConfig CreateRestrictedInstanceGroupsConfig()
    {
        var restrictedInstanceGroupsConfigResult = new Humidifier.SageMaker.ClusterTypes.RestrictedInstanceGroupsConfig();

        return restrictedInstanceGroupsConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.RestrictedInstanceGroupsConfig result)
    {
        base.CreateChildren(result);

        result.SharedEnvironmentConfig ??= SharedEnvironmentConfigFactory?.Build();
    }

} // End Of Class

public static class InnerClusterRestrictedInstanceGroupsConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig(this InnerClusterRestrictedInstanceGroupsConfigFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null)
    {
        parentFactory.SharedEnvironmentConfigFactory = new InnerClusterSharedEnvironmentConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SharedEnvironmentConfigFactory);
    }

    public static CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1>(this CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1>(this CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1, T2, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2>(this CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory, T2, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2>(this CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRestrictedInstanceGroupsConfigFactory, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterRestrictedInstanceGroupsConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1, T2, T3, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3>(this CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory, T2, T3, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRestrictedInstanceGroupsConfigFactory, T3, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterRestrictedInstanceGroupsConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterRestrictedInstanceGroupsConfigFactory, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterRestrictedInstanceGroupsConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1, T2, T3, T4, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterRestrictedInstanceGroupsConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory, T2, T3, T4, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterRestrictedInstanceGroupsConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterRestrictedInstanceGroupsConfigFactory, T3, T4, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterRestrictedInstanceGroupsConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterRestrictedInstanceGroupsConfigFactory, T4, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterRestrictedInstanceGroupsConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterRestrictedInstanceGroupsConfigFactory, InnerClusterSharedEnvironmentConfigFactory> WithSharedEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterRestrictedInstanceGroupsConfigFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSharedEnvironmentConfig(combinedResult.T5, subFactoryAction).T2);
}

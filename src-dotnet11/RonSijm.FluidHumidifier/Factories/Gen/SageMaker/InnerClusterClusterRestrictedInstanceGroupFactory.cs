// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterRestrictedInstanceGroupFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterRestrictedInstanceGroup> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterRestrictedInstanceGroup>
{

    internal InnerClusterVpcConfigFactory OverrideVpcConfigFactory { get; set; }

    internal InnerClusterEnvironmentConfigFactory EnvironmentConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ClusterTypes.ClusterRestrictedInstanceGroup Create()
    {
        var clusterRestrictedInstanceGroupResult = CreateClusterRestrictedInstanceGroup();
        factoryAction?.Invoke(clusterRestrictedInstanceGroupResult);

        return clusterRestrictedInstanceGroupResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterRestrictedInstanceGroup CreateClusterRestrictedInstanceGroup()
    {
        var clusterRestrictedInstanceGroupResult = new Humidifier.SageMaker.ClusterTypes.ClusterRestrictedInstanceGroup();

        return clusterRestrictedInstanceGroupResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ClusterTypes.ClusterRestrictedInstanceGroup result)
    {
        base.CreateChildren(result);

        result.OverrideVpcConfig ??= OverrideVpcConfigFactory?.Build();
        result.EnvironmentConfig ??= EnvironmentConfigFactory?.Build();
    }

} // End Of Class

public static class InnerClusterClusterRestrictedInstanceGroupFactoryExtensions
{
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterVpcConfigFactory> WithOverrideVpcConfig(this InnerClusterClusterRestrictedInstanceGroupFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.OverrideVpcConfigFactory = new InnerClusterVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OverrideVpcConfigFactory);
    }

    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig(this InnerClusterClusterRestrictedInstanceGroupFactory parentFactory, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null)
    {
        parentFactory.EnvironmentConfigFactory = new InnerClusterEnvironmentConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EnvironmentConfigFactory);
    }

    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3, T4, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3, T4, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3, T4, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory, T4, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterVpcConfigFactory> WithOverrideVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideVpcConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2>(this CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3, T4, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<InnerClusterClusterRestrictedInstanceGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3, T4, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterClusterRestrictedInstanceGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3, T4, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterClusterRestrictedInstanceGroupFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory, T4, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterClusterRestrictedInstanceGroupFactory, T4> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterClusterRestrictedInstanceGroupFactory, InnerClusterEnvironmentConfigFactory> WithEnvironmentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterClusterRestrictedInstanceGroupFactory> combinedResult, Action<Humidifier.SageMaker.ClusterTypes.EnvironmentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentConfig(combinedResult.T5, subFactoryAction).T2);
}

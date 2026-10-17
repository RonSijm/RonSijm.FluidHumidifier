// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterInstanceGroupConfigFactory(Action<Humidifier.EMR.ClusterTypes.InstanceGroupConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.InstanceGroupConfig>
{

    internal InnerClusterAutoScalingPolicyFactory AutoScalingPolicyFactory { get; set; }

    internal InnerClusterEbsConfigurationFactory EbsConfigurationFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.InstanceGroupConfig Create()
    {
        var instanceGroupConfigResult = CreateInstanceGroupConfig();
        factoryAction?.Invoke(instanceGroupConfigResult);

        return instanceGroupConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.InstanceGroupConfig CreateInstanceGroupConfig()
    {
        var instanceGroupConfigResult = new Humidifier.EMR.ClusterTypes.InstanceGroupConfig();

        return instanceGroupConfigResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.InstanceGroupConfig result)
    {
        base.CreateChildren(result);

        result.AutoScalingPolicy ??= AutoScalingPolicyFactory?.Build();
        result.EbsConfiguration ??= EbsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerClusterInstanceGroupConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy(this InnerClusterInstanceGroupConfigFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null)
    {
        parentFactory.AutoScalingPolicyFactory = new InnerClusterAutoScalingPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutoScalingPolicyFactory);
    }

    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration(this InnerClusterInstanceGroupConfigFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null)
    {
        parentFactory.EbsConfigurationFactory = new InnerClusterEbsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsConfigurationFactory);
    }

    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2>(this CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3, T4, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3, T4>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3, T4, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3, T4, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory, T4, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterInstanceGroupConfigFactory, InnerClusterAutoScalingPolicyFactory> WithAutoScalingPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutoScalingPolicy(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerClusterInstanceGroupConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterInstanceGroupConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterInstanceGroupConfigFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory, T4, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterInstanceGroupConfigFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterInstanceGroupConfigFactory, InnerClusterEbsConfigurationFactory> WithEbsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterInstanceGroupConfigFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.EbsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbsConfiguration(combinedResult.T5, subFactoryAction).T2);
}

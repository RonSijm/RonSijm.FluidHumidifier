// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerResponderGatewayAutoScalingGroupsConfigurationFactory(Action<Humidifier.RTBFabric.ResponderGatewayTypes.AutoScalingGroupsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.ResponderGatewayTypes.AutoScalingGroupsConfiguration>
{

    internal InnerResponderGatewayHealthCheckConfigFactory HealthCheckConfigFactory { get; set; }

    protected override Humidifier.RTBFabric.ResponderGatewayTypes.AutoScalingGroupsConfiguration Create()
    {
        var autoScalingGroupsConfigurationResult = CreateAutoScalingGroupsConfiguration();
        factoryAction?.Invoke(autoScalingGroupsConfigurationResult);

        return autoScalingGroupsConfigurationResult;
    }

    private Humidifier.RTBFabric.ResponderGatewayTypes.AutoScalingGroupsConfiguration CreateAutoScalingGroupsConfiguration()
    {
        var autoScalingGroupsConfigurationResult = new Humidifier.RTBFabric.ResponderGatewayTypes.AutoScalingGroupsConfiguration();

        return autoScalingGroupsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.ResponderGatewayTypes.AutoScalingGroupsConfiguration result)
    {
        base.CreateChildren(result);

        result.HealthCheckConfig ??= HealthCheckConfigFactory?.Build();
    }

} // End Of Class

public static class InnerResponderGatewayAutoScalingGroupsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig(this InnerResponderGatewayAutoScalingGroupsConfigurationFactory parentFactory, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null)
    {
        parentFactory.HealthCheckConfigFactory = new InnerResponderGatewayHealthCheckConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthCheckConfigFactory);
    }

    public static CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1>(this CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1, T2, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T2, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T2> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2>(this CombinedResult<T1, T2, InnerResponderGatewayAutoScalingGroupsConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1, T2, T3, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T2, T3, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T3, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T3> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResponderGatewayAutoScalingGroupsConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1, T2, T3, T4, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T2, T3, T4, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T3, T4, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T4, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, T4> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerResponderGatewayAutoScalingGroupsConfigurationFactory, InnerResponderGatewayHealthCheckConfigFactory> WithHealthCheckConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResponderGatewayAutoScalingGroupsConfigurationFactory> combinedResult, Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheckConfig(combinedResult.T5, subFactoryAction).T2);
}

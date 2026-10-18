// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceLoadBalancerFactory(Action<Humidifier.ECS.ServiceTypes.LoadBalancer> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.LoadBalancer>
{

    internal InnerServiceAdvancedConfigurationFactory AdvancedConfigurationFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.LoadBalancer Create()
    {
        var loadBalancerResult = CreateLoadBalancer();
        factoryAction?.Invoke(loadBalancerResult);

        return loadBalancerResult;
    }

    private Humidifier.ECS.ServiceTypes.LoadBalancer CreateLoadBalancer()
    {
        var loadBalancerResult = new Humidifier.ECS.ServiceTypes.LoadBalancer();

        return loadBalancerResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.LoadBalancer result)
    {
        base.CreateChildren(result);

        result.AdvancedConfiguration ??= AdvancedConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceLoadBalancerFactoryExtensions
{
    public static CombinedResult<InnerServiceLoadBalancerFactory, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration(this InnerServiceLoadBalancerFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null)
    {
        parentFactory.AdvancedConfigurationFactory = new InnerServiceAdvancedConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AdvancedConfigurationFactory);
    }

    public static CombinedResult<InnerServiceLoadBalancerFactory, T1, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1>(this CombinedResult<InnerServiceLoadBalancerFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLoadBalancerFactory, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1>(this CombinedResult<T1, InnerServiceLoadBalancerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceLoadBalancerFactory, T1, T2, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2>(this CombinedResult<InnerServiceLoadBalancerFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLoadBalancerFactory, T2, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceLoadBalancerFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceLoadBalancerFactory, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceLoadBalancerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceLoadBalancerFactory, T1, T2, T3, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceLoadBalancerFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLoadBalancerFactory, T2, T3, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceLoadBalancerFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceLoadBalancerFactory, T3, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceLoadBalancerFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceLoadBalancerFactory, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceLoadBalancerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceLoadBalancerFactory, T1, T2, T3, T4, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceLoadBalancerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceLoadBalancerFactory, T2, T3, T4, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceLoadBalancerFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceLoadBalancerFactory, T3, T4, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceLoadBalancerFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceLoadBalancerFactory, T4, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceLoadBalancerFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceLoadBalancerFactory, InnerServiceAdvancedConfigurationFactory> WithAdvancedConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceLoadBalancerFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedConfiguration(combinedResult.T5, subFactoryAction).T2);
}

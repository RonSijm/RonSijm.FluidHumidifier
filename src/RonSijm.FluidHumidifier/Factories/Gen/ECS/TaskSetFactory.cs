// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class TaskSetFactory(string resourceName = null, Action<Humidifier.ECS.TaskSet> factoryAction = null) : ResourceFactory<Humidifier.ECS.TaskSet>(resourceName)
{

    internal List<InnerTaskSetLoadBalancerFactory> LoadBalancersFactories { get; set; } = [];

    internal List<InnerTaskSetServiceRegistryFactory> ServiceRegistriesFactories { get; set; } = [];

    internal InnerTaskSetNetworkConfigurationFactory NetworkConfigurationFactory { get; set; }

    internal InnerTaskSetScaleFactory ScaleFactory { get; set; }

    protected override Humidifier.ECS.TaskSet Create()
    {
        var taskSetResult = CreateTaskSet();
        factoryAction?.Invoke(taskSetResult);

        return taskSetResult;
    }

    private Humidifier.ECS.TaskSet CreateTaskSet()
    {
        var taskSetResult = new Humidifier.ECS.TaskSet
        {
            GivenName = InputResourceName,
        };

        return taskSetResult;
    }
    public override void CreateChildren(Humidifier.ECS.TaskSet result)
    {
        base.CreateChildren(result);

        result.LoadBalancers = LoadBalancersFactories.Any() ? LoadBalancersFactories.Select(x => x.Build()).ToList() : null;
        result.ServiceRegistries = ServiceRegistriesFactories.Any() ? ServiceRegistriesFactories.Select(x => x.Build()).ToList() : null;
        result.NetworkConfiguration ??= NetworkConfigurationFactory?.Build();
        result.Scale ??= ScaleFactory?.Build();
    }

} // End Of Class

public static class TaskSetFactoryExtensions
{
    public static CombinedResult<TaskSetFactory, InnerTaskSetLoadBalancerFactory> WithLoadBalancers(this TaskSetFactory parentFactory, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null)
    {
        var factory = new InnerTaskSetLoadBalancerFactory(subFactoryAction);
        parentFactory.LoadBalancersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TaskSetFactory, InnerTaskSetServiceRegistryFactory> WithServiceRegistries(this TaskSetFactory parentFactory, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null)
    {
        var factory = new InnerTaskSetServiceRegistryFactory(subFactoryAction);
        parentFactory.ServiceRegistriesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TaskSetFactory, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration(this TaskSetFactory parentFactory, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null)
    {
        parentFactory.NetworkConfigurationFactory = new InnerTaskSetNetworkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkConfigurationFactory);
    }

    public static CombinedResult<TaskSetFactory, InnerTaskSetScaleFactory> WithScale(this TaskSetFactory parentFactory, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null)
    {
        parentFactory.ScaleFactory = new InnerTaskSetScaleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScaleFactory);
    }

    public static CombinedResult<TaskSetFactory, T1, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1>(this CombinedResult<TaskSetFactory, T1> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoadBalancers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1>(this CombinedResult<T1, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoadBalancers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2>(this CombinedResult<TaskSetFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2>(this CombinedResult<T1, TaskSetFactory, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2>(this CombinedResult<T1, T2, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3>(this CombinedResult<TaskSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3>(this CombinedResult<T1, TaskSetFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3>(this CombinedResult<T1, T2, TaskSetFactory, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, T4, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3, T4>(this CombinedResult<TaskSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, T4, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3, T4>(this CombinedResult<T1, TaskSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, T4, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskSetFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, T4, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskSetFactory, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskSetFactory, InnerTaskSetLoadBalancerFactory> WithLoadBalancers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoadBalancers(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1>(this CombinedResult<TaskSetFactory, T1> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceRegistries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1>(this CombinedResult<T1, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceRegistries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2>(this CombinedResult<TaskSetFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2>(this CombinedResult<T1, TaskSetFactory, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2>(this CombinedResult<T1, T2, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3>(this CombinedResult<TaskSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3>(this CombinedResult<T1, TaskSetFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3>(this CombinedResult<T1, T2, TaskSetFactory, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, T4, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3, T4>(this CombinedResult<TaskSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, T4, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3, T4>(this CombinedResult<T1, TaskSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, T4, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskSetFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, T4, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskSetFactory, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskSetFactory, InnerTaskSetServiceRegistryFactory> WithServiceRegistries<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.ServiceRegistry> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceRegistries(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<TaskSetFactory, T1> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1>(this CombinedResult<T1, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<TaskSetFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, TaskSetFactory, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2>(this CombinedResult<T1, T2, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<TaskSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, TaskSetFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TaskSetFactory, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, T4, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<TaskSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, T4, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TaskSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, T4, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskSetFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, T4, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskSetFactory, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskSetFactory, InnerTaskSetNetworkConfigurationFactory> WithNetworkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, InnerTaskSetScaleFactory> WithScale<T1>(this CombinedResult<TaskSetFactory, T1> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, WithScale(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, InnerTaskSetScaleFactory> WithScale<T1>(this CombinedResult<T1, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, WithScale(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, InnerTaskSetScaleFactory> WithScale<T1, T2>(this CombinedResult<TaskSetFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, InnerTaskSetScaleFactory> WithScale<T1, T2>(this CombinedResult<T1, TaskSetFactory, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, InnerTaskSetScaleFactory> WithScale<T1, T2>(this CombinedResult<T1, T2, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, InnerTaskSetScaleFactory> WithScale<T1, T2, T3>(this CombinedResult<TaskSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, InnerTaskSetScaleFactory> WithScale<T1, T2, T3>(this CombinedResult<T1, TaskSetFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, InnerTaskSetScaleFactory> WithScale<T1, T2, T3>(this CombinedResult<T1, T2, TaskSetFactory, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, InnerTaskSetScaleFactory> WithScale<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TaskSetFactory, T1, T2, T3, T4, InnerTaskSetScaleFactory> WithScale<T1, T2, T3, T4>(this CombinedResult<TaskSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TaskSetFactory, T2, T3, T4, InnerTaskSetScaleFactory> WithScale<T1, T2, T3, T4>(this CombinedResult<T1, TaskSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TaskSetFactory, T3, T4, InnerTaskSetScaleFactory> WithScale<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskSetFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TaskSetFactory, T4, InnerTaskSetScaleFactory> WithScale<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskSetFactory, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TaskSetFactory, InnerTaskSetScaleFactory> WithScale<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskSetFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.Scale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScale(combinedResult.T5, subFactoryAction));
}

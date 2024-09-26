// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class EndpointFactory(string resourceName = null, Action<Humidifier.Events.Endpoint> factoryAction = null) : ResourceFactory<Humidifier.Events.Endpoint>(resourceName)
{

    internal List<InnerEndpointEndpointEventBusFactory> EventBusesFactories { get; set; } = [];

    internal InnerEndpointReplicationConfigFactory ReplicationConfigFactory { get; set; }

    internal InnerEndpointRoutingConfigFactory RoutingConfigFactory { get; set; }

    protected override Humidifier.Events.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.Events.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.Events.Endpoint
        {
            GivenName = InputResourceName,
        };

        return endpointResult;
    }
    public override void CreateChildren(Humidifier.Events.Endpoint result)
    {
        base.CreateChildren(result);

        result.EventBuses = EventBusesFactories.Any() ? EventBusesFactories.Select(x => x.Build()).ToList() : null;
        result.ReplicationConfig ??= ReplicationConfigFactory?.Build();
        result.RoutingConfig ??= RoutingConfigFactory?.Build();
    }

} // End Of Class

public static class EndpointFactoryExtensions
{
    public static CombinedResult<EndpointFactory, InnerEndpointEndpointEventBusFactory> WithEventBuses(this EndpointFactory parentFactory, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null)
    {
        var factory = new InnerEndpointEndpointEventBusFactory(subFactoryAction);
        parentFactory.EventBusesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EndpointFactory, InnerEndpointReplicationConfigFactory> WithReplicationConfig(this EndpointFactory parentFactory, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null)
    {
        parentFactory.ReplicationConfigFactory = new InnerEndpointReplicationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReplicationConfigFactory);
    }

    public static CombinedResult<EndpointFactory, InnerEndpointRoutingConfigFactory> WithRoutingConfig(this EndpointFactory parentFactory, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null)
    {
        parentFactory.RoutingConfigFactory = new InnerEndpointRoutingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RoutingConfigFactory);
    }

    public static CombinedResult<EndpointFactory, T1, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1>(this CombinedResult<EndpointFactory, T1> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventBuses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1>(this CombinedResult<T1, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventBuses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2>(this CombinedResult<EndpointFactory, T1, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2>(this CombinedResult<T1, EndpointFactory, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2>(this CombinedResult<T1, T2, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3>(this CombinedResult<EndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3>(this CombinedResult<T1, EndpointFactory, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3>(this CombinedResult<T1, T2, EndpointFactory, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, T4, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3, T4>(this CombinedResult<EndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, T4, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3, T4>(this CombinedResult<T1, EndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, T4, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointFactory, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, T4, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointFactory, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointFactory, InnerEndpointEndpointEventBusFactory> WithEventBuses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.EndpointEventBus> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBuses(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1>(this CombinedResult<EndpointFactory, T1> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1>(this CombinedResult<T1, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithReplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2>(this CombinedResult<EndpointFactory, T1, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2>(this CombinedResult<T1, EndpointFactory, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2>(this CombinedResult<T1, T2, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3>(this CombinedResult<EndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3>(this CombinedResult<T1, EndpointFactory, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3>(this CombinedResult<T1, T2, EndpointFactory, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, T4, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3, T4>(this CombinedResult<EndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, T4, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, EndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, T4, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointFactory, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, T4, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointFactory, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointFactory, InnerEndpointReplicationConfigFactory> WithReplicationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.ReplicationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReplicationConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1>(this CombinedResult<EndpointFactory, T1> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1>(this CombinedResult<T1, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2>(this CombinedResult<EndpointFactory, T1, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2>(this CombinedResult<T1, EndpointFactory, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2>(this CombinedResult<T1, T2, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<EndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<T1, EndpointFactory, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, EndpointFactory, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, T4, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<EndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, T4, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, EndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, T4, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointFactory, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, T4, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointFactory, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointFactory, InnerEndpointRoutingConfigFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.RoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T5, subFactoryAction));
}

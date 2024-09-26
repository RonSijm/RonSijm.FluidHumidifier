// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEndpointRoutingConfigFactory(Action<Humidifier.Events.EndpointTypes.RoutingConfig> factoryAction = null) : SubResourceFactory<Humidifier.Events.EndpointTypes.RoutingConfig>
{

    internal InnerEndpointFailoverConfigFactory FailoverConfigFactory { get; set; }

    protected override Humidifier.Events.EndpointTypes.RoutingConfig Create()
    {
        var routingConfigResult = CreateRoutingConfig();
        factoryAction?.Invoke(routingConfigResult);

        return routingConfigResult;
    }

    private Humidifier.Events.EndpointTypes.RoutingConfig CreateRoutingConfig()
    {
        var routingConfigResult = new Humidifier.Events.EndpointTypes.RoutingConfig();

        return routingConfigResult;
    }
    public override void CreateChildren(Humidifier.Events.EndpointTypes.RoutingConfig result)
    {
        base.CreateChildren(result);

        result.FailoverConfig ??= FailoverConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointRoutingConfigFactoryExtensions
{
    public static CombinedResult<InnerEndpointRoutingConfigFactory, InnerEndpointFailoverConfigFactory> WithFailoverConfig(this InnerEndpointRoutingConfigFactory parentFactory, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null)
    {
        parentFactory.FailoverConfigFactory = new InnerEndpointFailoverConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FailoverConfigFactory);
    }

    public static CombinedResult<InnerEndpointRoutingConfigFactory, T1, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1>(this CombinedResult<InnerEndpointRoutingConfigFactory, T1> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRoutingConfigFactory, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1>(this CombinedResult<T1, InnerEndpointRoutingConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEndpointRoutingConfigFactory, T1, T2, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2>(this CombinedResult<InnerEndpointRoutingConfigFactory, T1, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRoutingConfigFactory, T2, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2>(this CombinedResult<T1, InnerEndpointRoutingConfigFactory, T2> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRoutingConfigFactory, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2>(this CombinedResult<T1, T2, InnerEndpointRoutingConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEndpointRoutingConfigFactory, T1, T2, T3, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3>(this CombinedResult<InnerEndpointRoutingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRoutingConfigFactory, T2, T3, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3>(this CombinedResult<T1, InnerEndpointRoutingConfigFactory, T2, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRoutingConfigFactory, T3, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointRoutingConfigFactory, T3> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointRoutingConfigFactory, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointRoutingConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEndpointRoutingConfigFactory, T1, T2, T3, T4, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3, T4>(this CombinedResult<InnerEndpointRoutingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEndpointRoutingConfigFactory, T2, T3, T4, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointRoutingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEndpointRoutingConfigFactory, T3, T4, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointRoutingConfigFactory, T3, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEndpointRoutingConfigFactory, T4, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointRoutingConfigFactory, T4> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointRoutingConfigFactory, InnerEndpointFailoverConfigFactory> WithFailoverConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointRoutingConfigFactory> combinedResult, Action<Humidifier.Events.EndpointTypes.FailoverConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailoverConfig(combinedResult.T5, subFactoryAction));
}

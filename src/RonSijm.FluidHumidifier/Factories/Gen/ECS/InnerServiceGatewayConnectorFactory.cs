// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceGatewayConnectorFactory(Action<Humidifier.ECS.ServiceTypes.GatewayConnector> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.GatewayConnector>
{

    internal InnerServiceGatewayConnectorFiltersFactory FiltersFactory { get; set; }

    internal InnerServiceGatewayConnectorHealthCheckFactory HealthCheckFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.GatewayConnector Create()
    {
        var gatewayConnectorResult = CreateGatewayConnector();
        factoryAction?.Invoke(gatewayConnectorResult);

        return gatewayConnectorResult;
    }

    private Humidifier.ECS.ServiceTypes.GatewayConnector CreateGatewayConnector()
    {
        var gatewayConnectorResult = new Humidifier.ECS.ServiceTypes.GatewayConnector();

        return gatewayConnectorResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.GatewayConnector result)
    {
        base.CreateChildren(result);

        result.Filters ??= FiltersFactory?.Build();
        result.HealthCheck ??= HealthCheckFactory?.Build();
    }

} // End Of Class

public static class InnerServiceGatewayConnectorFactoryExtensions
{
    public static CombinedResult<InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorFiltersFactory> WithFilters(this InnerServiceGatewayConnectorFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null)
    {
        parentFactory.FiltersFactory = new InnerServiceGatewayConnectorFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FiltersFactory);
    }

    public static CombinedResult<InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck(this InnerServiceGatewayConnectorFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null)
    {
        parentFactory.HealthCheckFactory = new InnerServiceGatewayConnectorHealthCheckFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HealthCheckFactory);
    }

    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3, T4, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3, T4, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3, T4, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory, T4, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3, T4, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<InnerServiceGatewayConnectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3, T4, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceGatewayConnectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3, T4, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory, T4, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceGatewayConnectorFactory, InnerServiceGatewayConnectorHealthCheckFactory> WithHealthCheck<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceGatewayConnectorFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHealthCheck(combinedResult.T5, subFactoryAction).T2);
}

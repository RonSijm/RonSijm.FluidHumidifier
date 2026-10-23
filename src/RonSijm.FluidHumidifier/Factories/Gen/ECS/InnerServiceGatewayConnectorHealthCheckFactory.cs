// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceGatewayConnectorHealthCheckFactory(Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck>
{

    internal InnerServiceGatewayConnectorHealthCheckMatcherFactory MatcherFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck Create()
    {
        var gatewayConnectorHealthCheckResult = CreateGatewayConnectorHealthCheck();
        factoryAction?.Invoke(gatewayConnectorHealthCheckResult);

        return gatewayConnectorHealthCheckResult;
    }

    private Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck CreateGatewayConnectorHealthCheck()
    {
        var gatewayConnectorHealthCheckResult = new Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck();

        return gatewayConnectorHealthCheckResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck result)
    {
        base.CreateChildren(result);

        result.Matcher ??= MatcherFactory?.Build();
    }

} // End Of Class

public static class InnerServiceGatewayConnectorHealthCheckFactoryExtensions
{
    public static CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher(this InnerServiceGatewayConnectorHealthCheckFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null)
    {
        parentFactory.MatcherFactory = new InnerServiceGatewayConnectorHealthCheckMatcherFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatcherFactory);
    }

    public static CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1>(this CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1>(this CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1, T2, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory, T2, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorHealthCheckFactory, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorHealthCheckFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1, T2, T3, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory, T2, T3, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorHealthCheckFactory, T3, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorHealthCheckFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorHealthCheckFactory, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorHealthCheckFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1, T2, T3, T4, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<InnerServiceGatewayConnectorHealthCheckFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory, T2, T3, T4, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceGatewayConnectorHealthCheckFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceGatewayConnectorHealthCheckFactory, T3, T4, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceGatewayConnectorHealthCheckFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorHealthCheckFactory, T4, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceGatewayConnectorHealthCheckFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceGatewayConnectorHealthCheckFactory, InnerServiceGatewayConnectorHealthCheckMatcherFactory> WithMatcher<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceGatewayConnectorHealthCheckFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatcher(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigRoutingConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig>
{

    internal InnerEndpointConfigPrefixAwareRoutingConfigFactory PrefixAwareRoutingConfigFactory { get; set; }

    protected override Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig Create()
    {
        var routingConfigResult = CreateRoutingConfig();
        factoryAction?.Invoke(routingConfigResult);

        return routingConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig CreateRoutingConfig()
    {
        var routingConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig();

        return routingConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig result)
    {
        base.CreateChildren(result);

        result.PrefixAwareRoutingConfig ??= PrefixAwareRoutingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEndpointConfigRoutingConfigFactoryExtensions
{
    public static CombinedResult<InnerEndpointConfigRoutingConfigFactory, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig(this InnerEndpointConfigRoutingConfigFactory parentFactory, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null)
    {
        parentFactory.PrefixAwareRoutingConfigFactory = new InnerEndpointConfigPrefixAwareRoutingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrefixAwareRoutingConfigFactory);
    }

    public static CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1>(this CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1>(this CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1, T2, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2>(this CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory, T2, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2>(this CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigRoutingConfigFactory, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2>(this CombinedResult<T1, T2, InnerEndpointConfigRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1, T2, T3, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3>(this CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory, T2, T3, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3>(this CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigRoutingConfigFactory, T3, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEndpointConfigRoutingConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigRoutingConfigFactory, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEndpointConfigRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1, T2, T3, T4, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3, T4>(this CombinedResult<InnerEndpointConfigRoutingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory, T2, T3, T4, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEndpointConfigRoutingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEndpointConfigRoutingConfigFactory, T3, T4, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEndpointConfigRoutingConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEndpointConfigRoutingConfigFactory, T4, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEndpointConfigRoutingConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEndpointConfigRoutingConfigFactory, InnerEndpointConfigPrefixAwareRoutingConfigFactory> WithPrefixAwareRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEndpointConfigRoutingConfigFactory> combinedResult, Action<Humidifier.SageMaker.EndpointConfigTypes.PrefixAwareRoutingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixAwareRoutingConfig(combinedResult.T5, subFactoryAction).T2);
}

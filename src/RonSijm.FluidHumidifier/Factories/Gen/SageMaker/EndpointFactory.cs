// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class EndpointFactory(string resourceName = null, Action<Humidifier.SageMaker.Endpoint> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Endpoint>(resourceName)
{

    internal List<InnerEndpointVariantPropertyFactory> ExcludeRetainedVariantPropertiesFactories { get; set; } = [];

    internal InnerEndpointDeploymentConfigFactory DeploymentConfigFactory { get; set; }

    protected override Humidifier.SageMaker.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.SageMaker.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.SageMaker.Endpoint
        {
            GivenName = InputResourceName,
        };

        return endpointResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Endpoint result)
    {
        base.CreateChildren(result);

        result.ExcludeRetainedVariantProperties = ExcludeRetainedVariantPropertiesFactories.Any() ? ExcludeRetainedVariantPropertiesFactories.Select(x => x.Build()).ToList() : null;
        result.DeploymentConfig ??= DeploymentConfigFactory?.Build();
    }

} // End Of Class

public static class EndpointFactoryExtensions
{
    public static CombinedResult<EndpointFactory, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties(this EndpointFactory parentFactory, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null)
    {
        var factory = new InnerEndpointVariantPropertyFactory(subFactoryAction);
        parentFactory.ExcludeRetainedVariantPropertiesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EndpointFactory, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig(this EndpointFactory parentFactory, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null)
    {
        parentFactory.DeploymentConfigFactory = new InnerEndpointDeploymentConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentConfigFactory);
    }

    public static CombinedResult<EndpointFactory, T1, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1>(this CombinedResult<EndpointFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1>(this CombinedResult<T1, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2>(this CombinedResult<EndpointFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2>(this CombinedResult<T1, EndpointFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2>(this CombinedResult<T1, T2, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3>(this CombinedResult<EndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3>(this CombinedResult<T1, EndpointFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3>(this CombinedResult<T1, T2, EndpointFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, T4, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3, T4>(this CombinedResult<EndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, T4, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3, T4>(this CombinedResult<T1, EndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, T4, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, T4, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointFactory, InnerEndpointVariantPropertyFactory> WithExcludeRetainedVariantProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeRetainedVariantProperties(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1>(this CombinedResult<EndpointFactory, T1> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1>(this CombinedResult<T1, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<EndpointFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<T1, EndpointFactory, T2> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2>(this CombinedResult<T1, T2, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<EndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, EndpointFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, T2, EndpointFactory, T3> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, T4, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<EndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, T4, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, EndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, T4, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, T4, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointFactory, T4> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointFactory, InnerEndpointDeploymentConfigFactory> WithDeploymentConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointFactory> combinedResult, Action<Humidifier.SageMaker.EndpointTypes.DeploymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentConfig(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class EndpointFactory(string resourceName = null, Action<Humidifier.EMRContainers.Endpoint> factoryAction = null) : ResourceFactory<Humidifier.EMRContainers.Endpoint>(resourceName)
{

    internal InnerEndpointConfigurationOverridesFactory ConfigurationOverridesFactory { get; set; }

    protected override Humidifier.EMRContainers.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.EMRContainers.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.EMRContainers.Endpoint
        {
            GivenName = InputResourceName,
        };

        return endpointResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.Endpoint result)
    {
        base.CreateChildren(result);

        result.ConfigurationOverrides ??= ConfigurationOverridesFactory?.Build();
    }

} // End Of Class

public static class EndpointFactoryExtensions
{
    public static CombinedResult<EndpointFactory, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides(this EndpointFactory parentFactory, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null)
    {
        parentFactory.ConfigurationOverridesFactory = new InnerEndpointConfigurationOverridesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationOverridesFactory);
    }

    public static CombinedResult<EndpointFactory, T1, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<EndpointFactory, T1> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EndpointFactory, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<T1, EndpointFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EndpointFactory, T1, T2, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<EndpointFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EndpointFactory, T2, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, EndpointFactory, T2> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EndpointFactory, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, T2, EndpointFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EndpointFactory, T1, T2, T3, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<EndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EndpointFactory, T2, T3, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, EndpointFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EndpointFactory, T3, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, EndpointFactory, T3> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EndpointFactory, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EndpointFactory, T1, T2, T3, T4, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<EndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EndpointFactory, T2, T3, T4, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, EndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EndpointFactory, T3, T4, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EndpointFactory, T4, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointFactory, T4> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EndpointFactory, InnerEndpointConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointFactory> combinedResult, Action<Humidifier.EMRContainers.EndpointTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class ServiceFactory(string resourceName = null, Action<Humidifier.RefactorSpaces.Service> factoryAction = null) : ResourceFactory<Humidifier.RefactorSpaces.Service>(resourceName)
{

    internal InnerServiceLambdaEndpointInputFactory LambdaEndpointFactory { get; set; }

    internal InnerServiceUrlEndpointInputFactory UrlEndpointFactory { get; set; }

    protected override Humidifier.RefactorSpaces.Service Create()
    {
        var serviceResult = CreateService();
        factoryAction?.Invoke(serviceResult);

        return serviceResult;
    }

    private Humidifier.RefactorSpaces.Service CreateService()
    {
        var serviceResult = new Humidifier.RefactorSpaces.Service
        {
            GivenName = InputResourceName,
        };

        return serviceResult;
    }
    public override void CreateChildren(Humidifier.RefactorSpaces.Service result)
    {
        base.CreateChildren(result);

        result.LambdaEndpoint ??= LambdaEndpointFactory?.Build();
        result.UrlEndpoint ??= UrlEndpointFactory?.Build();
    }

} // End Of Class

public static class ServiceFactoryExtensions
{
    public static CombinedResult<ServiceFactory, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint(this ServiceFactory parentFactory, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null)
    {
        parentFactory.LambdaEndpointFactory = new InnerServiceLambdaEndpointInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaEndpointFactory);
    }

    public static CombinedResult<ServiceFactory, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint(this ServiceFactory parentFactory, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null)
    {
        parentFactory.UrlEndpointFactory = new InnerServiceUrlEndpointInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UrlEndpointFactory);
    }

    public static CombinedResult<ServiceFactory, T1, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1>(this CombinedResult<ServiceFactory, T1> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1>(this CombinedResult<T1, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2>(this CombinedResult<ServiceFactory, T1, T2> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2>(this CombinedResult<T1, ServiceFactory, T2> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2>(this CombinedResult<T1, T2, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3>(this CombinedResult<ServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3>(this CombinedResult<T1, ServiceFactory, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, ServiceFactory, T3> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, T4, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3, T4>(this CombinedResult<ServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, T4, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, ServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, T4, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceFactory, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, T4, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceFactory, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceFactory, InnerServiceLambdaEndpointInputFactory> WithLambdaEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.LambdaEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaEndpoint(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1>(this CombinedResult<ServiceFactory, T1> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1>(this CombinedResult<T1, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2>(this CombinedResult<ServiceFactory, T1, T2> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2>(this CombinedResult<T1, ServiceFactory, T2> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2>(this CombinedResult<T1, T2, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3>(this CombinedResult<ServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3>(this CombinedResult<T1, ServiceFactory, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, ServiceFactory, T3> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ServiceFactory, T1, T2, T3, T4, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3, T4>(this CombinedResult<ServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ServiceFactory, T2, T3, T4, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, ServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ServiceFactory, T3, T4, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceFactory, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ServiceFactory, T4, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceFactory, T4> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ServiceFactory, InnerServiceUrlEndpointInputFactory> WithUrlEndpoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceFactory> combinedResult, Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlEndpoint(combinedResult.T5, subFactoryAction));
}

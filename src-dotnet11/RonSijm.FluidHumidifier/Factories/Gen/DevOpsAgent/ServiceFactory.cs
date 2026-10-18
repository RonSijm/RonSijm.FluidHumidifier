// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class ServiceFactory(string resourceName = null, Action<Humidifier.DevOpsAgent.Service> factoryAction = null) : ResourceFactory<Humidifier.DevOpsAgent.Service>(resourceName)
{

    internal InnerServiceServiceDetailsFactory ServiceDetailsFactory { get; set; }

    protected override Humidifier.DevOpsAgent.Service Create()
    {
        var serviceResult = CreateService();
        factoryAction?.Invoke(serviceResult);

        return serviceResult;
    }

    private Humidifier.DevOpsAgent.Service CreateService()
    {
        var serviceResult = new Humidifier.DevOpsAgent.Service
        {
            GivenName = InputResourceName,
        };

        return serviceResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.Service result)
    {
        base.CreateChildren(result);

        result.ServiceDetails ??= ServiceDetailsFactory?.Build();
    }

} // End Of Class

public static class ServiceFactoryExtensions
{
    public static CombinedResult<ServiceFactory, InnerServiceServiceDetailsFactory> WithServiceDetails(this ServiceFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null)
    {
        parentFactory.ServiceDetailsFactory = new InnerServiceServiceDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceDetailsFactory);
    }

    public static CombinedResult<ServiceFactory, T1, InnerServiceServiceDetailsFactory> WithServiceDetails<T1>(this CombinedResult<ServiceFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceFactory, InnerServiceServiceDetailsFactory> WithServiceDetails<T1>(this CombinedResult<T1, ServiceFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ServiceFactory, T1, T2, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2>(this CombinedResult<ServiceFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceFactory, T2, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2>(this CombinedResult<T1, ServiceFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceFactory, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2>(this CombinedResult<T1, T2, ServiceFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ServiceFactory, T1, T2, T3, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3>(this CombinedResult<ServiceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceFactory, T2, T3, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3>(this CombinedResult<T1, ServiceFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceFactory, T3, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3>(this CombinedResult<T1, T2, ServiceFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ServiceFactory, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ServiceFactory, T1, T2, T3, T4, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3, T4>(this CombinedResult<ServiceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceFactory, T2, T3, T4, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3, T4>(this CombinedResult<T1, ServiceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceFactory, T3, T4, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ServiceFactory, T4, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ServiceFactory, InnerServiceServiceDetailsFactory> WithServiceDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceDetails(combinedResult.T5, subFactoryAction).T2);
}

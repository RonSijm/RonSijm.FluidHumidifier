// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class ServiceEnvironmentFactory(string resourceName = null, Action<Humidifier.Batch.ServiceEnvironment> factoryAction = null) : ResourceFactory<Humidifier.Batch.ServiceEnvironment>(resourceName)
{

    internal List<InnerServiceEnvironmentCapacityLimitFactory> CapacityLimitsFactories { get; set; } = [];

    protected override Humidifier.Batch.ServiceEnvironment Create()
    {
        var serviceEnvironmentResult = CreateServiceEnvironment();
        factoryAction?.Invoke(serviceEnvironmentResult);

        return serviceEnvironmentResult;
    }

    private Humidifier.Batch.ServiceEnvironment CreateServiceEnvironment()
    {
        var serviceEnvironmentResult = new Humidifier.Batch.ServiceEnvironment
        {
            GivenName = InputResourceName,
        };

        return serviceEnvironmentResult;
    }
    public override void CreateChildren(Humidifier.Batch.ServiceEnvironment result)
    {
        base.CreateChildren(result);

        result.CapacityLimits = CapacityLimitsFactories.Any() ? CapacityLimitsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ServiceEnvironmentFactoryExtensions
{
    public static CombinedResult<ServiceEnvironmentFactory, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits(this ServiceEnvironmentFactory parentFactory, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null)
    {
        var factory = new InnerServiceEnvironmentCapacityLimitFactory(subFactoryAction);
        parentFactory.CapacityLimitsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ServiceEnvironmentFactory, T1, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1>(this CombinedResult<ServiceEnvironmentFactory, T1> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceEnvironmentFactory, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1>(this CombinedResult<T1, ServiceEnvironmentFactory> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ServiceEnvironmentFactory, T1, T2, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2>(this CombinedResult<ServiceEnvironmentFactory, T1, T2> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceEnvironmentFactory, T2, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2>(this CombinedResult<T1, ServiceEnvironmentFactory, T2> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceEnvironmentFactory, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2>(this CombinedResult<T1, T2, ServiceEnvironmentFactory> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ServiceEnvironmentFactory, T1, T2, T3, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<ServiceEnvironmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceEnvironmentFactory, T2, T3, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<T1, ServiceEnvironmentFactory, T2, T3> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceEnvironmentFactory, T3, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<T1, T2, ServiceEnvironmentFactory, T3> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ServiceEnvironmentFactory, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, ServiceEnvironmentFactory> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ServiceEnvironmentFactory, T1, T2, T3, T4, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<ServiceEnvironmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ServiceEnvironmentFactory, T2, T3, T4, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, ServiceEnvironmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ServiceEnvironmentFactory, T3, T4, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, ServiceEnvironmentFactory, T3, T4> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ServiceEnvironmentFactory, T4, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ServiceEnvironmentFactory, T4> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ServiceEnvironmentFactory, InnerServiceEnvironmentCapacityLimitFactory> WithCapacityLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ServiceEnvironmentFactory> combinedResult, Action<Humidifier.Batch.ServiceEnvironmentTypes.CapacityLimit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityLimits(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingSelfManagedEventSourceFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource>
{

    internal InnerEventSourceMappingEndpointsFactory EndpointsFactory { get; set; }

    protected override Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource Create()
    {
        var selfManagedEventSourceResult = CreateSelfManagedEventSource();
        factoryAction?.Invoke(selfManagedEventSourceResult);

        return selfManagedEventSourceResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource CreateSelfManagedEventSource()
    {
        var selfManagedEventSourceResult = new Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource();

        return selfManagedEventSourceResult;
    }
    public override void CreateChildren(Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource result)
    {
        base.CreateChildren(result);

        result.Endpoints ??= EndpointsFactory?.Build();
    }

} // End Of Class

public static class InnerEventSourceMappingSelfManagedEventSourceFactoryExtensions
{
    public static CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, InnerEventSourceMappingEndpointsFactory> WithEndpoints(this InnerEventSourceMappingSelfManagedEventSourceFactory parentFactory, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null)
    {
        parentFactory.EndpointsFactory = new InnerEventSourceMappingEndpointsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointsFactory);
    }

    public static CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1>(this CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1, T2, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2>(this CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory, T2, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedEventSourceFactory, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2>(this CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedEventSourceFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1, T2, T3, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory, T2, T3, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedEventSourceFactory, T3, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedEventSourceFactory, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedEventSourceFactory, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedEventSourceFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1, T2, T3, T4, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<InnerEventSourceMappingSelfManagedEventSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory, T2, T3, T4, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventSourceMappingSelfManagedEventSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedEventSourceFactory, T3, T4, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventSourceMappingSelfManagedEventSourceFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedEventSourceFactory, T4, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingSelfManagedEventSourceFactory, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingSelfManagedEventSourceFactory, InnerEventSourceMappingEndpointsFactory> WithEndpoints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingSelfManagedEventSourceFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.Endpoints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpoints(combinedResult.T5, subFactoryAction));
}

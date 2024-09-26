// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyEventSourceFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.EventSource>
{

    internal InnerLifecyclePolicyEventParametersFactory ParametersFactory { get; set; }

    protected override Humidifier.DLM.LifecyclePolicyTypes.EventSource Create()
    {
        var eventSourceResult = CreateEventSource();
        factoryAction?.Invoke(eventSourceResult);

        return eventSourceResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.EventSource CreateEventSource()
    {
        var eventSourceResult = new Humidifier.DLM.LifecyclePolicyTypes.EventSource();

        return eventSourceResult;
    }
    public override void CreateChildren(Humidifier.DLM.LifecyclePolicyTypes.EventSource result)
    {
        base.CreateChildren(result);

        result.Parameters ??= ParametersFactory?.Build();
    }

} // End Of Class

public static class InnerLifecyclePolicyEventSourceFactoryExtensions
{
    public static CombinedResult<InnerLifecyclePolicyEventSourceFactory, InnerLifecyclePolicyEventParametersFactory> WithParameters(this InnerLifecyclePolicyEventSourceFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null)
    {
        parentFactory.ParametersFactory = new InnerLifecyclePolicyEventParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParametersFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1>(this CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1>(this CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1, T2, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2>(this CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory, T2, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyEventSourceFactory, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyEventSourceFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1, T2, T3, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory, T2, T3, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyEventSourceFactory, T3, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyEventSourceFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyEventSourceFactory, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyEventSourceFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1, T2, T3, T4, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyEventSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory, T2, T3, T4, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyEventSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyEventSourceFactory, T3, T4, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyEventSourceFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyEventSourceFactory, T4, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyEventSourceFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyEventSourceFactory, InnerLifecyclePolicyEventParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyEventSourceFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
}

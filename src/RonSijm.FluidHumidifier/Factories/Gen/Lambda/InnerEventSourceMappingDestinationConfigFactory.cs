// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingDestinationConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig>
{

    internal InnerEventSourceMappingOnFailureFactory OnFailureFactory { get; set; }

    protected override Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig Create()
    {
        var destinationConfigResult = CreateDestinationConfig();
        factoryAction?.Invoke(destinationConfigResult);

        return destinationConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig CreateDestinationConfig()
    {
        var destinationConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig();

        return destinationConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig result)
    {
        base.CreateChildren(result);

        result.OnFailure ??= OnFailureFactory?.Build();
    }

} // End Of Class

public static class InnerEventSourceMappingDestinationConfigFactoryExtensions
{
    public static CombinedResult<InnerEventSourceMappingDestinationConfigFactory, InnerEventSourceMappingOnFailureFactory> WithOnFailure(this InnerEventSourceMappingDestinationConfigFactory parentFactory, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null)
    {
        parentFactory.OnFailureFactory = new InnerEventSourceMappingOnFailureFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnFailureFactory);
    }

    public static CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1>(this CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1>(this CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1, T2, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2>(this CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory, T2, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2>(this CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventSourceMappingDestinationConfigFactory, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2>(this CombinedResult<T1, T2, InnerEventSourceMappingDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1, T2, T3, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory, T2, T3, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventSourceMappingDestinationConfigFactory, T3, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventSourceMappingDestinationConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingDestinationConfigFactory, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1, T2, T3, T4, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<InnerEventSourceMappingDestinationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory, T2, T3, T4, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventSourceMappingDestinationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventSourceMappingDestinationConfigFactory, T3, T4, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventSourceMappingDestinationConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventSourceMappingDestinationConfigFactory, T4, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventSourceMappingDestinationConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingDestinationConfigFactory, InnerEventSourceMappingOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventSourceMappingDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T5, subFactoryAction));
}

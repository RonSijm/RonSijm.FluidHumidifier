// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventInvokeConfigDestinationConfigFactory(Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig>
{

    internal InnerEventInvokeConfigOnSuccessFactory OnSuccessFactory { get; set; }

    internal InnerEventInvokeConfigOnFailureFactory OnFailureFactory { get; set; }

    protected override Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig Create()
    {
        var destinationConfigResult = CreateDestinationConfig();
        factoryAction?.Invoke(destinationConfigResult);

        return destinationConfigResult;
    }

    private Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig CreateDestinationConfig()
    {
        var destinationConfigResult = new Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig();

        return destinationConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig result)
    {
        base.CreateChildren(result);

        result.OnSuccess ??= OnSuccessFactory?.Build();
        result.OnFailure ??= OnFailureFactory?.Build();
    }

} // End Of Class

public static class InnerEventInvokeConfigDestinationConfigFactoryExtensions
{
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess(this InnerEventInvokeConfigDestinationConfigFactory parentFactory, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null)
    {
        parentFactory.OnSuccessFactory = new InnerEventInvokeConfigOnSuccessFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnSuccessFactory);
    }

    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnFailureFactory> WithOnFailure(this InnerEventInvokeConfigDestinationConfigFactory parentFactory, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null)
    {
        parentFactory.OnFailureFactory = new InnerEventInvokeConfigOnFailureFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OnFailureFactory);
    }

    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnSuccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnSuccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2>(this CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3, T4, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3, T4>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3, T4, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3, T4, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory, T4, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnSuccessFactory> WithOnSuccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnSuccess(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2>(this CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3, T4, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<InnerEventInvokeConfigDestinationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3, T4, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventInvokeConfigDestinationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3, T4, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventInvokeConfigDestinationConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory, T4, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEventInvokeConfigDestinationConfigFactory, InnerEventInvokeConfigOnFailureFactory> WithOnFailure<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventInvokeConfigDestinationConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOnFailure(combinedResult.T5, subFactoryAction));
}

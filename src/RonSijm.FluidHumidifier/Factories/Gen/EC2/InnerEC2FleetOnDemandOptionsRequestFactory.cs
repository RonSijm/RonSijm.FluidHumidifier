// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetOnDemandOptionsRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.OnDemandOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.OnDemandOptionsRequest>
{

    internal InnerEC2FleetCapacityReservationOptionsRequestFactory CapacityReservationOptionsFactory { get; set; }

    protected override Humidifier.EC2.EC2FleetTypes.OnDemandOptionsRequest Create()
    {
        var onDemandOptionsRequestResult = CreateOnDemandOptionsRequest();
        factoryAction?.Invoke(onDemandOptionsRequestResult);

        return onDemandOptionsRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.OnDemandOptionsRequest CreateOnDemandOptionsRequest()
    {
        var onDemandOptionsRequestResult = new Humidifier.EC2.EC2FleetTypes.OnDemandOptionsRequest();

        return onDemandOptionsRequestResult;
    }
    public override void CreateChildren(Humidifier.EC2.EC2FleetTypes.OnDemandOptionsRequest result)
    {
        base.CreateChildren(result);

        result.CapacityReservationOptions ??= CapacityReservationOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerEC2FleetOnDemandOptionsRequestFactoryExtensions
{
    public static CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions(this InnerEC2FleetOnDemandOptionsRequestFactory parentFactory, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null)
    {
        parentFactory.CapacityReservationOptionsFactory = new InnerEC2FleetCapacityReservationOptionsRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationOptionsFactory);
    }

    public static CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1>(this CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1>(this CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1, T2, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory, T2, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory, T2> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetOnDemandOptionsRequestFactory, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, T2, InnerEC2FleetOnDemandOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1, T2, T3, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory, T2, T3, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory, T2, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetOnDemandOptionsRequestFactory, T3, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerEC2FleetOnDemandOptionsRequestFactory, T3> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetOnDemandOptionsRequestFactory, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEC2FleetOnDemandOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1, T2, T3, T4, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<InnerEC2FleetOnDemandOptionsRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory, T2, T3, T4, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerEC2FleetOnDemandOptionsRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerEC2FleetOnDemandOptionsRequestFactory, T3, T4, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEC2FleetOnDemandOptionsRequestFactory, T3, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerEC2FleetOnDemandOptionsRequestFactory, T4, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEC2FleetOnDemandOptionsRequestFactory, T4> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerEC2FleetOnDemandOptionsRequestFactory, InnerEC2FleetCapacityReservationOptionsRequestFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEC2FleetOnDemandOptionsRequestFactory> combinedResult, Action<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigOnDemandResizingSpecificationFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification>
{

    internal InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory CapacityReservationOptionsFactory { get; set; }

    protected override Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification Create()
    {
        var onDemandResizingSpecificationResult = CreateOnDemandResizingSpecification();
        factoryAction?.Invoke(onDemandResizingSpecificationResult);

        return onDemandResizingSpecificationResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification CreateOnDemandResizingSpecification()
    {
        var onDemandResizingSpecificationResult = new Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification();

        return onDemandResizingSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationOptions ??= CapacityReservationOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceFleetConfigOnDemandResizingSpecificationFactoryExtensions
{
    public static CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions(this InnerInstanceFleetConfigOnDemandResizingSpecificationFactory parentFactory, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null)
    {
        parentFactory.CapacityReservationOptionsFactory = new InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationOptionsFactory);
    }

    public static CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1, T2, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T2, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1, T2, T3, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T2, T3, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T3, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1, T2, T3, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T2, T3, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T3, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceFleetConfigOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T5, subFactoryAction));
}

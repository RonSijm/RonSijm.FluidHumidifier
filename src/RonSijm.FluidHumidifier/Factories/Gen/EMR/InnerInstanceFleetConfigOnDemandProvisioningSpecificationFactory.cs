// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory(Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification>
{

    internal InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory CapacityReservationOptionsFactory { get; set; }

    protected override Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification Create()
    {
        var onDemandProvisioningSpecificationResult = CreateOnDemandProvisioningSpecification();
        factoryAction?.Invoke(onDemandProvisioningSpecificationResult);

        return onDemandProvisioningSpecificationResult;
    }

    private Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification CreateOnDemandProvisioningSpecification()
    {
        var onDemandProvisioningSpecificationResult = new Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification();

        return onDemandProvisioningSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationOptions ??= CapacityReservationOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactoryExtensions
{
    public static CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions(this InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory parentFactory, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null)
    {
        parentFactory.CapacityReservationOptionsFactory = new InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationOptionsFactory);
    }

    public static CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1, T2, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T2, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T2> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1, T2, T3, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T2, T3, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T3, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T3> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1, T2, T3, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T2, T3, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T3, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T4, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, T4> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory, InnerInstanceFleetConfigOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceFleetConfigOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterOnDemandResizingSpecificationFactory(Action<Humidifier.EMR.ClusterTypes.OnDemandResizingSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.OnDemandResizingSpecification>
{

    internal InnerClusterOnDemandCapacityReservationOptionsFactory CapacityReservationOptionsFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.OnDemandResizingSpecification Create()
    {
        var onDemandResizingSpecificationResult = CreateOnDemandResizingSpecification();
        factoryAction?.Invoke(onDemandResizingSpecificationResult);

        return onDemandResizingSpecificationResult;
    }

    private Humidifier.EMR.ClusterTypes.OnDemandResizingSpecification CreateOnDemandResizingSpecification()
    {
        var onDemandResizingSpecificationResult = new Humidifier.EMR.ClusterTypes.OnDemandResizingSpecification();

        return onDemandResizingSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.OnDemandResizingSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationOptions ??= CapacityReservationOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterOnDemandResizingSpecificationFactoryExtensions
{
    public static CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions(this InnerClusterOnDemandResizingSpecificationFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null)
    {
        parentFactory.CapacityReservationOptionsFactory = new InnerClusterOnDemandCapacityReservationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationOptionsFactory);
    }

    public static CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1, T2, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory, T2, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOnDemandResizingSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, T2, InnerClusterOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1, T2, T3, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory, T2, T3, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOnDemandResizingSpecificationFactory, T3, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterOnDemandResizingSpecificationFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOnDemandResizingSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1, T2, T3, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<InnerClusterOnDemandResizingSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory, T2, T3, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterOnDemandResizingSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOnDemandResizingSpecificationFactory, T3, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterOnDemandResizingSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOnDemandResizingSpecificationFactory, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterOnDemandResizingSpecificationFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterOnDemandResizingSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterOnDemandResizingSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T5, subFactoryAction));
}

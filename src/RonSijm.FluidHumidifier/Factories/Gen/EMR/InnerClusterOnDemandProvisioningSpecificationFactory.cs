// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterOnDemandProvisioningSpecificationFactory(Action<Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification>
{

    internal InnerClusterOnDemandCapacityReservationOptionsFactory CapacityReservationOptionsFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification Create()
    {
        var onDemandProvisioningSpecificationResult = CreateOnDemandProvisioningSpecification();
        factoryAction?.Invoke(onDemandProvisioningSpecificationResult);

        return onDemandProvisioningSpecificationResult;
    }

    private Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification CreateOnDemandProvisioningSpecification()
    {
        var onDemandProvisioningSpecificationResult = new Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification();

        return onDemandProvisioningSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.OnDemandProvisioningSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationOptions ??= CapacityReservationOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterOnDemandProvisioningSpecificationFactoryExtensions
{
    public static CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions(this InnerClusterOnDemandProvisioningSpecificationFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null)
    {
        parentFactory.CapacityReservationOptionsFactory = new InnerClusterOnDemandCapacityReservationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationOptionsFactory);
    }

    public static CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1>(this CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1, T2, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory, T2, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOnDemandProvisioningSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2>(this CombinedResult<T1, T2, InnerClusterOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1, T2, T3, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory, T2, T3, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOnDemandProvisioningSpecificationFactory, T3, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterOnDemandProvisioningSpecificationFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOnDemandProvisioningSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1, T2, T3, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<InnerClusterOnDemandProvisioningSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory, T2, T3, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterOnDemandProvisioningSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterOnDemandProvisioningSpecificationFactory, T3, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterOnDemandProvisioningSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterOnDemandProvisioningSpecificationFactory, T4, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterOnDemandProvisioningSpecificationFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterOnDemandProvisioningSpecificationFactory, InnerClusterOnDemandCapacityReservationOptionsFactory> WithCapacityReservationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterOnDemandProvisioningSpecificationFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.OnDemandCapacityReservationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationOptions(combinedResult.T5, subFactoryAction));
}

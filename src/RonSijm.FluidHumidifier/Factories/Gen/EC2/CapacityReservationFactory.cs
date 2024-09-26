// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class CapacityReservationFactory(string resourceName = null, Action<Humidifier.EC2.CapacityReservation> factoryAction = null) : ResourceFactory<Humidifier.EC2.CapacityReservation>(resourceName)
{

    internal List<InnerCapacityReservationTagSpecificationFactory> TagSpecificationsFactories { get; set; } = [];

    protected override Humidifier.EC2.CapacityReservation Create()
    {
        var capacityReservationResult = CreateCapacityReservation();
        factoryAction?.Invoke(capacityReservationResult);

        return capacityReservationResult;
    }

    private Humidifier.EC2.CapacityReservation CreateCapacityReservation()
    {
        var capacityReservationResult = new Humidifier.EC2.CapacityReservation
        {
            GivenName = InputResourceName,
        };

        return capacityReservationResult;
    }
    public override void CreateChildren(Humidifier.EC2.CapacityReservation result)
    {
        base.CreateChildren(result);

        result.TagSpecifications = TagSpecificationsFactories.Any() ? TagSpecificationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CapacityReservationFactoryExtensions
{
    public static CombinedResult<CapacityReservationFactory, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications(this CapacityReservationFactory parentFactory, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null)
    {
        var factory = new InnerCapacityReservationTagSpecificationFactory(subFactoryAction);
        parentFactory.TagSpecificationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CapacityReservationFactory, T1, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<CapacityReservationFactory, T1> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<T1, CapacityReservationFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CapacityReservationFactory, T1, T2, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<CapacityReservationFactory, T1, T2> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, T2, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, CapacityReservationFactory, T2> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFactory, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, T2, CapacityReservationFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CapacityReservationFactory, T1, T2, T3, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<CapacityReservationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, T2, T3, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, CapacityReservationFactory, T2, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFactory, T3, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, CapacityReservationFactory, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFactory, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapacityReservationFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CapacityReservationFactory, T1, T2, T3, T4, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<CapacityReservationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFactory, T2, T3, T4, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, CapacityReservationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFactory, T3, T4, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapacityReservationFactory, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFactory, T4, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapacityReservationFactory, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CapacityReservationFactory, InnerCapacityReservationTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapacityReservationFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T5, subFactoryAction));
}

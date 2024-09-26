// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class CapacityReservationFleetFactory(string resourceName = null, Action<Humidifier.EC2.CapacityReservationFleet> factoryAction = null) : ResourceFactory<Humidifier.EC2.CapacityReservationFleet>(resourceName)
{

    internal List<InnerCapacityReservationFleetTagSpecificationFactory> TagSpecificationsFactories { get; set; } = [];

    internal List<InnerCapacityReservationFleetInstanceTypeSpecificationFactory> InstanceTypeSpecificationsFactories { get; set; } = [];

    protected override Humidifier.EC2.CapacityReservationFleet Create()
    {
        var capacityReservationFleetResult = CreateCapacityReservationFleet();
        factoryAction?.Invoke(capacityReservationFleetResult);

        return capacityReservationFleetResult;
    }

    private Humidifier.EC2.CapacityReservationFleet CreateCapacityReservationFleet()
    {
        var capacityReservationFleetResult = new Humidifier.EC2.CapacityReservationFleet
        {
            GivenName = InputResourceName,
        };

        return capacityReservationFleetResult;
    }
    public override void CreateChildren(Humidifier.EC2.CapacityReservationFleet result)
    {
        base.CreateChildren(result);

        result.TagSpecifications = TagSpecificationsFactories.Any() ? TagSpecificationsFactories.Select(x => x.Build()).ToList() : null;
        result.InstanceTypeSpecifications = InstanceTypeSpecificationsFactories.Any() ? InstanceTypeSpecificationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CapacityReservationFleetFactoryExtensions
{
    public static CombinedResult<CapacityReservationFleetFactory, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications(this CapacityReservationFleetFactory parentFactory, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null)
    {
        var factory = new InnerCapacityReservationFleetTagSpecificationFactory(subFactoryAction);
        parentFactory.TagSpecificationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CapacityReservationFleetFactory, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications(this CapacityReservationFleetFactory parentFactory, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null)
    {
        var factory = new InnerCapacityReservationFleetInstanceTypeSpecificationFactory(subFactoryAction);
        parentFactory.InstanceTypeSpecificationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CapacityReservationFleetFactory, T1, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<CapacityReservationFleetFactory, T1> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1>(this CombinedResult<T1, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CapacityReservationFleetFactory, T1, T2, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<CapacityReservationFleetFactory, T1, T2> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, T2, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, CapacityReservationFleetFactory, T2> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFleetFactory, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2>(this CombinedResult<T1, T2, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CapacityReservationFleetFactory, T1, T2, T3, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<CapacityReservationFleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, T2, T3, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, CapacityReservationFleetFactory, T2, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFleetFactory, T3, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, CapacityReservationFleetFactory, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFleetFactory, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CapacityReservationFleetFactory, T1, T2, T3, T4, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<CapacityReservationFleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, T2, T3, T4, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, CapacityReservationFleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFleetFactory, T3, T4, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapacityReservationFleetFactory, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFleetFactory, T4, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapacityReservationFleetFactory, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CapacityReservationFleetFactory, InnerCapacityReservationFleetTagSpecificationFactory> WithTagSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.TagSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTagSpecifications(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CapacityReservationFleetFactory, T1, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1>(this CombinedResult<CapacityReservationFleetFactory, T1> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1>(this CombinedResult<T1, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CapacityReservationFleetFactory, T1, T2, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2>(this CombinedResult<CapacityReservationFleetFactory, T1, T2> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, T2, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2>(this CombinedResult<T1, CapacityReservationFleetFactory, T2> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFleetFactory, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2>(this CombinedResult<T1, T2, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CapacityReservationFleetFactory, T1, T2, T3, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3>(this CombinedResult<CapacityReservationFleetFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, T2, T3, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3>(this CombinedResult<T1, CapacityReservationFleetFactory, T2, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFleetFactory, T3, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, CapacityReservationFleetFactory, T3> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFleetFactory, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CapacityReservationFleetFactory, T1, T2, T3, T4, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3, T4>(this CombinedResult<CapacityReservationFleetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapacityReservationFleetFactory, T2, T3, T4, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, CapacityReservationFleetFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapacityReservationFleetFactory, T3, T4, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapacityReservationFleetFactory, T3, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapacityReservationFleetFactory, T4, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapacityReservationFleetFactory, T4> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CapacityReservationFleetFactory, InnerCapacityReservationFleetInstanceTypeSpecificationFactory> WithInstanceTypeSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapacityReservationFleetFactory> combinedResult, Action<Humidifier.EC2.CapacityReservationFleetTypes.InstanceTypeSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceTypeSpecifications(combinedResult.T5, subFactoryAction));
}

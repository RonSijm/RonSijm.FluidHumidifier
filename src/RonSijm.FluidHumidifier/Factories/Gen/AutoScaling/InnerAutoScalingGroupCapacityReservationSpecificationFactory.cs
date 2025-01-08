// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupCapacityReservationSpecificationFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification>
{

    internal InnerAutoScalingGroupCapacityReservationTargetFactory CapacityReservationTargetFactory { get; set; }

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification Create()
    {
        var capacityReservationSpecificationResult = CreateCapacityReservationSpecification();
        factoryAction?.Invoke(capacityReservationSpecificationResult);

        return capacityReservationSpecificationResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification CreateCapacityReservationSpecification()
    {
        var capacityReservationSpecificationResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification();

        return capacityReservationSpecificationResult;
    }
    public override void CreateChildren(Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationTarget ??= CapacityReservationTargetFactory?.Build();
    }

} // End Of Class

public static class InnerAutoScalingGroupCapacityReservationSpecificationFactoryExtensions
{
    public static CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget(this InnerAutoScalingGroupCapacityReservationSpecificationFactory parentFactory, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null)
    {
        parentFactory.CapacityReservationTargetFactory = new InnerAutoScalingGroupCapacityReservationTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationTargetFactory);
    }

    public static CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1, T2, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T2, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T2> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutoScalingGroupCapacityReservationSpecificationFactory, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, T2, InnerAutoScalingGroupCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1, T2, T3, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T2, T3, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T3, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAutoScalingGroupCapacityReservationSpecificationFactory, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoScalingGroupCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1, T2, T3, T4, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<InnerAutoScalingGroupCapacityReservationSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T2, T3, T4, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T3, T4, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T4, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoScalingGroupCapacityReservationSpecificationFactory, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAutoScalingGroupCapacityReservationSpecificationFactory, InnerAutoScalingGroupCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoScalingGroupCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T5, subFactoryAction));
}

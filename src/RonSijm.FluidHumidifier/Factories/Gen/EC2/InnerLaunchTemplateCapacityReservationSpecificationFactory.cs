// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateCapacityReservationSpecificationFactory(Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationSpecification>
{

    internal InnerLaunchTemplateCapacityReservationTargetFactory CapacityReservationTargetFactory { get; set; }

    protected override Humidifier.EC2.LaunchTemplateTypes.CapacityReservationSpecification Create()
    {
        var capacityReservationSpecificationResult = CreateCapacityReservationSpecification();
        factoryAction?.Invoke(capacityReservationSpecificationResult);

        return capacityReservationSpecificationResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.CapacityReservationSpecification CreateCapacityReservationSpecification()
    {
        var capacityReservationSpecificationResult = new Humidifier.EC2.LaunchTemplateTypes.CapacityReservationSpecification();

        return capacityReservationSpecificationResult;
    }
    public override void CreateChildren(Humidifier.EC2.LaunchTemplateTypes.CapacityReservationSpecification result)
    {
        base.CreateChildren(result);

        result.CapacityReservationTarget ??= CapacityReservationTargetFactory?.Build();
    }

} // End Of Class

public static class InnerLaunchTemplateCapacityReservationSpecificationFactoryExtensions
{
    public static CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget(this InnerLaunchTemplateCapacityReservationSpecificationFactory parentFactory, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null)
    {
        parentFactory.CapacityReservationTargetFactory = new InnerLaunchTemplateCapacityReservationTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityReservationTargetFactory);
    }

    public static CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1>(this CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1, T2, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory, T2, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateCapacityReservationSpecificationFactory, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2>(this CombinedResult<T1, T2, InnerLaunchTemplateCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1, T2, T3, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory, T2, T3, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateCapacityReservationSpecificationFactory, T3, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerLaunchTemplateCapacityReservationSpecificationFactory, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchTemplateCapacityReservationSpecificationFactory, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLaunchTemplateCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1, T2, T3, T4, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<InnerLaunchTemplateCapacityReservationSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory, T2, T3, T4, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerLaunchTemplateCapacityReservationSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateCapacityReservationSpecificationFactory, T3, T4, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLaunchTemplateCapacityReservationSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchTemplateCapacityReservationSpecificationFactory, T4, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLaunchTemplateCapacityReservationSpecificationFactory, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLaunchTemplateCapacityReservationSpecificationFactory, InnerLaunchTemplateCapacityReservationTargetFactory> WithCapacityReservationTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLaunchTemplateCapacityReservationSpecificationFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityReservationTarget(combinedResult.T5, subFactoryAction));
}

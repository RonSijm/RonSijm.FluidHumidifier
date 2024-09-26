// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentSegmentDimensionsFactory(Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions>
{

    internal InnerSegmentDemographicFactory DemographicFactory { get; set; }

    internal InnerSegmentBehaviorFactory BehaviorFactory { get; set; }

    internal InnerSegmentLocationFactory LocationFactory { get; set; }

    protected override Humidifier.Pinpoint.SegmentTypes.SegmentDimensions Create()
    {
        var segmentDimensionsResult = CreateSegmentDimensions();
        factoryAction?.Invoke(segmentDimensionsResult);

        return segmentDimensionsResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.SegmentDimensions CreateSegmentDimensions()
    {
        var segmentDimensionsResult = new Humidifier.Pinpoint.SegmentTypes.SegmentDimensions();

        return segmentDimensionsResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.SegmentTypes.SegmentDimensions result)
    {
        base.CreateChildren(result);

        result.Demographic ??= DemographicFactory?.Build();
        result.Behavior ??= BehaviorFactory?.Build();
        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InnerSegmentSegmentDimensionsFactoryExtensions
{
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, InnerSegmentDemographicFactory> WithDemographic(this InnerSegmentSegmentDimensionsFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null)
    {
        parentFactory.DemographicFactory = new InnerSegmentDemographicFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DemographicFactory);
    }

    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, InnerSegmentBehaviorFactory> WithBehavior(this InnerSegmentSegmentDimensionsFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null)
    {
        parentFactory.BehaviorFactory = new InnerSegmentBehaviorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BehaviorFactory);
    }

    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, InnerSegmentLocationFactory> WithLocation(this InnerSegmentSegmentDimensionsFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerSegmentLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, InnerSegmentDemographicFactory> WithDemographic<T1>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, WithDemographic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, InnerSegmentDemographicFactory> WithDemographic<T1>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, WithDemographic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, InnerSegmentDemographicFactory> WithDemographic<T1, T2>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, InnerSegmentDemographicFactory> WithDemographic<T1, T2>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, InnerSegmentDemographicFactory> WithDemographic<T1, T2>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, T4, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3, T4>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, T4, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3, T4>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, T4, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, T4, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSegmentSegmentDimensionsFactory, InnerSegmentDemographicFactory> WithDemographic<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Demographic> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDemographic(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, InnerSegmentBehaviorFactory> WithBehavior<T1>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, WithBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, InnerSegmentBehaviorFactory> WithBehavior<T1>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, WithBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, InnerSegmentBehaviorFactory> WithBehavior<T1, T2>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, InnerSegmentBehaviorFactory> WithBehavior<T1, T2>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, InnerSegmentBehaviorFactory> WithBehavior<T1, T2>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, T4, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3, T4>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, T4, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3, T4>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, T4, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, T4, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSegmentSegmentDimensionsFactory, InnerSegmentBehaviorFactory> WithBehavior<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Behavior> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBehavior(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, InnerSegmentLocationFactory> WithLocation<T1>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, InnerSegmentLocationFactory> WithLocation<T1>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, InnerSegmentLocationFactory> WithLocation<T1, T2>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, InnerSegmentLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, InnerSegmentLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, InnerSegmentLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, InnerSegmentLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, InnerSegmentLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, InnerSegmentLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, T4, InnerSegmentLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InnerSegmentSegmentDimensionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, T4, InnerSegmentLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerSegmentSegmentDimensionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, T4, InnerSegmentLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSegmentSegmentDimensionsFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, T4, InnerSegmentLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSegmentSegmentDimensionsFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSegmentSegmentDimensionsFactory, InnerSegmentLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSegmentSegmentDimensionsFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}

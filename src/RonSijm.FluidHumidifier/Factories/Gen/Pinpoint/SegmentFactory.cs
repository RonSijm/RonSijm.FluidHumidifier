// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class SegmentFactory(string resourceName = null, Action<Humidifier.Pinpoint.Segment> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.Segment>(resourceName)
{

    internal InnerSegmentSegmentGroupsFactory SegmentGroupsFactory { get; set; }

    internal InnerSegmentSegmentDimensionsFactory DimensionsFactory { get; set; }

    protected override Humidifier.Pinpoint.Segment Create()
    {
        var segmentResult = CreateSegment();
        factoryAction?.Invoke(segmentResult);

        return segmentResult;
    }

    private Humidifier.Pinpoint.Segment CreateSegment()
    {
        var segmentResult = new Humidifier.Pinpoint.Segment
        {
            GivenName = InputResourceName,
        };

        return segmentResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.Segment result)
    {
        base.CreateChildren(result);

        result.SegmentGroups ??= SegmentGroupsFactory?.Build();
        result.Dimensions ??= DimensionsFactory?.Build();
    }

} // End Of Class

public static class SegmentFactoryExtensions
{
    public static CombinedResult<SegmentFactory, InnerSegmentSegmentGroupsFactory> WithSegmentGroups(this SegmentFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null)
    {
        parentFactory.SegmentGroupsFactory = new InnerSegmentSegmentGroupsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SegmentGroupsFactory);
    }

    public static CombinedResult<SegmentFactory, InnerSegmentSegmentDimensionsFactory> WithDimensions(this SegmentFactory parentFactory, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null)
    {
        parentFactory.DimensionsFactory = new InnerSegmentSegmentDimensionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DimensionsFactory);
    }

    public static CombinedResult<SegmentFactory, T1, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1>(this CombinedResult<SegmentFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1>(this CombinedResult<T1, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SegmentFactory, T1, T2, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2>(this CombinedResult<SegmentFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, T2, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2>(this CombinedResult<T1, SegmentFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentFactory, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2>(this CombinedResult<T1, T2, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SegmentFactory, T1, T2, T3, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<SegmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, T2, T3, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<T1, SegmentFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentFactory, T3, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<T1, T2, SegmentFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SegmentFactory, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3>(this CombinedResult<T1, T2, T3, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SegmentFactory, T1, T2, T3, T4, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<SegmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, T2, T3, T4, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, SegmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentFactory, T3, T4, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, SegmentFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SegmentFactory, T4, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SegmentFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SegmentFactory, InnerSegmentSegmentGroupsFactory> WithSegmentGroups<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSegmentGroups(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SegmentFactory, T1, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1>(this CombinedResult<SegmentFactory, T1> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1>(this CombinedResult<T1, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SegmentFactory, T1, T2, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2>(this CombinedResult<SegmentFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, T2, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2>(this CombinedResult<T1, SegmentFactory, T2> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentFactory, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2>(this CombinedResult<T1, T2, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SegmentFactory, T1, T2, T3, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<SegmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, T2, T3, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, SegmentFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentFactory, T3, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, T2, SegmentFactory, T3> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SegmentFactory, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, T2, T3, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SegmentFactory, T1, T2, T3, T4, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<SegmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SegmentFactory, T2, T3, T4, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, SegmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SegmentFactory, T3, T4, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, SegmentFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SegmentFactory, T4, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SegmentFactory, T4> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SegmentFactory, InnerSegmentSegmentDimensionsFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SegmentFactory> combinedResult, Action<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T5, subFactoryAction));
}

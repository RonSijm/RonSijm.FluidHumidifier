// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerSegmentSegmentGroupsFactory(Action<Humidifier.Pinpoint.SegmentTypes.SegmentGroups> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.SegmentTypes.SegmentGroups>
{

    protected override Humidifier.Pinpoint.SegmentTypes.SegmentGroups Create()
    {
        var segmentGroupsResult = CreateSegmentGroups();
        factoryAction?.Invoke(segmentGroupsResult);

        return segmentGroupsResult;
    }

    private Humidifier.Pinpoint.SegmentTypes.SegmentGroups CreateSegmentGroups()
    {
        var segmentGroupsResult = new Humidifier.Pinpoint.SegmentTypes.SegmentGroups();

        return segmentGroupsResult;
    }

} // End Of Class

public static class InnerSegmentSegmentGroupsFactoryExtensions
{
}

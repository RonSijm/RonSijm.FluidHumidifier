// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerSegmentDefinitionSegmentGroupFactory(Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup>
{

    protected override Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup Create()
    {
        var segmentGroupResult = CreateSegmentGroup();
        factoryAction?.Invoke(segmentGroupResult);

        return segmentGroupResult;
    }

    private Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup CreateSegmentGroup()
    {
        var segmentGroupResult = new Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentGroup();

        return segmentGroupResult;
    }

} // End Of Class

public static class InnerSegmentDefinitionSegmentGroupFactoryExtensions
{
}

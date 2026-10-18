// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerSegmentDefinitionSegmentSortFactory(Action<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentSort> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentSort>
{

    protected override Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentSort Create()
    {
        var segmentSortResult = CreateSegmentSort();
        factoryAction?.Invoke(segmentSortResult);

        return segmentSortResult;
    }

    private Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentSort CreateSegmentSort()
    {
        var segmentSortResult = new Humidifier.CustomerProfiles.SegmentDefinitionTypes.SegmentSort();

        return segmentSortResult;
    }

} // End Of Class

public static class InnerSegmentDefinitionSegmentSortFactoryExtensions
{
}

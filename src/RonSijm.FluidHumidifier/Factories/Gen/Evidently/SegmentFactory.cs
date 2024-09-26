// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class SegmentFactory(string resourceName = null, Action<Humidifier.Evidently.Segment> factoryAction = null) : ResourceFactory<Humidifier.Evidently.Segment>(resourceName)
{

    protected override Humidifier.Evidently.Segment Create()
    {
        var segmentResult = CreateSegment();
        factoryAction?.Invoke(segmentResult);

        return segmentResult;
    }

    private Humidifier.Evidently.Segment CreateSegment()
    {
        var segmentResult = new Humidifier.Evidently.Segment
        {
            GivenName = InputResourceName,
        };

        return segmentResult;
    }

} // End Of Class

public static class SegmentFactoryExtensions
{
}

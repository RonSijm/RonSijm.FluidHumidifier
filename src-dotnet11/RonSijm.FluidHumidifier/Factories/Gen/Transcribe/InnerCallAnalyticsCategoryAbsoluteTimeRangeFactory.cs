// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerCallAnalyticsCategoryAbsoluteTimeRangeFactory(Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange>
{

    protected override Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange Create()
    {
        var absoluteTimeRangeResult = CreateAbsoluteTimeRange();
        factoryAction?.Invoke(absoluteTimeRangeResult);

        return absoluteTimeRangeResult;
    }

    private Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange CreateAbsoluteTimeRange()
    {
        var absoluteTimeRangeResult = new Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange();

        return absoluteTimeRangeResult;
    }

} // End Of Class

public static class InnerCallAnalyticsCategoryAbsoluteTimeRangeFactoryExtensions
{
}

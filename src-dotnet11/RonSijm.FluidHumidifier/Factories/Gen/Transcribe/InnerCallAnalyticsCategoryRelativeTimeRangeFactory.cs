// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerCallAnalyticsCategoryRelativeTimeRangeFactory(Action<Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange>
{

    protected override Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange Create()
    {
        var relativeTimeRangeResult = CreateRelativeTimeRange();
        factoryAction?.Invoke(relativeTimeRangeResult);

        return relativeTimeRangeResult;
    }

    private Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange CreateRelativeTimeRange()
    {
        var relativeTimeRangeResult = new Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange();

        return relativeTimeRangeResult;
    }

} // End Of Class

public static class InnerCallAnalyticsCategoryRelativeTimeRangeFactoryExtensions
{
}

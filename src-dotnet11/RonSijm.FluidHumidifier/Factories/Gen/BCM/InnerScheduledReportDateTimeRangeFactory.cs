// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCM;

public class InnerScheduledReportDateTimeRangeFactory(Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> factoryAction = null) : SubResourceFactory<Humidifier.BCM.ScheduledReportTypes.DateTimeRange>
{

    internal InnerScheduledReportDateTimeValueFactory EndTimeFactory { get; set; }

    internal InnerScheduledReportDateTimeValueFactory StartTimeFactory { get; set; }

    protected override Humidifier.BCM.ScheduledReportTypes.DateTimeRange Create()
    {
        var dateTimeRangeResult = CreateDateTimeRange();
        factoryAction?.Invoke(dateTimeRangeResult);

        return dateTimeRangeResult;
    }

    private Humidifier.BCM.ScheduledReportTypes.DateTimeRange CreateDateTimeRange()
    {
        var dateTimeRangeResult = new Humidifier.BCM.ScheduledReportTypes.DateTimeRange();

        return dateTimeRangeResult;
    }
    public override void CreateChildren(Humidifier.BCM.ScheduledReportTypes.DateTimeRange result)
    {
        base.CreateChildren(result);

        result.EndTime ??= EndTimeFactory?.Build();
        result.StartTime ??= StartTimeFactory?.Build();
    }

} // End Of Class

public static class InnerScheduledReportDateTimeRangeFactoryExtensions
{
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithEndTime(this InnerScheduledReportDateTimeRangeFactory parentFactory, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null)
    {
        parentFactory.EndTimeFactory = new InnerScheduledReportDateTimeValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndTimeFactory);
    }

    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithStartTime(this InnerScheduledReportDateTimeRangeFactory parentFactory, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null)
    {
        parentFactory.StartTimeFactory = new InnerScheduledReportDateTimeValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StartTimeFactory);
    }

    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2>(this CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3, T4, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3, T4, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3, T4, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory, T4, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithEndTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndTime(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2>(this CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3, T4, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<InnerScheduledReportDateTimeRangeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3, T4, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledReportDateTimeRangeFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3, T4, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledReportDateTimeRangeFactory, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory, T4, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledReportDateTimeRangeFactory, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledReportDateTimeRangeFactory, InnerScheduledReportDateTimeValueFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledReportDateTimeRangeFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T5, subFactoryAction).T2);
}

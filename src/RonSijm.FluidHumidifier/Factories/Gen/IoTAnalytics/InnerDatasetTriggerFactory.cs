// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetTriggerFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.Trigger> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.Trigger>
{

    internal InnerDatasetScheduleFactory ScheduleFactory { get; set; }

    internal InnerDatasetTriggeringDatasetFactory TriggeringDatasetFactory { get; set; }

    protected override Humidifier.IoTAnalytics.DatasetTypes.Trigger Create()
    {
        var triggerResult = CreateTrigger();
        factoryAction?.Invoke(triggerResult);

        return triggerResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.Trigger CreateTrigger()
    {
        var triggerResult = new Humidifier.IoTAnalytics.DatasetTypes.Trigger();

        return triggerResult;
    }
    public override void CreateChildren(Humidifier.IoTAnalytics.DatasetTypes.Trigger result)
    {
        base.CreateChildren(result);

        result.Schedule ??= ScheduleFactory?.Build();
        result.TriggeringDataset ??= TriggeringDatasetFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetTriggerFactoryExtensions
{
    public static CombinedResult<InnerDatasetTriggerFactory, InnerDatasetScheduleFactory> WithSchedule(this InnerDatasetTriggerFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerDatasetScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<InnerDatasetTriggerFactory, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset(this InnerDatasetTriggerFactory parentFactory, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null)
    {
        parentFactory.TriggeringDatasetFactory = new InnerDatasetTriggeringDatasetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TriggeringDatasetFactory);
    }

    public static CombinedResult<InnerDatasetTriggerFactory, T1, InnerDatasetScheduleFactory> WithSchedule<T1>(this CombinedResult<InnerDatasetTriggerFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, InnerDatasetScheduleFactory> WithSchedule<T1>(this CombinedResult<T1, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetTriggerFactory, T1, T2, InnerDatasetScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<InnerDatasetTriggerFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, T2, InnerDatasetScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, InnerDatasetTriggerFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetTriggerFactory, InnerDatasetScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3, T4, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3, T4, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3, T4, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory, T4, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetTriggerFactory, InnerDatasetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDatasetTriggerFactory, T1, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1>(this CombinedResult<InnerDatasetTriggerFactory, T1> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1>(this CombinedResult<T1, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetTriggerFactory, T1, T2, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2>(this CombinedResult<InnerDatasetTriggerFactory, T1, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, T2, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2>(this CombinedResult<T1, InnerDatasetTriggerFactory, T2> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetTriggerFactory, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2>(this CombinedResult<T1, T2, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3>(this CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3>(this CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3, T4, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3, T4>(this CombinedResult<InnerDatasetTriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3, T4, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetTriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3, T4, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetTriggerFactory, T3, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory, T4, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetTriggerFactory, T4> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetTriggerFactory, InnerDatasetTriggeringDatasetFactory> WithTriggeringDataset<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetTriggerFactory> combinedResult, Action<Humidifier.IoTAnalytics.DatasetTypes.TriggeringDataset> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggeringDataset(combinedResult.T5, subFactoryAction));
}

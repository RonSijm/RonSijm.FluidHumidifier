// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie2;

public class InnerClassificationJobJobScheduleFrequencyFactory(Action<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency> factoryAction = null) : SubResourceFactory<Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency>
{

    internal InnerClassificationJobWeeklyScheduleFactory WeeklyScheduleFactory { get; set; }

    protected override Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency Create()
    {
        var jobScheduleFrequencyResult = CreateJobScheduleFrequency();
        factoryAction?.Invoke(jobScheduleFrequencyResult);

        return jobScheduleFrequencyResult;
    }

    private Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency CreateJobScheduleFrequency()
    {
        var jobScheduleFrequencyResult = new Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency();

        return jobScheduleFrequencyResult;
    }
    public override void CreateChildren(Humidifier.Macie2.ClassificationJobTypes.JobScheduleFrequency result)
    {
        base.CreateChildren(result);

        result.WeeklySchedule ??= WeeklyScheduleFactory?.Build();
    }

} // End Of Class

public static class InnerClassificationJobJobScheduleFrequencyFactoryExtensions
{
    public static CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule(this InnerClassificationJobJobScheduleFrequencyFactory parentFactory, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null)
    {
        parentFactory.WeeklyScheduleFactory = new InnerClassificationJobWeeklyScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WeeklyScheduleFactory);
    }

    public static CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1>(this CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1>(this CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1, T2, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2>(this CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1, T2> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory, T2, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2>(this CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory, T2> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClassificationJobJobScheduleFrequencyFactory, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2>(this CombinedResult<T1, T2, InnerClassificationJobJobScheduleFrequencyFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1, T2, T3, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3>(this CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory, T2, T3, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3>(this CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory, T2, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClassificationJobJobScheduleFrequencyFactory, T3, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3>(this CombinedResult<T1, T2, InnerClassificationJobJobScheduleFrequencyFactory, T3> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClassificationJobJobScheduleFrequencyFactory, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClassificationJobJobScheduleFrequencyFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1, T2, T3, T4, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3, T4>(this CombinedResult<InnerClassificationJobJobScheduleFrequencyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory, T2, T3, T4, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3, T4>(this CombinedResult<T1, InnerClassificationJobJobScheduleFrequencyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClassificationJobJobScheduleFrequencyFactory, T3, T4, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClassificationJobJobScheduleFrequencyFactory, T3, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClassificationJobJobScheduleFrequencyFactory, T4, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClassificationJobJobScheduleFrequencyFactory, T4> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClassificationJobJobScheduleFrequencyFactory, InnerClassificationJobWeeklyScheduleFactory> WithWeeklySchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClassificationJobJobScheduleFrequencyFactory> combinedResult, Action<Humidifier.Macie2.ClassificationJobTypes.WeeklySchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeeklySchedule(combinedResult.T5, subFactoryAction).T2);
}

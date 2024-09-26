// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCisScanConfigurationWeeklyScheduleFactory(Action<Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule>
{

    internal InnerCisScanConfigurationTimeFactory StartTimeFactory { get; set; }

    protected override Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule Create()
    {
        var weeklyScheduleResult = CreateWeeklySchedule();
        factoryAction?.Invoke(weeklyScheduleResult);

        return weeklyScheduleResult;
    }

    private Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule CreateWeeklySchedule()
    {
        var weeklyScheduleResult = new Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule();

        return weeklyScheduleResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule result)
    {
        base.CreateChildren(result);

        result.StartTime ??= StartTimeFactory?.Build();
    }

} // End Of Class

public static class InnerCisScanConfigurationWeeklyScheduleFactoryExtensions
{
    public static CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime(this InnerCisScanConfigurationWeeklyScheduleFactory parentFactory, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null)
    {
        parentFactory.StartTimeFactory = new InnerCisScanConfigurationTimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StartTimeFactory);
    }

    public static CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1, InnerCisScanConfigurationTimeFactory> WithStartTime<T1>(this CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1>(this CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1, T2, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory, T2, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationWeeklyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<T1, T2, InnerCisScanConfigurationWeeklyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1, T2, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory, T2, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationWeeklyScheduleFactory, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerCisScanConfigurationWeeklyScheduleFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCisScanConfigurationWeeklyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCisScanConfigurationWeeklyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1, T2, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<InnerCisScanConfigurationWeeklyScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory, T2, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerCisScanConfigurationWeeklyScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationWeeklyScheduleFactory, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCisScanConfigurationWeeklyScheduleFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCisScanConfigurationWeeklyScheduleFactory, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCisScanConfigurationWeeklyScheduleFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCisScanConfigurationWeeklyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCisScanConfigurationWeeklyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T5, subFactoryAction));
}

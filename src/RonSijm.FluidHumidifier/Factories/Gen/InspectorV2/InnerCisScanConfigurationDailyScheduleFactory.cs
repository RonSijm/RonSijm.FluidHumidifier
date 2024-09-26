// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCisScanConfigurationDailyScheduleFactory(Action<Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule>
{

    internal InnerCisScanConfigurationTimeFactory StartTimeFactory { get; set; }

    protected override Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule Create()
    {
        var dailyScheduleResult = CreateDailySchedule();
        factoryAction?.Invoke(dailyScheduleResult);

        return dailyScheduleResult;
    }

    private Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule CreateDailySchedule()
    {
        var dailyScheduleResult = new Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule();

        return dailyScheduleResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule result)
    {
        base.CreateChildren(result);

        result.StartTime ??= StartTimeFactory?.Build();
    }

} // End Of Class

public static class InnerCisScanConfigurationDailyScheduleFactoryExtensions
{
    public static CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime(this InnerCisScanConfigurationDailyScheduleFactory parentFactory, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null)
    {
        parentFactory.StartTimeFactory = new InnerCisScanConfigurationTimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StartTimeFactory);
    }

    public static CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1, InnerCisScanConfigurationTimeFactory> WithStartTime<T1>(this CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1>(this CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1, T2, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory, T2, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationDailyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<T1, T2, InnerCisScanConfigurationDailyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1, T2, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory, T2, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationDailyScheduleFactory, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerCisScanConfigurationDailyScheduleFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCisScanConfigurationDailyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCisScanConfigurationDailyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1, T2, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<InnerCisScanConfigurationDailyScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory, T2, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerCisScanConfigurationDailyScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationDailyScheduleFactory, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCisScanConfigurationDailyScheduleFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCisScanConfigurationDailyScheduleFactory, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCisScanConfigurationDailyScheduleFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCisScanConfigurationDailyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCisScanConfigurationDailyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T5, subFactoryAction));
}

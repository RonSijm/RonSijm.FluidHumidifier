// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class InnerCisScanConfigurationMonthlyScheduleFactory(Action<Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule> factoryAction = null) : SubResourceFactory<Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule>
{

    internal InnerCisScanConfigurationTimeFactory StartTimeFactory { get; set; }

    protected override Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule Create()
    {
        var monthlyScheduleResult = CreateMonthlySchedule();
        factoryAction?.Invoke(monthlyScheduleResult);

        return monthlyScheduleResult;
    }

    private Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule CreateMonthlySchedule()
    {
        var monthlyScheduleResult = new Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule();

        return monthlyScheduleResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule result)
    {
        base.CreateChildren(result);

        result.StartTime ??= StartTimeFactory?.Build();
    }

} // End Of Class

public static class InnerCisScanConfigurationMonthlyScheduleFactoryExtensions
{
    public static CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime(this InnerCisScanConfigurationMonthlyScheduleFactory parentFactory, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null)
    {
        parentFactory.StartTimeFactory = new InnerCisScanConfigurationTimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StartTimeFactory);
    }

    public static CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1, InnerCisScanConfigurationTimeFactory> WithStartTime<T1>(this CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1>(this CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1, T2, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory, T2, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory, T2> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationMonthlyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2>(this CombinedResult<T1, T2, InnerCisScanConfigurationMonthlyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1, T2, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory, T2, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationMonthlyScheduleFactory, T3, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerCisScanConfigurationMonthlyScheduleFactory, T3> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCisScanConfigurationMonthlyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCisScanConfigurationMonthlyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1, T2, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<InnerCisScanConfigurationMonthlyScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory, T2, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerCisScanConfigurationMonthlyScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCisScanConfigurationMonthlyScheduleFactory, T3, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCisScanConfigurationMonthlyScheduleFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCisScanConfigurationMonthlyScheduleFactory, T4, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCisScanConfigurationMonthlyScheduleFactory, T4> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCisScanConfigurationMonthlyScheduleFactory, InnerCisScanConfigurationTimeFactory> WithStartTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCisScanConfigurationMonthlyScheduleFactory> combinedResult, Action<Humidifier.InspectorV2.CisScanConfigurationTypes.Time> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStartTime(combinedResult.T5, subFactoryAction));
}

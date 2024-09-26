// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerRefreshScheduleScheduleFrequencyFactory(Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency>
{

    internal InnerRefreshScheduleRefreshOnDayFactory RefreshOnDayFactory { get; set; }

    protected override Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency Create()
    {
        var scheduleFrequencyResult = CreateScheduleFrequency();
        factoryAction?.Invoke(scheduleFrequencyResult);

        return scheduleFrequencyResult;
    }

    private Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency CreateScheduleFrequency()
    {
        var scheduleFrequencyResult = new Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency();

        return scheduleFrequencyResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency result)
    {
        base.CreateChildren(result);

        result.RefreshOnDay ??= RefreshOnDayFactory?.Build();
    }

} // End Of Class

public static class InnerRefreshScheduleScheduleFrequencyFactoryExtensions
{
    public static CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay(this InnerRefreshScheduleScheduleFrequencyFactory parentFactory, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null)
    {
        parentFactory.RefreshOnDayFactory = new InnerRefreshScheduleRefreshOnDayFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RefreshOnDayFactory);
    }

    public static CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1>(this CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1>(this CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1, T2, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2>(this CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory, T2, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2>(this CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory, T2> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRefreshScheduleScheduleFrequencyFactory, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2>(this CombinedResult<T1, T2, InnerRefreshScheduleScheduleFrequencyFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1, T2, T3, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3>(this CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory, T2, T3, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3>(this CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRefreshScheduleScheduleFrequencyFactory, T3, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3>(this CombinedResult<T1, T2, InnerRefreshScheduleScheduleFrequencyFactory, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRefreshScheduleScheduleFrequencyFactory, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRefreshScheduleScheduleFrequencyFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1, T2, T3, T4, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3, T4>(this CombinedResult<InnerRefreshScheduleScheduleFrequencyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory, T2, T3, T4, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3, T4>(this CombinedResult<T1, InnerRefreshScheduleScheduleFrequencyFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRefreshScheduleScheduleFrequencyFactory, T3, T4, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRefreshScheduleScheduleFrequencyFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRefreshScheduleScheduleFrequencyFactory, T4, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRefreshScheduleScheduleFrequencyFactory, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRefreshScheduleScheduleFrequencyFactory, InnerRefreshScheduleRefreshOnDayFactory> WithRefreshOnDay<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRefreshScheduleScheduleFrequencyFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRefreshOnDay(combinedResult.T5, subFactoryAction));
}

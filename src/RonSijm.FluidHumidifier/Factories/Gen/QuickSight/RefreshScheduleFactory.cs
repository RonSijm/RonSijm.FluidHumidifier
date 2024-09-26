// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class RefreshScheduleFactory(string resourceName = null, Action<Humidifier.QuickSight.RefreshSchedule> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.RefreshSchedule>(resourceName)
{

    internal InnerRefreshScheduleRefreshScheduleMapFactory ScheduleFactory { get; set; }

    protected override Humidifier.QuickSight.RefreshSchedule Create()
    {
        var refreshScheduleResult = CreateRefreshSchedule();
        factoryAction?.Invoke(refreshScheduleResult);

        return refreshScheduleResult;
    }

    private Humidifier.QuickSight.RefreshSchedule CreateRefreshSchedule()
    {
        var refreshScheduleResult = new Humidifier.QuickSight.RefreshSchedule
        {
            GivenName = InputResourceName,
        };

        return refreshScheduleResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.RefreshSchedule result)
    {
        base.CreateChildren(result);

        result.Schedule ??= ScheduleFactory?.Build();
    }

} // End Of Class

public static class RefreshScheduleFactoryExtensions
{
    public static CombinedResult<RefreshScheduleFactory, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule(this RefreshScheduleFactory parentFactory, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerRefreshScheduleRefreshScheduleMapFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<RefreshScheduleFactory, T1, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1>(this CombinedResult<RefreshScheduleFactory, T1> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RefreshScheduleFactory, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1>(this CombinedResult<T1, RefreshScheduleFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RefreshScheduleFactory, T1, T2, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2>(this CombinedResult<RefreshScheduleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RefreshScheduleFactory, T2, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2>(this CombinedResult<T1, RefreshScheduleFactory, T2> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RefreshScheduleFactory, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, RefreshScheduleFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RefreshScheduleFactory, T1, T2, T3, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3>(this CombinedResult<RefreshScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RefreshScheduleFactory, T2, T3, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, RefreshScheduleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RefreshScheduleFactory, T3, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, RefreshScheduleFactory, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RefreshScheduleFactory, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, RefreshScheduleFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RefreshScheduleFactory, T1, T2, T3, T4, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<RefreshScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RefreshScheduleFactory, T2, T3, T4, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, RefreshScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RefreshScheduleFactory, T3, T4, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, RefreshScheduleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RefreshScheduleFactory, T4, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RefreshScheduleFactory, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RefreshScheduleFactory, InnerRefreshScheduleRefreshScheduleMapFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RefreshScheduleFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerRefreshScheduleRefreshScheduleMapFactory(Action<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap>
{

    internal InnerRefreshScheduleScheduleFrequencyFactory ScheduleFrequencyFactory { get; set; }

    protected override Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap Create()
    {
        var refreshScheduleMapResult = CreateRefreshScheduleMap();
        factoryAction?.Invoke(refreshScheduleMapResult);

        return refreshScheduleMapResult;
    }

    private Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap CreateRefreshScheduleMap()
    {
        var refreshScheduleMapResult = new Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap();

        return refreshScheduleMapResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap result)
    {
        base.CreateChildren(result);

        result.ScheduleFrequency ??= ScheduleFrequencyFactory?.Build();
    }

} // End Of Class

public static class InnerRefreshScheduleRefreshScheduleMapFactoryExtensions
{
    public static CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency(this InnerRefreshScheduleRefreshScheduleMapFactory parentFactory, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null)
    {
        parentFactory.ScheduleFrequencyFactory = new InnerRefreshScheduleScheduleFrequencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFrequencyFactory);
    }

    public static CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1>(this CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1>(this CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1, T2, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2>(this CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory, T2, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2>(this CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory, T2> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRefreshScheduleRefreshScheduleMapFactory, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2>(this CombinedResult<T1, T2, InnerRefreshScheduleRefreshScheduleMapFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1, T2, T3, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory, T2, T3, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRefreshScheduleRefreshScheduleMapFactory, T3, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<T1, T2, InnerRefreshScheduleRefreshScheduleMapFactory, T3> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRefreshScheduleRefreshScheduleMapFactory, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRefreshScheduleRefreshScheduleMapFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1, T2, T3, T4, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<InnerRefreshScheduleRefreshScheduleMapFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory, T2, T3, T4, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, InnerRefreshScheduleRefreshScheduleMapFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRefreshScheduleRefreshScheduleMapFactory, T3, T4, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRefreshScheduleRefreshScheduleMapFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRefreshScheduleRefreshScheduleMapFactory, T4, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRefreshScheduleRefreshScheduleMapFactory, T4> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRefreshScheduleRefreshScheduleMapFactory, InnerRefreshScheduleScheduleFrequencyFactory> WithScheduleFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRefreshScheduleRefreshScheduleMapFactory> combinedResult, Action<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleFrequency(combinedResult.T5, subFactoryAction));
}

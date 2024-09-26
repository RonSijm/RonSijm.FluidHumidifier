// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetIncrementalRefreshFactory(Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh>
{

    internal InnerDataSetLookbackWindowFactory LookbackWindowFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.IncrementalRefresh Create()
    {
        var incrementalRefreshResult = CreateIncrementalRefresh();
        factoryAction?.Invoke(incrementalRefreshResult);

        return incrementalRefreshResult;
    }

    private Humidifier.QuickSight.DataSetTypes.IncrementalRefresh CreateIncrementalRefresh()
    {
        var incrementalRefreshResult = new Humidifier.QuickSight.DataSetTypes.IncrementalRefresh();

        return incrementalRefreshResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.IncrementalRefresh result)
    {
        base.CreateChildren(result);

        result.LookbackWindow ??= LookbackWindowFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetIncrementalRefreshFactoryExtensions
{
    public static CombinedResult<InnerDataSetIncrementalRefreshFactory, InnerDataSetLookbackWindowFactory> WithLookbackWindow(this InnerDataSetIncrementalRefreshFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null)
    {
        parentFactory.LookbackWindowFactory = new InnerDataSetLookbackWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LookbackWindowFactory);
    }

    public static CombinedResult<InnerDataSetIncrementalRefreshFactory, T1, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1>(this CombinedResult<InnerDataSetIncrementalRefreshFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithLookbackWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIncrementalRefreshFactory, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1>(this CombinedResult<T1, InnerDataSetIncrementalRefreshFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithLookbackWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetIncrementalRefreshFactory, T1, T2, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2>(this CombinedResult<InnerDataSetIncrementalRefreshFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIncrementalRefreshFactory, T2, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2>(this CombinedResult<T1, InnerDataSetIncrementalRefreshFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetIncrementalRefreshFactory, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2>(this CombinedResult<T1, T2, InnerDataSetIncrementalRefreshFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetIncrementalRefreshFactory, T1, T2, T3, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3>(this CombinedResult<InnerDataSetIncrementalRefreshFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIncrementalRefreshFactory, T2, T3, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3>(this CombinedResult<T1, InnerDataSetIncrementalRefreshFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetIncrementalRefreshFactory, T3, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetIncrementalRefreshFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetIncrementalRefreshFactory, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetIncrementalRefreshFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetIncrementalRefreshFactory, T1, T2, T3, T4, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3, T4>(this CombinedResult<InnerDataSetIncrementalRefreshFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetIncrementalRefreshFactory, T2, T3, T4, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetIncrementalRefreshFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetIncrementalRefreshFactory, T3, T4, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetIncrementalRefreshFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetIncrementalRefreshFactory, T4, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetIncrementalRefreshFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetIncrementalRefreshFactory, InnerDataSetLookbackWindowFactory> WithLookbackWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetIncrementalRefreshFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.LookbackWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLookbackWindow(combinedResult.T5, subFactoryAction));
}

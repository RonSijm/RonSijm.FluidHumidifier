// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetRefreshConfigurationFactory(Action<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.RefreshConfiguration>
{

    internal InnerDataSetIncrementalRefreshFactory IncrementalRefreshFactory { get; set; }

    protected override Humidifier.QuickSight.DataSetTypes.RefreshConfiguration Create()
    {
        var refreshConfigurationResult = CreateRefreshConfiguration();
        factoryAction?.Invoke(refreshConfigurationResult);

        return refreshConfigurationResult;
    }

    private Humidifier.QuickSight.DataSetTypes.RefreshConfiguration CreateRefreshConfiguration()
    {
        var refreshConfigurationResult = new Humidifier.QuickSight.DataSetTypes.RefreshConfiguration();

        return refreshConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSetTypes.RefreshConfiguration result)
    {
        base.CreateChildren(result);

        result.IncrementalRefresh ??= IncrementalRefreshFactory?.Build();
    }

} // End Of Class

public static class InnerDataSetRefreshConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSetRefreshConfigurationFactory, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh(this InnerDataSetRefreshConfigurationFactory parentFactory, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null)
    {
        parentFactory.IncrementalRefreshFactory = new InnerDataSetIncrementalRefreshFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IncrementalRefreshFactory);
    }

    public static CombinedResult<InnerDataSetRefreshConfigurationFactory, T1, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1>(this CombinedResult<InnerDataSetRefreshConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetRefreshConfigurationFactory, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1>(this CombinedResult<T1, InnerDataSetRefreshConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSetRefreshConfigurationFactory, T1, T2, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2>(this CombinedResult<InnerDataSetRefreshConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetRefreshConfigurationFactory, T2, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2>(this CombinedResult<T1, InnerDataSetRefreshConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetRefreshConfigurationFactory, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2>(this CombinedResult<T1, T2, InnerDataSetRefreshConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSetRefreshConfigurationFactory, T1, T2, T3, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3>(this CombinedResult<InnerDataSetRefreshConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetRefreshConfigurationFactory, T2, T3, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3>(this CombinedResult<T1, InnerDataSetRefreshConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetRefreshConfigurationFactory, T3, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSetRefreshConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetRefreshConfigurationFactory, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSetRefreshConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSetRefreshConfigurationFactory, T1, T2, T3, T4, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3, T4>(this CombinedResult<InnerDataSetRefreshConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSetRefreshConfigurationFactory, T2, T3, T4, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSetRefreshConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSetRefreshConfigurationFactory, T3, T4, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSetRefreshConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSetRefreshConfigurationFactory, T4, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSetRefreshConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSetRefreshConfigurationFactory, InnerDataSetIncrementalRefreshFactory> WithIncrementalRefresh<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSetRefreshConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DataSetTypes.IncrementalRefresh> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIncrementalRefresh(combinedResult.T5, subFactoryAction));
}

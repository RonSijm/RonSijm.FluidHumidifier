// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardGridLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions>
{

    internal InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory ScreenCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions Create()
    {
        var gridLayoutCanvasSizeOptionsResult = CreateGridLayoutCanvasSizeOptions();
        factoryAction?.Invoke(gridLayoutCanvasSizeOptionsResult);

        return gridLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions CreateGridLayoutCanvasSizeOptions()
    {
        var gridLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions();

        return gridLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.ScreenCanvasSizeOptions ??= ScreenCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardGridLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions(this InnerDashboardGridLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.ScreenCanvasSizeOptionsFactory = new InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScreenCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1, T2, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T2, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T2, T3, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T3, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardGridLayoutCanvasSizeOptionsFactory, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerDashboardGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T3, T4, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T4, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardGridLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardGridLayoutCanvasSizeOptionsFactory, InnerDashboardGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

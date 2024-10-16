// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDefaultGridLayoutConfigurationFactory(Action<Humidifier.QuickSight.DashboardTypes.DefaultGridLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DefaultGridLayoutConfiguration>
{

    internal InnerDashboardGridLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.DefaultGridLayoutConfiguration Create()
    {
        var defaultGridLayoutConfigurationResult = CreateDefaultGridLayoutConfiguration();
        factoryAction?.Invoke(defaultGridLayoutConfigurationResult);

        return defaultGridLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DefaultGridLayoutConfiguration CreateDefaultGridLayoutConfiguration()
    {
        var defaultGridLayoutConfigurationResult = new Humidifier.QuickSight.DashboardTypes.DefaultGridLayoutConfiguration();

        return defaultGridLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.DefaultGridLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardDefaultGridLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerDashboardDefaultGridLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerDashboardGridLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory, T2, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultGridLayoutConfigurationFactory, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1, T2, T3, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory, T2, T3, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultGridLayoutConfigurationFactory, T3, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDefaultGridLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultGridLayoutConfigurationFactory, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1, T2, T3, T4, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDefaultGridLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory, T2, T3, T4, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDefaultGridLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultGridLayoutConfigurationFactory, T3, T4, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDefaultGridLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultGridLayoutConfigurationFactory, T4, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultGridLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultGridLayoutConfigurationFactory, InnerDashboardGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

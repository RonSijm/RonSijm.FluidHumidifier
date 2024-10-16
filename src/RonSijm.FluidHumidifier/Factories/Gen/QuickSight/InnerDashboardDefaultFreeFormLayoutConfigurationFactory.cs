// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDefaultFreeFormLayoutConfigurationFactory(Action<Humidifier.QuickSight.DashboardTypes.DefaultFreeFormLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DefaultFreeFormLayoutConfiguration>
{

    internal InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.DefaultFreeFormLayoutConfiguration Create()
    {
        var defaultFreeFormLayoutConfigurationResult = CreateDefaultFreeFormLayoutConfiguration();
        factoryAction?.Invoke(defaultFreeFormLayoutConfigurationResult);

        return defaultFreeFormLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DefaultFreeFormLayoutConfiguration CreateDefaultFreeFormLayoutConfiguration()
    {
        var defaultFreeFormLayoutConfigurationResult = new Humidifier.QuickSight.DashboardTypes.DefaultFreeFormLayoutConfiguration();

        return defaultFreeFormLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.DefaultFreeFormLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardDefaultFreeFormLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerDashboardDefaultFreeFormLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T2, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T2, T3, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T3, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, T4, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T2, T3, T4, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T3, T4, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T4, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultFreeFormLayoutConfigurationFactory, InnerDashboardFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

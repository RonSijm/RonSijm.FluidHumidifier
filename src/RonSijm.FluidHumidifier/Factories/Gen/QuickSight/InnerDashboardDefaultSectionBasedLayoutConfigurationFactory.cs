// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardDefaultSectionBasedLayoutConfigurationFactory(Action<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration>
{

    internal InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration Create()
    {
        var defaultSectionBasedLayoutConfigurationResult = CreateDefaultSectionBasedLayoutConfiguration();
        factoryAction?.Invoke(defaultSectionBasedLayoutConfigurationResult);

        return defaultSectionBasedLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration CreateDefaultSectionBasedLayoutConfiguration()
    {
        var defaultSectionBasedLayoutConfigurationResult = new Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration();

        return defaultSectionBasedLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DashboardTypes.DefaultSectionBasedLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerDashboardDefaultSectionBasedLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerDashboardDefaultSectionBasedLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T2, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T2, T3, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T3, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, T4, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T2, T3, T4, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T3, T4, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T4, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory, InnerDashboardSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDashboardDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.DashboardTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

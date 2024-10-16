// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisDefaultGridLayoutConfigurationFactory(Action<Humidifier.QuickSight.AnalysisTypes.DefaultGridLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.DefaultGridLayoutConfiguration>
{

    internal InnerAnalysisGridLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.DefaultGridLayoutConfiguration Create()
    {
        var defaultGridLayoutConfigurationResult = CreateDefaultGridLayoutConfiguration();
        factoryAction?.Invoke(defaultGridLayoutConfigurationResult);

        return defaultGridLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.DefaultGridLayoutConfiguration CreateDefaultGridLayoutConfiguration()
    {
        var defaultGridLayoutConfigurationResult = new Humidifier.QuickSight.AnalysisTypes.DefaultGridLayoutConfiguration();

        return defaultGridLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.DefaultGridLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisDefaultGridLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerAnalysisDefaultGridLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerAnalysisGridLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultGridLayoutConfigurationFactory, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1, T2, T3, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory, T2, T3, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultGridLayoutConfigurationFactory, T3, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisDefaultGridLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultGridLayoutConfigurationFactory, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1, T2, T3, T4, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisDefaultGridLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory, T2, T3, T4, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisDefaultGridLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultGridLayoutConfigurationFactory, T3, T4, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisDefaultGridLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultGridLayoutConfigurationFactory, T4, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultGridLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultGridLayoutConfigurationFactory, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultGridLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

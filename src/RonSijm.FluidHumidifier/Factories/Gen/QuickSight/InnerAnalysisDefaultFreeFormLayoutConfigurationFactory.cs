// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisDefaultFreeFormLayoutConfigurationFactory(Action<Humidifier.QuickSight.AnalysisTypes.DefaultFreeFormLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.DefaultFreeFormLayoutConfiguration>
{

    internal InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.DefaultFreeFormLayoutConfiguration Create()
    {
        var defaultFreeFormLayoutConfigurationResult = CreateDefaultFreeFormLayoutConfiguration();
        factoryAction?.Invoke(defaultFreeFormLayoutConfigurationResult);

        return defaultFreeFormLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.DefaultFreeFormLayoutConfiguration CreateDefaultFreeFormLayoutConfiguration()
    {
        var defaultFreeFormLayoutConfigurationResult = new Humidifier.QuickSight.AnalysisTypes.DefaultFreeFormLayoutConfiguration();

        return defaultFreeFormLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.DefaultFreeFormLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisDefaultFreeFormLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerAnalysisDefaultFreeFormLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T2, T3, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T3, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, T4, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T2, T3, T4, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T3, T4, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T4, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

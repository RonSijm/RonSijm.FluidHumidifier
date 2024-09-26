// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory(Action<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration>
{

    internal InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration Create()
    {
        var defaultSectionBasedLayoutConfigurationResult = CreateDefaultSectionBasedLayoutConfiguration();
        factoryAction?.Invoke(defaultSectionBasedLayoutConfigurationResult);

        return defaultSectionBasedLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration CreateDefaultSectionBasedLayoutConfiguration()
    {
        var defaultSectionBasedLayoutConfigurationResult = new Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration();

        return defaultSectionBasedLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.DefaultSectionBasedLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisDefaultSectionBasedLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T2, T3, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T3, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, T4, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T2, T3, T4, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T3, T4, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T4, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

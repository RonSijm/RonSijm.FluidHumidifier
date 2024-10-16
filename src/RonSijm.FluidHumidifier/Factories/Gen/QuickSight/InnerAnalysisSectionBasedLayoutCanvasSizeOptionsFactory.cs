// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions>
{

    internal InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory PaperCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions Create()
    {
        var sectionBasedLayoutCanvasSizeOptionsResult = CreateSectionBasedLayoutCanvasSizeOptions();
        factoryAction?.Invoke(sectionBasedLayoutCanvasSizeOptionsResult);

        return sectionBasedLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions CreateSectionBasedLayoutCanvasSizeOptions()
    {
        var sectionBasedLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions();

        return sectionBasedLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.PaperCanvasSizeOptions ??= PaperCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions(this InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.PaperCanvasSizeOptionsFactory = new InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaperCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1>(this CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T3, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T3, T4, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T4, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

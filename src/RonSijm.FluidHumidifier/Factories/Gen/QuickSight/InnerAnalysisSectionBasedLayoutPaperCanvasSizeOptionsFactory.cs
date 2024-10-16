// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions>
{

    internal InnerAnalysisSpacingFactory PaperMarginFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions Create()
    {
        var sectionBasedLayoutPaperCanvasSizeOptionsResult = CreateSectionBasedLayoutPaperCanvasSizeOptions();
        factoryAction?.Invoke(sectionBasedLayoutPaperCanvasSizeOptionsResult);

        return sectionBasedLayoutPaperCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions CreateSectionBasedLayoutPaperCanvasSizeOptions()
    {
        var sectionBasedLayoutPaperCanvasSizeOptionsResult = new Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions();

        return sectionBasedLayoutPaperCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.SectionBasedLayoutPaperCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.PaperMargin ??= PaperMarginFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerAnalysisSpacingFactory> WithPaperMargin(this InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null)
    {
        parentFactory.PaperMarginFactory = new InnerAnalysisSpacingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaperMarginFactory);
    }

    public static CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, InnerAnalysisSpacingFactory> WithPaperMargin<T1>(this CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerAnalysisSpacingFactory> WithPaperMargin<T1>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, T4, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, T4, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T4, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerAnalysisSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions>
{

    internal InnerTemplateSpacingFactory PaperMarginFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions Create()
    {
        var sectionBasedLayoutPaperCanvasSizeOptionsResult = CreateSectionBasedLayoutPaperCanvasSizeOptions();
        factoryAction?.Invoke(sectionBasedLayoutPaperCanvasSizeOptionsResult);

        return sectionBasedLayoutPaperCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions CreateSectionBasedLayoutPaperCanvasSizeOptions()
    {
        var sectionBasedLayoutPaperCanvasSizeOptionsResult = new Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions();

        return sectionBasedLayoutPaperCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.PaperMargin ??= PaperMarginFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerTemplateSpacingFactory> WithPaperMargin(this InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null)
    {
        parentFactory.PaperMarginFactory = new InnerTemplateSpacingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaperMarginFactory);
    }

    public static CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, InnerTemplateSpacingFactory> WithPaperMargin<T1>(this CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerTemplateSpacingFactory> WithPaperMargin<T1>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2>(this CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, T4, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, T4, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T4, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory, InnerTemplateSpacingFactory> WithPaperMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.Spacing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperMargin(combinedResult.T5, subFactoryAction));
}

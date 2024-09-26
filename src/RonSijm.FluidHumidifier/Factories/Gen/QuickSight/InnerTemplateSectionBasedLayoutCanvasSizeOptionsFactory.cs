// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions>
{

    internal InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory PaperCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions Create()
    {
        var sectionBasedLayoutCanvasSizeOptionsResult = CreateSectionBasedLayoutCanvasSizeOptions();
        factoryAction?.Invoke(sectionBasedLayoutCanvasSizeOptionsResult);

        return sectionBasedLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions CreateSectionBasedLayoutCanvasSizeOptions()
    {
        var sectionBasedLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions();

        return sectionBasedLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.PaperCanvasSizeOptions ??= PaperCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions(this InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.PaperCanvasSizeOptionsFactory = new InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaperCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1>(this CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T2, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T3, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T3, T4, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T4, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory, InnerTemplateSectionBasedLayoutPaperCanvasSizeOptionsFactory> WithPaperCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutPaperCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaperCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

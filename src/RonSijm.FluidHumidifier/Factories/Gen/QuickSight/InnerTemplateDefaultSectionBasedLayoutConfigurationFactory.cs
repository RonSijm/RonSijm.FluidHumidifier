// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateDefaultSectionBasedLayoutConfigurationFactory(Action<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration>
{

    internal InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration Create()
    {
        var defaultSectionBasedLayoutConfigurationResult = CreateDefaultSectionBasedLayoutConfiguration();
        factoryAction?.Invoke(defaultSectionBasedLayoutConfigurationResult);

        return defaultSectionBasedLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration CreateDefaultSectionBasedLayoutConfiguration()
    {
        var defaultSectionBasedLayoutConfigurationResult = new Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration();

        return defaultSectionBasedLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.DefaultSectionBasedLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateDefaultSectionBasedLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerTemplateDefaultSectionBasedLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T2, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T2, T3, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T3, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, T4, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T2, T3, T4, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T3, T4, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T4, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory, InnerTemplateSectionBasedLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultSectionBasedLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.SectionBasedLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

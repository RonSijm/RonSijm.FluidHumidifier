// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateDefaultFreeFormLayoutConfigurationFactory(Action<Humidifier.QuickSight.TemplateTypes.DefaultFreeFormLayoutConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.DefaultFreeFormLayoutConfiguration>
{

    internal InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory CanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.DefaultFreeFormLayoutConfiguration Create()
    {
        var defaultFreeFormLayoutConfigurationResult = CreateDefaultFreeFormLayoutConfiguration();
        factoryAction?.Invoke(defaultFreeFormLayoutConfigurationResult);

        return defaultFreeFormLayoutConfigurationResult;
    }

    private Humidifier.QuickSight.TemplateTypes.DefaultFreeFormLayoutConfiguration CreateDefaultFreeFormLayoutConfiguration()
    {
        var defaultFreeFormLayoutConfigurationResult = new Humidifier.QuickSight.TemplateTypes.DefaultFreeFormLayoutConfiguration();

        return defaultFreeFormLayoutConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.DefaultFreeFormLayoutConfiguration result)
    {
        base.CreateChildren(result);

        result.CanvasSizeOptions ??= CanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateDefaultFreeFormLayoutConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions(this InnerTemplateDefaultFreeFormLayoutConfigurationFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.CanvasSizeOptionsFactory = new InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1>(this CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerTemplateDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T2, T3, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T3, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, T4, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T2, T3, T4, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T3, T4, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T4, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultFreeFormLayoutConfigurationFactory, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> WithCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateDefaultFreeFormLayoutConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

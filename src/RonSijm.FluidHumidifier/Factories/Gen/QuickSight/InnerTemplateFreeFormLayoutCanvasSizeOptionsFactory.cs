// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions>
{

    internal InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory ScreenCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions Create()
    {
        var freeFormLayoutCanvasSizeOptionsResult = CreateFreeFormLayoutCanvasSizeOptions();
        factoryAction?.Invoke(freeFormLayoutCanvasSizeOptionsResult);

        return freeFormLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions CreateFreeFormLayoutCanvasSizeOptions()
    {
        var freeFormLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions();

        return freeFormLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.FreeFormLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.ScreenCanvasSizeOptions ??= ScreenCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateFreeFormLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions(this InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.ScreenCanvasSizeOptionsFactory = new InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScreenCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T2, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T3, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T3, T4, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T4, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory, InnerTemplateFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

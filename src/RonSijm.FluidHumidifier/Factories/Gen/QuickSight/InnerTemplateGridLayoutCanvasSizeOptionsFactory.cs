// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateGridLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions>
{

    internal InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory ScreenCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions Create()
    {
        var gridLayoutCanvasSizeOptionsResult = CreateGridLayoutCanvasSizeOptions();
        factoryAction?.Invoke(gridLayoutCanvasSizeOptionsResult);

        return gridLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions CreateGridLayoutCanvasSizeOptions()
    {
        var gridLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions();

        return gridLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.TemplateTypes.GridLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.ScreenCanvasSizeOptions ??= ScreenCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateGridLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions(this InnerTemplateGridLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.ScreenCanvasSizeOptionsFactory = new InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScreenCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1, T2, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T2, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T2, T3, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T3, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateGridLayoutCanvasSizeOptionsFactory, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerTemplateGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T3, T4, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T4, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateGridLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateGridLayoutCanvasSizeOptionsFactory, InnerTemplateGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.TemplateTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

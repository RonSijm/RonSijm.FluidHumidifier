// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisGridLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions>
{

    internal InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory ScreenCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions Create()
    {
        var gridLayoutCanvasSizeOptionsResult = CreateGridLayoutCanvasSizeOptions();
        factoryAction?.Invoke(gridLayoutCanvasSizeOptionsResult);

        return gridLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions CreateGridLayoutCanvasSizeOptions()
    {
        var gridLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions();

        return gridLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.GridLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.ScreenCanvasSizeOptions ??= ScreenCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisGridLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions(this InnerAnalysisGridLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.ScreenCanvasSizeOptionsFactory = new InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScreenCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1, T2, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T2, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T2, T3, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T3, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T3, T4, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T4, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisGridLayoutCanvasSizeOptionsFactory, InnerAnalysisGridLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisGridLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.GridLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

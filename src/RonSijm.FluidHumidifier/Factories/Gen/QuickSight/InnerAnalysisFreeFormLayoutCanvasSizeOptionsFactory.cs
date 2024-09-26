// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions>
{

    internal InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory ScreenCanvasSizeOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions Create()
    {
        var freeFormLayoutCanvasSizeOptionsResult = CreateFreeFormLayoutCanvasSizeOptions();
        factoryAction?.Invoke(freeFormLayoutCanvasSizeOptionsResult);

        return freeFormLayoutCanvasSizeOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions CreateFreeFormLayoutCanvasSizeOptions()
    {
        var freeFormLayoutCanvasSizeOptionsResult = new Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions();

        return freeFormLayoutCanvasSizeOptionsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutCanvasSizeOptions result)
    {
        base.CreateChildren(result);

        result.ScreenCanvasSizeOptions ??= ScreenCanvasSizeOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactoryExtensions
{
    public static CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions(this InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory parentFactory, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null)
    {
        parentFactory.ScreenCanvasSizeOptionsFactory = new InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScreenCanvasSizeOptionsFactory);
    }

    public static CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1>(this CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T2, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T2> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2>(this CombinedResult<T1, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T3, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T3> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, T4, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T3, T4, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T4, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, T4> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory, InnerAnalysisFreeFormLayoutScreenCanvasSizeOptionsFactory> WithScreenCanvasSizeOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalysisFreeFormLayoutCanvasSizeOptionsFactory> combinedResult, Action<Humidifier.QuickSight.AnalysisTypes.FreeFormLayoutScreenCanvasSizeOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScreenCanvasSizeOptions(combinedResult.T5, subFactoryAction));
}

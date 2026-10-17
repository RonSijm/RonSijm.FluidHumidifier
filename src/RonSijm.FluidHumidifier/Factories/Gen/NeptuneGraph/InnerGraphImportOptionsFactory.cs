// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class InnerGraphImportOptionsFactory(Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> factoryAction = null) : SubResourceFactory<Humidifier.NeptuneGraph.GraphTypes.ImportOptions>
{

    internal InnerGraphNeptuneImportOptionsFactory NeptuneFactory { get; set; }

    protected override Humidifier.NeptuneGraph.GraphTypes.ImportOptions Create()
    {
        var importOptionsResult = CreateImportOptions();
        factoryAction?.Invoke(importOptionsResult);

        return importOptionsResult;
    }

    private Humidifier.NeptuneGraph.GraphTypes.ImportOptions CreateImportOptions()
    {
        var importOptionsResult = new Humidifier.NeptuneGraph.GraphTypes.ImportOptions();

        return importOptionsResult;
    }
    public override void CreateChildren(Humidifier.NeptuneGraph.GraphTypes.ImportOptions result)
    {
        base.CreateChildren(result);

        result.Neptune ??= NeptuneFactory?.Build();
    }

} // End Of Class

public static class InnerGraphImportOptionsFactoryExtensions
{
    public static CombinedResult<InnerGraphImportOptionsFactory, InnerGraphNeptuneImportOptionsFactory> WithNeptune(this InnerGraphImportOptionsFactory parentFactory, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null)
    {
        parentFactory.NeptuneFactory = new InnerGraphNeptuneImportOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NeptuneFactory);
    }

    public static CombinedResult<InnerGraphImportOptionsFactory, T1, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1>(this CombinedResult<InnerGraphImportOptionsFactory, T1> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithNeptune(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportOptionsFactory, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1>(this CombinedResult<T1, InnerGraphImportOptionsFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithNeptune(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGraphImportOptionsFactory, T1, T2, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2>(this CombinedResult<InnerGraphImportOptionsFactory, T1, T2> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportOptionsFactory, T2, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2>(this CombinedResult<T1, InnerGraphImportOptionsFactory, T2> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGraphImportOptionsFactory, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2>(this CombinedResult<T1, T2, InnerGraphImportOptionsFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGraphImportOptionsFactory, T1, T2, T3, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3>(this CombinedResult<InnerGraphImportOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportOptionsFactory, T2, T3, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3>(this CombinedResult<T1, InnerGraphImportOptionsFactory, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGraphImportOptionsFactory, T3, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3>(this CombinedResult<T1, T2, InnerGraphImportOptionsFactory, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGraphImportOptionsFactory, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGraphImportOptionsFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGraphImportOptionsFactory, T1, T2, T3, T4, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3, T4>(this CombinedResult<InnerGraphImportOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportOptionsFactory, T2, T3, T4, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3, T4>(this CombinedResult<T1, InnerGraphImportOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGraphImportOptionsFactory, T3, T4, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGraphImportOptionsFactory, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGraphImportOptionsFactory, T4, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGraphImportOptionsFactory, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGraphImportOptionsFactory, InnerGraphNeptuneImportOptionsFactory> WithNeptune<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGraphImportOptionsFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNeptune(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class InnerGraphImportTaskFactory(Action<Humidifier.NeptuneGraph.GraphTypes.ImportTask> factoryAction = null) : SubResourceFactory<Humidifier.NeptuneGraph.GraphTypes.ImportTask>
{

    internal InnerGraphImportOptionsFactory ImportOptionsFactory { get; set; }

    protected override Humidifier.NeptuneGraph.GraphTypes.ImportTask Create()
    {
        var importTaskResult = CreateImportTask();
        factoryAction?.Invoke(importTaskResult);

        return importTaskResult;
    }

    private Humidifier.NeptuneGraph.GraphTypes.ImportTask CreateImportTask()
    {
        var importTaskResult = new Humidifier.NeptuneGraph.GraphTypes.ImportTask();

        return importTaskResult;
    }
    public override void CreateChildren(Humidifier.NeptuneGraph.GraphTypes.ImportTask result)
    {
        base.CreateChildren(result);

        result.ImportOptions ??= ImportOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerGraphImportTaskFactoryExtensions
{
    public static CombinedResult<InnerGraphImportTaskFactory, InnerGraphImportOptionsFactory> WithImportOptions(this InnerGraphImportTaskFactory parentFactory, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null)
    {
        parentFactory.ImportOptionsFactory = new InnerGraphImportOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImportOptionsFactory);
    }

    public static CombinedResult<InnerGraphImportTaskFactory, T1, InnerGraphImportOptionsFactory> WithImportOptions<T1>(this CombinedResult<InnerGraphImportTaskFactory, T1> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithImportOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportTaskFactory, InnerGraphImportOptionsFactory> WithImportOptions<T1>(this CombinedResult<T1, InnerGraphImportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithImportOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGraphImportTaskFactory, T1, T2, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2>(this CombinedResult<InnerGraphImportTaskFactory, T1, T2> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportTaskFactory, T2, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2>(this CombinedResult<T1, InnerGraphImportTaskFactory, T2> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGraphImportTaskFactory, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2>(this CombinedResult<T1, T2, InnerGraphImportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGraphImportTaskFactory, T1, T2, T3, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3>(this CombinedResult<InnerGraphImportTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportTaskFactory, T2, T3, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3>(this CombinedResult<T1, InnerGraphImportTaskFactory, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGraphImportTaskFactory, T3, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerGraphImportTaskFactory, T3> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGraphImportTaskFactory, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGraphImportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGraphImportTaskFactory, T1, T2, T3, T4, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3, T4>(this CombinedResult<InnerGraphImportTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGraphImportTaskFactory, T2, T3, T4, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerGraphImportTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGraphImportTaskFactory, T3, T4, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGraphImportTaskFactory, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGraphImportTaskFactory, T4, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGraphImportTaskFactory, T4> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGraphImportTaskFactory, InnerGraphImportOptionsFactory> WithImportOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGraphImportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.GraphTypes.ImportOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImportOptions(combinedResult.T5, subFactoryAction).T2);
}

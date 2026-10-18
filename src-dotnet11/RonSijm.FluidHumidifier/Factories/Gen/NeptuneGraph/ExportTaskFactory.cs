// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class ExportTaskFactory(string resourceName = null, Action<Humidifier.NeptuneGraph.ExportTask> factoryAction = null) : ResourceFactory<Humidifier.NeptuneGraph.ExportTask>(resourceName)
{

    internal InnerExportTaskExportFilterFactory ExportFilterFactory { get; set; }

    protected override Humidifier.NeptuneGraph.ExportTask Create()
    {
        var exportTaskResult = CreateExportTask();
        factoryAction?.Invoke(exportTaskResult);

        return exportTaskResult;
    }

    private Humidifier.NeptuneGraph.ExportTask CreateExportTask()
    {
        var exportTaskResult = new Humidifier.NeptuneGraph.ExportTask
        {
            GivenName = InputResourceName,
        };

        return exportTaskResult;
    }
    public override void CreateChildren(Humidifier.NeptuneGraph.ExportTask result)
    {
        base.CreateChildren(result);

        result.ExportFilter ??= ExportFilterFactory?.Build();
    }

} // End Of Class

public static class ExportTaskFactoryExtensions
{
    public static CombinedResult<ExportTaskFactory, InnerExportTaskExportFilterFactory> WithExportFilter(this ExportTaskFactory parentFactory, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null)
    {
        parentFactory.ExportFilterFactory = new InnerExportTaskExportFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportFilterFactory);
    }

    public static CombinedResult<ExportTaskFactory, T1, InnerExportTaskExportFilterFactory> WithExportFilter<T1>(this CombinedResult<ExportTaskFactory, T1> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportTaskFactory, InnerExportTaskExportFilterFactory> WithExportFilter<T1>(this CombinedResult<T1, ExportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExportTaskFactory, T1, T2, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2>(this CombinedResult<ExportTaskFactory, T1, T2> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportTaskFactory, T2, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2>(this CombinedResult<T1, ExportTaskFactory, T2> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportTaskFactory, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2>(this CombinedResult<T1, T2, ExportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExportTaskFactory, T1, T2, T3, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3>(this CombinedResult<ExportTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportTaskFactory, T2, T3, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3>(this CombinedResult<T1, ExportTaskFactory, T2, T3> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportTaskFactory, T3, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3>(this CombinedResult<T1, T2, ExportTaskFactory, T3> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExportTaskFactory, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExportTaskFactory, T1, T2, T3, T4, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3, T4>(this CombinedResult<ExportTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportTaskFactory, T2, T3, T4, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3, T4>(this CombinedResult<T1, ExportTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportTaskFactory, T3, T4, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExportTaskFactory, T3, T4> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExportTaskFactory, T4, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExportTaskFactory, T4> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExportTaskFactory, InnerExportTaskExportFilterFactory> WithExportFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExportTaskFactory> combinedResult, Action<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportFilter(combinedResult.T5, subFactoryAction).T2);
}

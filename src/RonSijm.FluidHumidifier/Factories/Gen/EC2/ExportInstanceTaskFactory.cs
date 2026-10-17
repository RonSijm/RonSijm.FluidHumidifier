// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ExportInstanceTaskFactory(string resourceName = null, Action<Humidifier.EC2.ExportInstanceTask> factoryAction = null) : ResourceFactory<Humidifier.EC2.ExportInstanceTask>(resourceName)
{

    internal InnerExportInstanceTaskExportToS3TaskFactory ExportToS3TaskFactory { get; set; }

    protected override Humidifier.EC2.ExportInstanceTask Create()
    {
        var exportInstanceTaskResult = CreateExportInstanceTask();
        factoryAction?.Invoke(exportInstanceTaskResult);

        return exportInstanceTaskResult;
    }

    private Humidifier.EC2.ExportInstanceTask CreateExportInstanceTask()
    {
        var exportInstanceTaskResult = new Humidifier.EC2.ExportInstanceTask
        {
            GivenName = InputResourceName,
        };

        return exportInstanceTaskResult;
    }
    public override void CreateChildren(Humidifier.EC2.ExportInstanceTask result)
    {
        base.CreateChildren(result);

        result.ExportToS3Task ??= ExportToS3TaskFactory?.Build();
    }

} // End Of Class

public static class ExportInstanceTaskFactoryExtensions
{
    public static CombinedResult<ExportInstanceTaskFactory, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task(this ExportInstanceTaskFactory parentFactory, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null)
    {
        parentFactory.ExportToS3TaskFactory = new InnerExportInstanceTaskExportToS3TaskFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExportToS3TaskFactory);
    }

    public static CombinedResult<ExportInstanceTaskFactory, T1, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1>(this CombinedResult<ExportInstanceTaskFactory, T1> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportToS3Task(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportInstanceTaskFactory, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1>(this CombinedResult<T1, ExportInstanceTaskFactory> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, WithExportToS3Task(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ExportInstanceTaskFactory, T1, T2, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2>(this CombinedResult<ExportInstanceTaskFactory, T1, T2> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportInstanceTaskFactory, T2, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2>(this CombinedResult<T1, ExportInstanceTaskFactory, T2> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportInstanceTaskFactory, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2>(this CombinedResult<T1, T2, ExportInstanceTaskFactory> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ExportInstanceTaskFactory, T1, T2, T3, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3>(this CombinedResult<ExportInstanceTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportInstanceTaskFactory, T2, T3, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3>(this CombinedResult<T1, ExportInstanceTaskFactory, T2, T3> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportInstanceTaskFactory, T3, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3>(this CombinedResult<T1, T2, ExportInstanceTaskFactory, T3> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExportInstanceTaskFactory, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3>(this CombinedResult<T1, T2, T3, ExportInstanceTaskFactory> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ExportInstanceTaskFactory, T1, T2, T3, T4, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3, T4>(this CombinedResult<ExportInstanceTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ExportInstanceTaskFactory, T2, T3, T4, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3, T4>(this CombinedResult<T1, ExportInstanceTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ExportInstanceTaskFactory, T3, T4, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3, T4>(this CombinedResult<T1, T2, ExportInstanceTaskFactory, T3, T4> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ExportInstanceTaskFactory, T4, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ExportInstanceTaskFactory, T4> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ExportInstanceTaskFactory, InnerExportInstanceTaskExportToS3TaskFactory> WithExportToS3Task<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ExportInstanceTaskFactory> combinedResult, Action<Humidifier.EC2.ExportInstanceTaskTypes.ExportToS3Task> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExportToS3Task(combinedResult.T5, subFactoryAction).T2);
}

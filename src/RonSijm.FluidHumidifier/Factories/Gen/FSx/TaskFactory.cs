// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class TaskFactory(string resourceName = null, Action<Humidifier.FSx.Task> factoryAction = null) : ResourceFactory<Humidifier.FSx.Task>(resourceName)
{

    internal InnerTaskCompletionReportFactory ReportFactory { get; set; }

    internal InnerTaskReleaseConfigurationFactory ReleaseConfigurationFactory { get; set; }

    protected override Humidifier.FSx.Task Create()
    {
        var taskResult = CreateTask();
        factoryAction?.Invoke(taskResult);

        return taskResult;
    }

    private Humidifier.FSx.Task CreateTask()
    {
        var taskResult = new Humidifier.FSx.Task
        {
            GivenName = InputResourceName,
        };

        return taskResult;
    }
    public override void CreateChildren(Humidifier.FSx.Task result)
    {
        base.CreateChildren(result);

        result.Report ??= ReportFactory?.Build();
        result.ReleaseConfiguration ??= ReleaseConfigurationFactory?.Build();
    }

} // End Of Class

public static class TaskFactoryExtensions
{
    public static CombinedResult<TaskFactory, InnerTaskCompletionReportFactory> WithReport(this TaskFactory parentFactory, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null)
    {
        parentFactory.ReportFactory = new InnerTaskCompletionReportFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportFactory);
    }

    public static CombinedResult<TaskFactory, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration(this TaskFactory parentFactory, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null)
    {
        parentFactory.ReleaseConfigurationFactory = new InnerTaskReleaseConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReleaseConfigurationFactory);
    }

    public static CombinedResult<TaskFactory, T1, InnerTaskCompletionReportFactory> WithReport<T1>(this CombinedResult<TaskFactory, T1> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, InnerTaskCompletionReportFactory> WithReport<T1>(this CombinedResult<T1, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, InnerTaskCompletionReportFactory> WithReport<T1, T2>(this CombinedResult<TaskFactory, T1, T2> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, InnerTaskCompletionReportFactory> WithReport<T1, T2>(this CombinedResult<T1, TaskFactory, T2> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, InnerTaskCompletionReportFactory> WithReport<T1, T2>(this CombinedResult<T1, T2, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, T3, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3>(this CombinedResult<TaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, T3, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, TaskFactory, T2, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, T3, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, T2, TaskFactory, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TaskFactory, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, T3, T4, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<TaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, T3, T4, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, TaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, T3, T4, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskFactory, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TaskFactory, T4, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskFactory, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TaskFactory, InnerTaskCompletionReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.CompletionReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1>(this CombinedResult<TaskFactory, T1> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1>(this CombinedResult<T1, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2>(this CombinedResult<TaskFactory, T1, T2> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2>(this CombinedResult<T1, TaskFactory, T2> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2>(this CombinedResult<T1, T2, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, T3, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3>(this CombinedResult<TaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, T3, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3>(this CombinedResult<T1, TaskFactory, T2, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, T3, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TaskFactory, T3> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TaskFactory, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, T3, T4, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3, T4>(this CombinedResult<TaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, T3, T4, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, T3, T4, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskFactory, T3, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TaskFactory, T4, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskFactory, T4> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TaskFactory, InnerTaskReleaseConfigurationFactory> WithReleaseConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskFactory> combinedResult, Action<Humidifier.FSx.TaskTypes.ReleaseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReleaseConfiguration(combinedResult.T5, subFactoryAction).T2);
}

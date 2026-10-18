// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class TaskFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Task> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Task>(resourceName)
{

    internal InnerTaskTaskConfigurationFactory TaskConfigurationFactory { get; set; }

    protected override Humidifier.IoTSiteWise.Task Create()
    {
        var taskResult = CreateTask();
        factoryAction?.Invoke(taskResult);

        return taskResult;
    }

    private Humidifier.IoTSiteWise.Task CreateTask()
    {
        var taskResult = new Humidifier.IoTSiteWise.Task
        {
            GivenName = InputResourceName,
        };

        return taskResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.Task result)
    {
        base.CreateChildren(result);

        result.TaskConfiguration ??= TaskConfigurationFactory?.Build();
    }

} // End Of Class

public static class TaskFactoryExtensions
{
    public static CombinedResult<TaskFactory, InnerTaskTaskConfigurationFactory> WithTaskConfiguration(this TaskFactory parentFactory, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null)
    {
        parentFactory.TaskConfigurationFactory = new InnerTaskTaskConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TaskConfigurationFactory);
    }

    public static CombinedResult<TaskFactory, T1, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1>(this CombinedResult<TaskFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1>(this CombinedResult<T1, TaskFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2>(this CombinedResult<TaskFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2>(this CombinedResult<T1, TaskFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2>(this CombinedResult<T1, T2, TaskFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, T3, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3>(this CombinedResult<TaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, T3, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3>(this CombinedResult<T1, TaskFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, T3, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TaskFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TaskFactory, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TaskFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TaskFactory, T1, T2, T3, T4, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<TaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TaskFactory, T2, T3, T4, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TaskFactory, T3, T4, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TaskFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TaskFactory, T4, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TaskFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TaskFactory, InnerTaskTaskConfigurationFactory> WithTaskConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TaskFactory> combinedResult, Action<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfiguration(combinedResult.T5, subFactoryAction).T2);
}

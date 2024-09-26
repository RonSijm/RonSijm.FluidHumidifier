// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class JobFactory(string resourceName = null, Action<Humidifier.Glue.Job> factoryAction = null) : ResourceFactory<Humidifier.Glue.Job>(resourceName)
{

    internal InnerJobConnectionsListFactory ConnectionsFactory { get; set; }

    internal InnerJobNotificationPropertyFactory NotificationPropertyFactory { get; set; }

    internal InnerJobJobCommandFactory CommandFactory { get; set; }

    internal InnerJobExecutionPropertyFactory ExecutionPropertyFactory { get; set; }

    protected override Humidifier.Glue.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.Glue.Job CreateJob()
    {
        var jobResult = new Humidifier.Glue.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }
    public override void CreateChildren(Humidifier.Glue.Job result)
    {
        base.CreateChildren(result);

        result.Connections ??= ConnectionsFactory?.Build();
        result.NotificationProperty ??= NotificationPropertyFactory?.Build();
        result.Command ??= CommandFactory?.Build();
        result.ExecutionProperty ??= ExecutionPropertyFactory?.Build();
    }

} // End Of Class

public static class JobFactoryExtensions
{
    public static CombinedResult<JobFactory, InnerJobConnectionsListFactory> WithConnections(this JobFactory parentFactory, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null)
    {
        parentFactory.ConnectionsFactory = new InnerJobConnectionsListFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionsFactory);
    }

    public static CombinedResult<JobFactory, InnerJobNotificationPropertyFactory> WithNotificationProperty(this JobFactory parentFactory, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null)
    {
        parentFactory.NotificationPropertyFactory = new InnerJobNotificationPropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationPropertyFactory);
    }

    public static CombinedResult<JobFactory, InnerJobJobCommandFactory> WithCommand(this JobFactory parentFactory, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null)
    {
        parentFactory.CommandFactory = new InnerJobJobCommandFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CommandFactory);
    }

    public static CombinedResult<JobFactory, InnerJobExecutionPropertyFactory> WithExecutionProperty(this JobFactory parentFactory, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null)
    {
        parentFactory.ExecutionPropertyFactory = new InnerJobExecutionPropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExecutionPropertyFactory);
    }

    public static CombinedResult<JobFactory, T1, InnerJobConnectionsListFactory> WithConnections<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, InnerJobConnectionsListFactory> WithConnections<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, InnerJobConnectionsListFactory> WithConnections<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, InnerJobConnectionsListFactory> WithConnections<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, InnerJobConnectionsListFactory> WithConnections<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobConnectionsListFactory> WithConnections<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ConnectionsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnections(combinedResult.T5, subFactoryAction));
    public static CombinedResult<JobFactory, T1, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobNotificationPropertyFactory> WithNotificationProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.NotificationProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationProperty(combinedResult.T5, subFactoryAction));
    public static CombinedResult<JobFactory, T1, InnerJobJobCommandFactory> WithCommand<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, InnerJobJobCommandFactory> WithCommand<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobCommandFactory> WithCommand<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobCommandFactory> WithCommand<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobCommandFactory> WithCommand<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobCommandFactory> WithCommand<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobCommandFactory> WithCommand<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.JobCommand> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCommand(combinedResult.T5, subFactoryAction));
    public static CombinedResult<JobFactory, T1, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecutionProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecutionProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobExecutionPropertyFactory> WithExecutionProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.Glue.JobTypes.ExecutionProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutionProperty(combinedResult.T5, subFactoryAction));
}

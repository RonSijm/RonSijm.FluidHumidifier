// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class JobQueueFactory(string resourceName = null, Action<Humidifier.Batch.JobQueue> factoryAction = null) : ResourceFactory<Humidifier.Batch.JobQueue>(resourceName)
{

    internal List<InnerJobQueueComputeEnvironmentOrderFactory> ComputeEnvironmentOrderFactories { get; set; } = [];

    internal List<InnerJobQueueJobStateTimeLimitActionFactory> JobStateTimeLimitActionsFactories { get; set; } = [];

    protected override Humidifier.Batch.JobQueue Create()
    {
        var jobQueueResult = CreateJobQueue();
        factoryAction?.Invoke(jobQueueResult);

        return jobQueueResult;
    }

    private Humidifier.Batch.JobQueue CreateJobQueue()
    {
        var jobQueueResult = new Humidifier.Batch.JobQueue
        {
            GivenName = InputResourceName,
        };

        return jobQueueResult;
    }
    public override void CreateChildren(Humidifier.Batch.JobQueue result)
    {
        base.CreateChildren(result);

        result.ComputeEnvironmentOrder = ComputeEnvironmentOrderFactories.Any() ? ComputeEnvironmentOrderFactories.Select(x => x.Build()).ToList() : null;
        result.JobStateTimeLimitActions = JobStateTimeLimitActionsFactories.Any() ? JobStateTimeLimitActionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class JobQueueFactoryExtensions
{
    public static CombinedResult<JobQueueFactory, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder(this JobQueueFactory parentFactory, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null)
    {
        var factory = new InnerJobQueueComputeEnvironmentOrderFactory(subFactoryAction);
        parentFactory.ComputeEnvironmentOrderFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<JobQueueFactory, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions(this JobQueueFactory parentFactory, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null)
    {
        var factory = new InnerJobQueueJobStateTimeLimitActionFactory(subFactoryAction);
        parentFactory.JobStateTimeLimitActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<JobQueueFactory, T1, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1>(this CombinedResult<JobQueueFactory, T1> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1>(this CombinedResult<T1, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobQueueFactory, T1, T2, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2>(this CombinedResult<JobQueueFactory, T1, T2> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, T2, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2>(this CombinedResult<T1, JobQueueFactory, T2> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobQueueFactory, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2>(this CombinedResult<T1, T2, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobQueueFactory, T1, T2, T3, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3>(this CombinedResult<JobQueueFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, T2, T3, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3>(this CombinedResult<T1, JobQueueFactory, T2, T3> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobQueueFactory, T3, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3>(this CombinedResult<T1, T2, JobQueueFactory, T3> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobQueueFactory, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobQueueFactory, T1, T2, T3, T4, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3, T4>(this CombinedResult<JobQueueFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, T2, T3, T4, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3, T4>(this CombinedResult<T1, JobQueueFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobQueueFactory, T3, T4, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobQueueFactory, T3, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobQueueFactory, T4, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobQueueFactory, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobQueueFactory, InnerJobQueueComputeEnvironmentOrderFactory> WithComputeEnvironmentOrder<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.ComputeEnvironmentOrder> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeEnvironmentOrder(combinedResult.T5, subFactoryAction));
    public static CombinedResult<JobQueueFactory, T1, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1>(this CombinedResult<JobQueueFactory, T1> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1>(this CombinedResult<T1, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<JobQueueFactory, T1, T2, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2>(this CombinedResult<JobQueueFactory, T1, T2> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, T2, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2>(this CombinedResult<T1, JobQueueFactory, T2> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobQueueFactory, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2>(this CombinedResult<T1, T2, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<JobQueueFactory, T1, T2, T3, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3>(this CombinedResult<JobQueueFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, T2, T3, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3>(this CombinedResult<T1, JobQueueFactory, T2, T3> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobQueueFactory, T3, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3>(this CombinedResult<T1, T2, JobQueueFactory, T3> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobQueueFactory, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<JobQueueFactory, T1, T2, T3, T4, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3, T4>(this CombinedResult<JobQueueFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, JobQueueFactory, T2, T3, T4, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3, T4>(this CombinedResult<T1, JobQueueFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, JobQueueFactory, T3, T4, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobQueueFactory, T3, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, JobQueueFactory, T4, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobQueueFactory, T4> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, JobQueueFactory, InnerJobQueueJobStateTimeLimitActionFactory> WithJobStateTimeLimitActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobQueueFactory> combinedResult, Action<Humidifier.Batch.JobQueueTypes.JobStateTimeLimitAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobStateTimeLimitActions(combinedResult.T5, subFactoryAction));
}

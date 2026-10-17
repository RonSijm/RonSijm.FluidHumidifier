// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class WorkerFactory(string resourceName = null, Action<Humidifier.Deadline.Worker> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Worker>(resourceName)
{

    internal List<InnerWorkerTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerWorkerHostPropertiesRequestFactory HostPropertiesFactory { get; set; }

    protected override Humidifier.Deadline.Worker Create()
    {
        var workerResult = CreateWorker();
        factoryAction?.Invoke(workerResult);

        return workerResult;
    }

    private Humidifier.Deadline.Worker CreateWorker()
    {
        var workerResult = new Humidifier.Deadline.Worker
        {
            GivenName = InputResourceName,
        };

        return workerResult;
    }
    public override void CreateChildren(Humidifier.Deadline.Worker result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.HostProperties ??= HostPropertiesFactory?.Build();
    }

} // End Of Class

public static class WorkerFactoryExtensions
{
    public static CombinedResult<WorkerFactory, InnerWorkerTagsItemsFactory> WithTags(this WorkerFactory parentFactory, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerWorkerTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkerFactory, InnerWorkerHostPropertiesRequestFactory> WithHostProperties(this WorkerFactory parentFactory, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null)
    {
        parentFactory.HostPropertiesFactory = new InnerWorkerHostPropertiesRequestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostPropertiesFactory);
    }

    public static CombinedResult<WorkerFactory, T1, InnerWorkerTagsItemsFactory> WithTags<T1>(this CombinedResult<WorkerFactory, T1> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, InnerWorkerTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkerFactory, T1, T2, InnerWorkerTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<WorkerFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, T2, InnerWorkerTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, WorkerFactory, T2> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkerFactory, InnerWorkerTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkerFactory, T1, T2, T3, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<WorkerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, T2, T3, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, WorkerFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkerFactory, T3, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, WorkerFactory, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkerFactory, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkerFactory, T1, T2, T3, T4, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<WorkerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, T2, T3, T4, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, WorkerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkerFactory, T3, T4, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkerFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkerFactory, T4, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkerFactory, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkerFactory, InnerWorkerTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkerFactory, T1, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1>(this CombinedResult<WorkerFactory, T1> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1>(this CombinedResult<T1, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkerFactory, T1, T2, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2>(this CombinedResult<WorkerFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, T2, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2>(this CombinedResult<T1, WorkerFactory, T2> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkerFactory, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2>(this CombinedResult<T1, T2, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkerFactory, T1, T2, T3, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3>(this CombinedResult<WorkerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, T2, T3, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3>(this CombinedResult<T1, WorkerFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkerFactory, T3, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3>(this CombinedResult<T1, T2, WorkerFactory, T3> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkerFactory, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkerFactory, T1, T2, T3, T4, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3, T4>(this CombinedResult<WorkerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkerFactory, T2, T3, T4, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3, T4>(this CombinedResult<T1, WorkerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkerFactory, T3, T4, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkerFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkerFactory, T4, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkerFactory, T4> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkerFactory, InnerWorkerHostPropertiesRequestFactory> WithHostProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkerFactory> combinedResult, Action<Humidifier.Deadline.WorkerTypes.HostPropertiesRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostProperties(combinedResult.T5, subFactoryAction).T2);
}

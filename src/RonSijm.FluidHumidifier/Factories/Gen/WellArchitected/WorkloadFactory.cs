// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class WorkloadFactory(string resourceName = null, Action<Humidifier.WellArchitected.Workload> factoryAction = null) : ResourceFactory<Humidifier.WellArchitected.Workload>(resourceName)
{

    internal List<InnerWorkloadTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerWorkloadDiscoveryConfigFactory DiscoveryConfigFactory { get; set; }

    protected override Humidifier.WellArchitected.Workload Create()
    {
        var workloadResult = CreateWorkload();
        factoryAction?.Invoke(workloadResult);

        return workloadResult;
    }

    private Humidifier.WellArchitected.Workload CreateWorkload()
    {
        var workloadResult = new Humidifier.WellArchitected.Workload
        {
            GivenName = InputResourceName,
        };

        return workloadResult;
    }
    public override void CreateChildren(Humidifier.WellArchitected.Workload result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.DiscoveryConfig ??= DiscoveryConfigFactory?.Build();
    }

} // End Of Class

public static class WorkloadFactoryExtensions
{
    public static CombinedResult<WorkloadFactory, InnerWorkloadTagsItemsFactory> WithTags(this WorkloadFactory parentFactory, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerWorkloadTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkloadFactory, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig(this WorkloadFactory parentFactory, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null)
    {
        parentFactory.DiscoveryConfigFactory = new InnerWorkloadDiscoveryConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DiscoveryConfigFactory);
    }

    public static CombinedResult<WorkloadFactory, T1, InnerWorkloadTagsItemsFactory> WithTags<T1>(this CombinedResult<WorkloadFactory, T1> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, InnerWorkloadTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkloadFactory, T1, T2, InnerWorkloadTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<WorkloadFactory, T1, T2> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, T2, InnerWorkloadTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, WorkloadFactory, T2> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkloadFactory, InnerWorkloadTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkloadFactory, T1, T2, T3, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<WorkloadFactory, T1, T2, T3> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, T2, T3, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, WorkloadFactory, T2, T3> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkloadFactory, T3, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, WorkloadFactory, T3> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkloadFactory, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkloadFactory, T1, T2, T3, T4, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<WorkloadFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, T2, T3, T4, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, WorkloadFactory, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkloadFactory, T3, T4, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkloadFactory, T3, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkloadFactory, T4, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkloadFactory, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkloadFactory, InnerWorkloadTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkloadFactory, T1, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1>(this CombinedResult<WorkloadFactory, T1> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1>(this CombinedResult<T1, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkloadFactory, T1, T2, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2>(this CombinedResult<WorkloadFactory, T1, T2> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, T2, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2>(this CombinedResult<T1, WorkloadFactory, T2> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkloadFactory, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2>(this CombinedResult<T1, T2, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkloadFactory, T1, T2, T3, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3>(this CombinedResult<WorkloadFactory, T1, T2, T3> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, T2, T3, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3>(this CombinedResult<T1, WorkloadFactory, T2, T3> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkloadFactory, T3, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3>(this CombinedResult<T1, T2, WorkloadFactory, T3> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkloadFactory, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkloadFactory, T1, T2, T3, T4, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3, T4>(this CombinedResult<WorkloadFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkloadFactory, T2, T3, T4, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3, T4>(this CombinedResult<T1, WorkloadFactory, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkloadFactory, T3, T4, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkloadFactory, T3, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkloadFactory, T4, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkloadFactory, T4> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkloadFactory, InnerWorkloadDiscoveryConfigFactory> WithDiscoveryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkloadFactory> combinedResult, Action<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDiscoveryConfig(combinedResult.T5, subFactoryAction).T2);
}

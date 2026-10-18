// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudHSM;

public class ClusterFactory(string resourceName = null, Action<Humidifier.CloudHSM.Cluster> factoryAction = null) : ResourceFactory<Humidifier.CloudHSM.Cluster>(resourceName)
{

    internal List<InnerClusterTagsItemsFactory> TagsFactories { get; set; } = [];

    internal InnerClusterBackupRetentionPolicyFactory BackupRetentionPolicyFactory { get; set; }

    protected override Humidifier.CloudHSM.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.CloudHSM.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.CloudHSM.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.CloudHSM.Cluster result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.BackupRetentionPolicy ??= BackupRetentionPolicyFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterTagsItemsFactory> WithTags(this ClusterFactory parentFactory, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerClusterTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ClusterFactory, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy(this ClusterFactory parentFactory, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null)
    {
        parentFactory.BackupRetentionPolicyFactory = new InnerClusterBackupRetentionPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BackupRetentionPolicyFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterTagsItemsFactory> WithTags<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, InnerClusterTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterBackupRetentionPolicyFactory> WithBackupRetentionPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackupRetentionPolicy(combinedResult.T5, subFactoryAction).T2);
}

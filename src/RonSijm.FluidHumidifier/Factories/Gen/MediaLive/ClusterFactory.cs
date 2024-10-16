// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class ClusterFactory(string resourceName = null, Action<Humidifier.MediaLive.Cluster> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.Cluster>(resourceName)
{

    internal List<InnerClusterTagsFactory> TagsFactories { get; set; } = [];

    internal InnerClusterClusterNetworkSettingsFactory NetworkSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.MediaLive.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.MediaLive.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.Cluster result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.NetworkSettings ??= NetworkSettingsFactory?.Build();
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
    public static CombinedResult<ClusterFactory, InnerClusterTagsFactory> WithTags(this ClusterFactory parentFactory, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerClusterTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ClusterFactory, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings(this ClusterFactory parentFactory, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null)
    {
        parentFactory.NetworkSettingsFactory = new InnerClusterClusterNetworkSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkSettingsFactory);
    }

    public static CombinedResult<ClusterFactory, T1, InnerClusterTagsFactory> WithTags<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterTagsFactory> WithTags<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterTagsFactory> WithTags<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1>(this CombinedResult<ClusterFactory, T1> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1>(this CombinedResult<T1, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2>(this CombinedResult<ClusterFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2>(this CombinedResult<T1, ClusterFactory, T2> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2>(this CombinedResult<T1, T2, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3>(this CombinedResult<ClusterFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3>(this CombinedResult<T1, ClusterFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3>(this CombinedResult<T1, T2, ClusterFactory, T3> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ClusterFactory, T1, T2, T3, T4, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3, T4>(this CombinedResult<ClusterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ClusterFactory, T2, T3, T4, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3, T4>(this CombinedResult<T1, ClusterFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ClusterFactory, T3, T4, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, ClusterFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ClusterFactory, T4, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ClusterFactory, T4> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ClusterFactory, InnerClusterClusterNetworkSettingsFactory> WithNetworkSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ClusterFactory> combinedResult, Action<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSettings(combinedResult.T5, subFactoryAction));
}

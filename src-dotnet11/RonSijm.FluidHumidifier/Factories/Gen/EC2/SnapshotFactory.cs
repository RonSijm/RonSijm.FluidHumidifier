// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SnapshotFactory(string resourceName = null, Action<Humidifier.EC2.Snapshot> factoryAction = null) : ResourceFactory<Humidifier.EC2.Snapshot>(resourceName)
{

    internal List<InnerSnapshotTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.EC2.Snapshot Create()
    {
        var snapshotResult = CreateSnapshot();
        factoryAction?.Invoke(snapshotResult);

        return snapshotResult;
    }

    private Humidifier.EC2.Snapshot CreateSnapshot()
    {
        var snapshotResult = new Humidifier.EC2.Snapshot
        {
            GivenName = InputResourceName,
        };

        return snapshotResult;
    }
    public override void CreateChildren(Humidifier.EC2.Snapshot result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SnapshotFactoryExtensions
{
    public static CombinedResult<SnapshotFactory, InnerSnapshotTagsItemsFactory> WithTags(this SnapshotFactory parentFactory, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerSnapshotTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SnapshotFactory, T1, InnerSnapshotTagsItemsFactory> WithTags<T1>(this CombinedResult<SnapshotFactory, T1> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SnapshotFactory, InnerSnapshotTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, SnapshotFactory> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SnapshotFactory, T1, T2, InnerSnapshotTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<SnapshotFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SnapshotFactory, T2, InnerSnapshotTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, SnapshotFactory, T2> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SnapshotFactory, InnerSnapshotTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, SnapshotFactory> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SnapshotFactory, T1, T2, T3, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<SnapshotFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SnapshotFactory, T2, T3, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, SnapshotFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SnapshotFactory, T3, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, SnapshotFactory, T3> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SnapshotFactory, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, SnapshotFactory> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SnapshotFactory, T1, T2, T3, T4, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<SnapshotFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SnapshotFactory, T2, T3, T4, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, SnapshotFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SnapshotFactory, T3, T4, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, SnapshotFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SnapshotFactory, T4, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SnapshotFactory, T4> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SnapshotFactory, InnerSnapshotTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SnapshotFactory> combinedResult, Action<Humidifier.EC2.SnapshotTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}

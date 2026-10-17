// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class VolumeFactory(string resourceName = null, Action<Humidifier.Deadline.Volume> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Volume>(resourceName)
{

    internal List<InnerVolumeTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.Deadline.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.Deadline.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.Deadline.Volume
        {
            GivenName = InputResourceName,
        };

        return volumeResult;
    }
    public override void CreateChildren(Humidifier.Deadline.Volume result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class VolumeFactoryExtensions
{
    public static CombinedResult<VolumeFactory, InnerVolumeTagsItemsFactory> WithTags(this VolumeFactory parentFactory, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerVolumeTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<VolumeFactory, T1, InnerVolumeTagsItemsFactory> WithTags<T1>(this CombinedResult<VolumeFactory, T1> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, InnerVolumeTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, VolumeFactory> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VolumeFactory, T1, T2, InnerVolumeTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<VolumeFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, T2, InnerVolumeTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, VolumeFactory, T2> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VolumeFactory, InnerVolumeTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, VolumeFactory> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VolumeFactory, T1, T2, T3, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<VolumeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, T2, T3, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, VolumeFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VolumeFactory, T3, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, VolumeFactory, T3> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VolumeFactory, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, VolumeFactory> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VolumeFactory, T1, T2, T3, T4, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<VolumeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VolumeFactory, T2, T3, T4, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, VolumeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VolumeFactory, T3, T4, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, VolumeFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VolumeFactory, T4, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VolumeFactory, T4> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VolumeFactory, InnerVolumeTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VolumeFactory> combinedResult, Action<Humidifier.Deadline.VolumeTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}

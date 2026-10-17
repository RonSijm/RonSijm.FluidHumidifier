// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class ReferenceFactory(string resourceName = null, Action<Humidifier.Omics.Reference> factoryAction = null) : ResourceFactory<Humidifier.Omics.Reference>(resourceName)
{

    internal List<InnerReferenceTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.Omics.Reference Create()
    {
        var referenceResult = CreateReference();
        factoryAction?.Invoke(referenceResult);

        return referenceResult;
    }

    private Humidifier.Omics.Reference CreateReference()
    {
        var referenceResult = new Humidifier.Omics.Reference
        {
            GivenName = InputResourceName,
        };

        return referenceResult;
    }
    public override void CreateChildren(Humidifier.Omics.Reference result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ReferenceFactoryExtensions
{
    public static CombinedResult<ReferenceFactory, InnerReferenceTagsItemsFactory> WithTags(this ReferenceFactory parentFactory, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerReferenceTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReferenceFactory, T1, InnerReferenceTagsItemsFactory> WithTags<T1>(this CombinedResult<ReferenceFactory, T1> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReferenceFactory, InnerReferenceTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ReferenceFactory> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ReferenceFactory, T1, T2, InnerReferenceTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ReferenceFactory, T1, T2> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReferenceFactory, T2, InnerReferenceTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ReferenceFactory, T2> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReferenceFactory, InnerReferenceTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ReferenceFactory> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ReferenceFactory, T1, T2, T3, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ReferenceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReferenceFactory, T2, T3, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ReferenceFactory, T2, T3> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReferenceFactory, T3, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ReferenceFactory, T3> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReferenceFactory, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReferenceFactory> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ReferenceFactory, T1, T2, T3, T4, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ReferenceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReferenceFactory, T2, T3, T4, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ReferenceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReferenceFactory, T3, T4, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReferenceFactory, T3, T4> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReferenceFactory, T4, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReferenceFactory, T4> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ReferenceFactory, InnerReferenceTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReferenceFactory> combinedResult, Action<Humidifier.Omics.ReferenceTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}

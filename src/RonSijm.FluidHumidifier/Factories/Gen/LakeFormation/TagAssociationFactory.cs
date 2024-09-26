// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class TagAssociationFactory(string resourceName = null, Action<Humidifier.LakeFormation.TagAssociation> factoryAction = null) : ResourceFactory<Humidifier.LakeFormation.TagAssociation>(resourceName)
{

    internal List<InnerTagAssociationLFTagPairFactory> LFTagsFactories { get; set; } = [];

    internal InnerTagAssociationResourceFactory ResourceFactory { get; set; }

    protected override Humidifier.LakeFormation.TagAssociation Create()
    {
        var tagAssociationResult = CreateTagAssociation();
        factoryAction?.Invoke(tagAssociationResult);

        return tagAssociationResult;
    }

    private Humidifier.LakeFormation.TagAssociation CreateTagAssociation()
    {
        var tagAssociationResult = new Humidifier.LakeFormation.TagAssociation
        {
            GivenName = InputResourceName,
        };

        return tagAssociationResult;
    }
    public override void CreateChildren(Humidifier.LakeFormation.TagAssociation result)
    {
        base.CreateChildren(result);

        result.LFTags = LFTagsFactories.Any() ? LFTagsFactories.Select(x => x.Build()).ToList() : null;
        result.Resource ??= ResourceFactory?.Build();
    }

} // End Of Class

public static class TagAssociationFactoryExtensions
{
    public static CombinedResult<TagAssociationFactory, InnerTagAssociationLFTagPairFactory> WithLFTags(this TagAssociationFactory parentFactory, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null)
    {
        var factory = new InnerTagAssociationLFTagPairFactory(subFactoryAction);
        parentFactory.LFTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TagAssociationFactory, InnerTagAssociationResourceFactory> WithResource(this TagAssociationFactory parentFactory, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null)
    {
        parentFactory.ResourceFactory = new InnerTagAssociationResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceFactory);
    }

    public static CombinedResult<TagAssociationFactory, T1, InnerTagAssociationLFTagPairFactory> WithLFTags<T1>(this CombinedResult<TagAssociationFactory, T1> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, WithLFTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, InnerTagAssociationLFTagPairFactory> WithLFTags<T1>(this CombinedResult<T1, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, WithLFTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TagAssociationFactory, T1, T2, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2>(this CombinedResult<TagAssociationFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, T2, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2>(this CombinedResult<T1, TagAssociationFactory, T2> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TagAssociationFactory, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2>(this CombinedResult<T1, T2, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TagAssociationFactory, T1, T2, T3, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3>(this CombinedResult<TagAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, T2, T3, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3>(this CombinedResult<T1, TagAssociationFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TagAssociationFactory, T3, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3>(this CombinedResult<T1, T2, TagAssociationFactory, T3> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TagAssociationFactory, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TagAssociationFactory, T1, T2, T3, T4, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3, T4>(this CombinedResult<TagAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, T2, T3, T4, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3, T4>(this CombinedResult<T1, TagAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TagAssociationFactory, T3, T4, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, TagAssociationFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TagAssociationFactory, T4, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TagAssociationFactory, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TagAssociationFactory, InnerTagAssociationLFTagPairFactory> WithLFTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLFTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TagAssociationFactory, T1, InnerTagAssociationResourceFactory> WithResource<T1>(this CombinedResult<TagAssociationFactory, T1> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, InnerTagAssociationResourceFactory> WithResource<T1>(this CombinedResult<T1, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TagAssociationFactory, T1, T2, InnerTagAssociationResourceFactory> WithResource<T1, T2>(this CombinedResult<TagAssociationFactory, T1, T2> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, T2, InnerTagAssociationResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, TagAssociationFactory, T2> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TagAssociationFactory, InnerTagAssociationResourceFactory> WithResource<T1, T2>(this CombinedResult<T1, T2, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TagAssociationFactory, T1, T2, T3, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<TagAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, T2, T3, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, TagAssociationFactory, T2, T3> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TagAssociationFactory, T3, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, TagAssociationFactory, T3> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TagAssociationFactory, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TagAssociationFactory, T1, T2, T3, T4, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<TagAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TagAssociationFactory, T2, T3, T4, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, TagAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TagAssociationFactory, T3, T4, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, TagAssociationFactory, T3, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TagAssociationFactory, T4, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TagAssociationFactory, T4> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TagAssociationFactory, InnerTagAssociationResourceFactory> WithResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TagAssociationFactory> combinedResult, Action<Humidifier.LakeFormation.TagAssociationTypes.Resource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResource(combinedResult.T5, subFactoryAction));
}

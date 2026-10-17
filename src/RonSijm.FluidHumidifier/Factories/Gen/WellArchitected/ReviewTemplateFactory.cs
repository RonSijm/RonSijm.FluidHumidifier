// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class ReviewTemplateFactory(string resourceName = null, Action<Humidifier.WellArchitected.ReviewTemplate> factoryAction = null) : ResourceFactory<Humidifier.WellArchitected.ReviewTemplate>(resourceName)
{

    internal List<InnerReviewTemplateTagsItemsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.WellArchitected.ReviewTemplate Create()
    {
        var reviewTemplateResult = CreateReviewTemplate();
        factoryAction?.Invoke(reviewTemplateResult);

        return reviewTemplateResult;
    }

    private Humidifier.WellArchitected.ReviewTemplate CreateReviewTemplate()
    {
        var reviewTemplateResult = new Humidifier.WellArchitected.ReviewTemplate
        {
            GivenName = InputResourceName,
        };

        return reviewTemplateResult;
    }
    public override void CreateChildren(Humidifier.WellArchitected.ReviewTemplate result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ReviewTemplateFactoryExtensions
{
    public static CombinedResult<ReviewTemplateFactory, InnerReviewTemplateTagsItemsFactory> WithTags(this ReviewTemplateFactory parentFactory, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null)
    {
        var factory = new InnerReviewTemplateTagsItemsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ReviewTemplateFactory, T1, InnerReviewTemplateTagsItemsFactory> WithTags<T1>(this CombinedResult<ReviewTemplateFactory, T1> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReviewTemplateFactory, InnerReviewTemplateTagsItemsFactory> WithTags<T1>(this CombinedResult<T1, ReviewTemplateFactory> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ReviewTemplateFactory, T1, T2, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<ReviewTemplateFactory, T1, T2> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReviewTemplateFactory, T2, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, ReviewTemplateFactory, T2> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReviewTemplateFactory, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ReviewTemplateFactory> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ReviewTemplateFactory, T1, T2, T3, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<ReviewTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReviewTemplateFactory, T2, T3, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ReviewTemplateFactory, T2, T3> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReviewTemplateFactory, T3, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ReviewTemplateFactory, T3> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReviewTemplateFactory, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReviewTemplateFactory> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ReviewTemplateFactory, T1, T2, T3, T4, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ReviewTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReviewTemplateFactory, T2, T3, T4, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ReviewTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReviewTemplateFactory, T3, T4, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReviewTemplateFactory, T3, T4> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReviewTemplateFactory, T4, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReviewTemplateFactory, T4> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ReviewTemplateFactory, InnerReviewTemplateTagsItemsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReviewTemplateFactory> combinedResult, Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerRelatedItemRelatedItemContentFactory(Action<Humidifier.Cases.RelatedItemTypes.RelatedItemContent> factoryAction = null) : SubResourceFactory<Humidifier.Cases.RelatedItemTypes.RelatedItemContent>
{

    internal InnerRelatedItemCommentContentFactory CommentFactory { get; set; }

    protected override Humidifier.Cases.RelatedItemTypes.RelatedItemContent Create()
    {
        var relatedItemContentResult = CreateRelatedItemContent();
        factoryAction?.Invoke(relatedItemContentResult);

        return relatedItemContentResult;
    }

    private Humidifier.Cases.RelatedItemTypes.RelatedItemContent CreateRelatedItemContent()
    {
        var relatedItemContentResult = new Humidifier.Cases.RelatedItemTypes.RelatedItemContent();

        return relatedItemContentResult;
    }
    public override void CreateChildren(Humidifier.Cases.RelatedItemTypes.RelatedItemContent result)
    {
        base.CreateChildren(result);

        result.Comment ??= CommentFactory?.Build();
    }

} // End Of Class

public static class InnerRelatedItemRelatedItemContentFactoryExtensions
{
    public static CombinedResult<InnerRelatedItemRelatedItemContentFactory, InnerRelatedItemCommentContentFactory> WithComment(this InnerRelatedItemRelatedItemContentFactory parentFactory, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null)
    {
        parentFactory.CommentFactory = new InnerRelatedItemCommentContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CommentFactory);
    }

    public static CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1, InnerRelatedItemCommentContentFactory> WithComment<T1>(this CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithComment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory, InnerRelatedItemCommentContentFactory> WithComment<T1>(this CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithComment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1, T2, InnerRelatedItemCommentContentFactory> WithComment<T1, T2>(this CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1, T2> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory, T2, InnerRelatedItemCommentContentFactory> WithComment<T1, T2>(this CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory, T2> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRelatedItemRelatedItemContentFactory, InnerRelatedItemCommentContentFactory> WithComment<T1, T2>(this CombinedResult<T1, T2, InnerRelatedItemRelatedItemContentFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1, T2, T3, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3>(this CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory, T2, T3, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3>(this CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory, T2, T3> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRelatedItemRelatedItemContentFactory, T3, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3>(this CombinedResult<T1, T2, InnerRelatedItemRelatedItemContentFactory, T3> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRelatedItemRelatedItemContentFactory, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRelatedItemRelatedItemContentFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1, T2, T3, T4, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3, T4>(this CombinedResult<InnerRelatedItemRelatedItemContentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory, T2, T3, T4, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3, T4>(this CombinedResult<T1, InnerRelatedItemRelatedItemContentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRelatedItemRelatedItemContentFactory, T3, T4, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRelatedItemRelatedItemContentFactory, T3, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRelatedItemRelatedItemContentFactory, T4, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRelatedItemRelatedItemContentFactory, T4> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRelatedItemRelatedItemContentFactory, InnerRelatedItemCommentContentFactory> WithComment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRelatedItemRelatedItemContentFactory> combinedResult, Action<Humidifier.Cases.RelatedItemTypes.CommentContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComment(combinedResult.T5, subFactoryAction).T2);
}

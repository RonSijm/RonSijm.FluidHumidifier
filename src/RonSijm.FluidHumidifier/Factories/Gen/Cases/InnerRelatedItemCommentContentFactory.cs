// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class InnerRelatedItemCommentContentFactory(Action<Humidifier.Cases.RelatedItemTypes.CommentContent> factoryAction = null) : SubResourceFactory<Humidifier.Cases.RelatedItemTypes.CommentContent>
{

    protected override Humidifier.Cases.RelatedItemTypes.CommentContent Create()
    {
        var commentContentResult = CreateCommentContent();
        factoryAction?.Invoke(commentContentResult);

        return commentContentResult;
    }

    private Humidifier.Cases.RelatedItemTypes.CommentContent CreateCommentContent()
    {
        var commentContentResult = new Humidifier.Cases.RelatedItemTypes.CommentContent();

        return commentContentResult;
    }

} // End Of Class

public static class InnerRelatedItemCommentContentFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerTargetedSentimentDetectionJobTagsItemsFactory(Action<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems>
{

    protected override Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerTargetedSentimentDetectionJobTagsItemsFactoryExtensions
{
}

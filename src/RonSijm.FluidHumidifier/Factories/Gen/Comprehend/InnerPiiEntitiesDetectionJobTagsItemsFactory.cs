// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerPiiEntitiesDetectionJobTagsItemsFactory(Action<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.TagsItems>
{

    protected override Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Comprehend.PiiEntitiesDetectionJobTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerPiiEntitiesDetectionJobTagsItemsFactoryExtensions
{
}

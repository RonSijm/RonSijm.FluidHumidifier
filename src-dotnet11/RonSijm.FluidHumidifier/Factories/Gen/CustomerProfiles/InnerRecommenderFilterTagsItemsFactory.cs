// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerRecommenderFilterTagsItemsFactory(Action<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems>
{

    protected override Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CustomerProfiles.RecommenderFilterTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerRecommenderFilterTagsItemsFactoryExtensions
{
}

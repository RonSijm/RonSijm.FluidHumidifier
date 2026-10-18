// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerRecommenderSchemaTagsItemsFactory(Action<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems>
{

    protected override Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.CustomerProfiles.RecommenderSchemaTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerRecommenderSchemaTagsItemsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Forecast;

public class InnerDatasetTagsItemsFactory(Action<Humidifier.Forecast.DatasetTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Forecast.DatasetTypes.TagsItems>
{

    protected override Humidifier.Forecast.DatasetTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Forecast.DatasetTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Forecast.DatasetTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerDatasetTagsItemsFactoryExtensions
{
}

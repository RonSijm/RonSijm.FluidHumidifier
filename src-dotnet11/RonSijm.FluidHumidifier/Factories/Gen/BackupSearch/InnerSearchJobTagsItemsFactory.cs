// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupSearch;

public class InnerSearchJobTagsItemsFactory(Action<Humidifier.BackupSearch.SearchJobTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.BackupSearch.SearchJobTypes.TagsItems>
{

    protected override Humidifier.BackupSearch.SearchJobTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.BackupSearch.SearchJobTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.BackupSearch.SearchJobTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerSearchJobTagsItemsFactoryExtensions
{
}

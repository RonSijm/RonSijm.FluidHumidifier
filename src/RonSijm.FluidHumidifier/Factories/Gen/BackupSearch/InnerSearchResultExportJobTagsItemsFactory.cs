// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupSearch;

public class InnerSearchResultExportJobTagsItemsFactory(Action<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems>
{

    protected override Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.BackupSearch.SearchResultExportJobTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerSearchResultExportJobTagsItemsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerLegalHoldTagsItemsFactory(Action<Humidifier.Backup.LegalHoldTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Backup.LegalHoldTypes.TagsItems>
{

    protected override Humidifier.Backup.LegalHoldTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Backup.LegalHoldTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Backup.LegalHoldTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerLegalHoldTagsItemsFactoryExtensions
{
}

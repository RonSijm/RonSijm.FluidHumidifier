// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerReferenceTagsItemsFactory(Action<Humidifier.Omics.ReferenceTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Omics.ReferenceTypes.TagsItems>
{

    protected override Humidifier.Omics.ReferenceTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Omics.ReferenceTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Omics.ReferenceTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerReferenceTagsItemsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class InnerTerminologyTagsItemsFactory(Action<Humidifier.Translate.TerminologyTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Translate.TerminologyTypes.TagsItems>
{

    protected override Humidifier.Translate.TerminologyTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Translate.TerminologyTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Translate.TerminologyTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerTerminologyTagsItemsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class InnerParallelDataTagsItemsFactory(Action<Humidifier.Translate.ParallelDataTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Translate.ParallelDataTypes.TagsItems>
{

    protected override Humidifier.Translate.ParallelDataTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Translate.ParallelDataTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Translate.ParallelDataTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerParallelDataTagsItemsFactoryExtensions
{
}

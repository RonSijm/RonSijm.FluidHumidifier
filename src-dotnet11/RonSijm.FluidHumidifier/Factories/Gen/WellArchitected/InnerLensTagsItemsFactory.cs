// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class InnerLensTagsItemsFactory(Action<Humidifier.WellArchitected.LensTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.WellArchitected.LensTypes.TagsItems>
{

    protected override Humidifier.WellArchitected.LensTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.WellArchitected.LensTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.WellArchitected.LensTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerLensTagsItemsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class InnerReviewTemplateTagsItemsFactory(Action<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems>
{

    protected override Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.WellArchitected.ReviewTemplateTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerReviewTemplateTagsItemsFactoryExtensions
{
}

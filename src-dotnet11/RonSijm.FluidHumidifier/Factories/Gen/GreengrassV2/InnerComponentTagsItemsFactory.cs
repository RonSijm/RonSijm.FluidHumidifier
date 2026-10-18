// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerComponentTagsItemsFactory(Action<Humidifier.GreengrassV2.ComponentTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.ComponentTypes.TagsItems>
{

    protected override Humidifier.GreengrassV2.ComponentTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.GreengrassV2.ComponentTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.GreengrassV2.ComponentTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerComponentTagsItemsFactoryExtensions
{
}

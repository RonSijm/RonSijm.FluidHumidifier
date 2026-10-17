// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerSessionTagsItemsFactory(Action<Humidifier.Wisdom.SessionTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.SessionTypes.TagsItems>
{

    protected override Humidifier.Wisdom.SessionTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Wisdom.SessionTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Wisdom.SessionTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerSessionTagsItemsFactoryExtensions
{
}

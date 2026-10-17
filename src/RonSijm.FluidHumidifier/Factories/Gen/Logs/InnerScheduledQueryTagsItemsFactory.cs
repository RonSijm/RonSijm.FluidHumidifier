// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerScheduledQueryTagsItemsFactory(Action<Humidifier.Logs.ScheduledQueryTypes.TagsItems> factoryAction = null) : SubResourceFactory<Humidifier.Logs.ScheduledQueryTypes.TagsItems>
{

    protected override Humidifier.Logs.ScheduledQueryTypes.TagsItems Create()
    {
        var tagsItemsResult = CreateTagsItems();
        factoryAction?.Invoke(tagsItemsResult);

        return tagsItemsResult;
    }

    private Humidifier.Logs.ScheduledQueryTypes.TagsItems CreateTagsItems()
    {
        var tagsItemsResult = new Humidifier.Logs.ScheduledQueryTypes.TagsItems();

        return tagsItemsResult;
    }

} // End Of Class

public static class InnerScheduledQueryTagsItemsFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventSchemas;

public class InnerDiscovererTagsEntryFactory(Action<Humidifier.EventSchemas.DiscovererTypes.TagsEntry> factoryAction = null) : SubResourceFactory<Humidifier.EventSchemas.DiscovererTypes.TagsEntry>
{

    protected override Humidifier.EventSchemas.DiscovererTypes.TagsEntry Create()
    {
        var tagsEntryResult = CreateTagsEntry();
        factoryAction?.Invoke(tagsEntryResult);

        return tagsEntryResult;
    }

    private Humidifier.EventSchemas.DiscovererTypes.TagsEntry CreateTagsEntry()
    {
        var tagsEntryResult = new Humidifier.EventSchemas.DiscovererTypes.TagsEntry();

        return tagsEntryResult;
    }

} // End Of Class

public static class InnerDiscovererTagsEntryFactoryExtensions
{
}

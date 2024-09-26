// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventSchemas;

public class InnerRegistryTagsEntryFactory(Action<Humidifier.EventSchemas.RegistryTypes.TagsEntry> factoryAction = null) : SubResourceFactory<Humidifier.EventSchemas.RegistryTypes.TagsEntry>
{

    protected override Humidifier.EventSchemas.RegistryTypes.TagsEntry Create()
    {
        var tagsEntryResult = CreateTagsEntry();
        factoryAction?.Invoke(tagsEntryResult);

        return tagsEntryResult;
    }

    private Humidifier.EventSchemas.RegistryTypes.TagsEntry CreateTagsEntry()
    {
        var tagsEntryResult = new Humidifier.EventSchemas.RegistryTypes.TagsEntry();

        return tagsEntryResult;
    }

} // End Of Class

public static class InnerRegistryTagsEntryFactoryExtensions
{
}

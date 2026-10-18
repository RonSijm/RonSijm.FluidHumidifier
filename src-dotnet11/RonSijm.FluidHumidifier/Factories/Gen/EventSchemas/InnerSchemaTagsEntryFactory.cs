// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventSchemas;

public class InnerSchemaTagsEntryFactory(Action<Humidifier.EventSchemas.SchemaTypes.TagsEntry> factoryAction = null) : SubResourceFactory<Humidifier.EventSchemas.SchemaTypes.TagsEntry>
{

    protected override Humidifier.EventSchemas.SchemaTypes.TagsEntry Create()
    {
        var tagsEntryResult = CreateTagsEntry();
        factoryAction?.Invoke(tagsEntryResult);

        return tagsEntryResult;
    }

    private Humidifier.EventSchemas.SchemaTypes.TagsEntry CreateTagsEntry()
    {
        var tagsEntryResult = new Humidifier.EventSchemas.SchemaTypes.TagsEntry();

        return tagsEntryResult;
    }

} // End Of Class

public static class InnerSchemaTagsEntryFactoryExtensions
{
}

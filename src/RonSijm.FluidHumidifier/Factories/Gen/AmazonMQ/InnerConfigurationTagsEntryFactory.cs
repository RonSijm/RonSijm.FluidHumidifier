// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerConfigurationTagsEntryFactory(Action<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry>
{

    protected override Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry Create()
    {
        var tagsEntryResult = CreateTagsEntry();
        factoryAction?.Invoke(tagsEntryResult);

        return tagsEntryResult;
    }

    private Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry CreateTagsEntry()
    {
        var tagsEntryResult = new Humidifier.AmazonMQ.ConfigurationTypes.TagsEntry();

        return tagsEntryResult;
    }

} // End Of Class

public static class InnerConfigurationTagsEntryFactoryExtensions
{
}

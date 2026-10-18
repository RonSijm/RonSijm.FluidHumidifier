// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmazonMQ;

public class InnerBrokerTagsEntryFactory(Action<Humidifier.AmazonMQ.BrokerTypes.TagsEntry> factoryAction = null) : SubResourceFactory<Humidifier.AmazonMQ.BrokerTypes.TagsEntry>
{

    protected override Humidifier.AmazonMQ.BrokerTypes.TagsEntry Create()
    {
        var tagsEntryResult = CreateTagsEntry();
        factoryAction?.Invoke(tagsEntryResult);

        return tagsEntryResult;
    }

    private Humidifier.AmazonMQ.BrokerTypes.TagsEntry CreateTagsEntry()
    {
        var tagsEntryResult = new Humidifier.AmazonMQ.BrokerTypes.TagsEntry();

        return tagsEntryResult;
    }

} // End Of Class

public static class InnerBrokerTagsEntryFactoryExtensions
{
}

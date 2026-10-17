// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberEventBusV2SystemMetadataFactory(Action<Humidifier.EventsV2.SubscriberTypes.EventBusV2SystemMetadata> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.EventBusV2SystemMetadata>
{

    protected override Humidifier.EventsV2.SubscriberTypes.EventBusV2SystemMetadata Create()
    {
        var eventBusV2SystemMetadataResult = CreateEventBusV2SystemMetadata();
        factoryAction?.Invoke(eventBusV2SystemMetadataResult);

        return eventBusV2SystemMetadataResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.EventBusV2SystemMetadata CreateEventBusV2SystemMetadata()
    {
        var eventBusV2SystemMetadataResult = new Humidifier.EventsV2.SubscriberTypes.EventBusV2SystemMetadata();

        return eventBusV2SystemMetadataResult;
    }

} // End Of Class

public static class InnerSubscriberEventBusV2SystemMetadataFactoryExtensions
{
}

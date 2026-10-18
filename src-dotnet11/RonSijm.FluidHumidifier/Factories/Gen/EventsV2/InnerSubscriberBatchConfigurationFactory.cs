// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberBatchConfigurationFactory(Action<Humidifier.EventsV2.SubscriberTypes.BatchConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.BatchConfiguration>
{

    protected override Humidifier.EventsV2.SubscriberTypes.BatchConfiguration Create()
    {
        var batchConfigurationResult = CreateBatchConfiguration();
        factoryAction?.Invoke(batchConfigurationResult);

        return batchConfigurationResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.BatchConfiguration CreateBatchConfiguration()
    {
        var batchConfigurationResult = new Humidifier.EventsV2.SubscriberTypes.BatchConfiguration();

        return batchConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberBatchConfigurationFactoryExtensions
{
}

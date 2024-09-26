// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorCloudWatchLogsLogDeliveryFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.CloudWatchLogsLogDelivery> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.CloudWatchLogsLogDelivery>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.CloudWatchLogsLogDelivery Create()
    {
        var cloudWatchLogsLogDeliveryResult = CreateCloudWatchLogsLogDelivery();
        factoryAction?.Invoke(cloudWatchLogsLogDeliveryResult);

        return cloudWatchLogsLogDeliveryResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.CloudWatchLogsLogDelivery CreateCloudWatchLogsLogDelivery()
    {
        var cloudWatchLogsLogDeliveryResult = new Humidifier.KafkaConnect.ConnectorTypes.CloudWatchLogsLogDelivery();

        return cloudWatchLogsLogDeliveryResult;
    }

} // End Of Class

public static class InnerConnectorCloudWatchLogsLogDeliveryFactoryExtensions
{
}

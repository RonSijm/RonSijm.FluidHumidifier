// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorFirehoseLogDeliveryFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.FirehoseLogDelivery> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.FirehoseLogDelivery>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.FirehoseLogDelivery Create()
    {
        var firehoseLogDeliveryResult = CreateFirehoseLogDelivery();
        factoryAction?.Invoke(firehoseLogDeliveryResult);

        return firehoseLogDeliveryResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.FirehoseLogDelivery CreateFirehoseLogDelivery()
    {
        var firehoseLogDeliveryResult = new Humidifier.KafkaConnect.ConnectorTypes.FirehoseLogDelivery();

        return firehoseLogDeliveryResult;
    }

} // End Of Class

public static class InnerConnectorFirehoseLogDeliveryFactoryExtensions
{
}

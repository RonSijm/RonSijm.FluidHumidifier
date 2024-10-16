// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorS3LogDeliveryFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.S3LogDelivery> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.S3LogDelivery>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.S3LogDelivery Create()
    {
        var s3LogDeliveryResult = CreateS3LogDelivery();
        factoryAction?.Invoke(s3LogDeliveryResult);

        return s3LogDeliveryResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.S3LogDelivery CreateS3LogDelivery()
    {
        var s3LogDeliveryResult = new Humidifier.KafkaConnect.ConnectorTypes.S3LogDelivery();

        return s3LogDeliveryResult;
    }

} // End Of Class

public static class InnerConnectorS3LogDeliveryFactoryExtensions
{
}

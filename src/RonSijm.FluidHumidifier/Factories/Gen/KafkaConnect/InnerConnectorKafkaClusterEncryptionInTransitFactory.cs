// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorKafkaClusterEncryptionInTransitFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterEncryptionInTransit> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterEncryptionInTransit>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterEncryptionInTransit Create()
    {
        var kafkaClusterEncryptionInTransitResult = CreateKafkaClusterEncryptionInTransit();
        factoryAction?.Invoke(kafkaClusterEncryptionInTransitResult);

        return kafkaClusterEncryptionInTransitResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterEncryptionInTransit CreateKafkaClusterEncryptionInTransit()
    {
        var kafkaClusterEncryptionInTransitResult = new Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterEncryptionInTransit();

        return kafkaClusterEncryptionInTransitResult;
    }

} // End Of Class

public static class InnerConnectorKafkaClusterEncryptionInTransitFactoryExtensions
{
}

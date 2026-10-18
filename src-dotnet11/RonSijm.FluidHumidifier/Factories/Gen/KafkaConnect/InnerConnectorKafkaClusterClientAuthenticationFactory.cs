// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorKafkaClusterClientAuthenticationFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterClientAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterClientAuthentication>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterClientAuthentication Create()
    {
        var kafkaClusterClientAuthenticationResult = CreateKafkaClusterClientAuthentication();
        factoryAction?.Invoke(kafkaClusterClientAuthenticationResult);

        return kafkaClusterClientAuthenticationResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterClientAuthentication CreateKafkaClusterClientAuthentication()
    {
        var kafkaClusterClientAuthenticationResult = new Humidifier.KafkaConnect.ConnectorTypes.KafkaClusterClientAuthentication();

        return kafkaClusterClientAuthenticationResult;
    }

} // End Of Class

public static class InnerConnectorKafkaClusterClientAuthenticationFactoryExtensions
{
}

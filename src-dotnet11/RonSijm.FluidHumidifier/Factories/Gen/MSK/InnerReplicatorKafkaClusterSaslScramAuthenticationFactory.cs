// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterSaslScramAuthenticationFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterSaslScramAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaClusterSaslScramAuthentication>
{

    protected override Humidifier.MSK.ReplicatorTypes.KafkaClusterSaslScramAuthentication Create()
    {
        var kafkaClusterSaslScramAuthenticationResult = CreateKafkaClusterSaslScramAuthentication();
        factoryAction?.Invoke(kafkaClusterSaslScramAuthenticationResult);

        return kafkaClusterSaslScramAuthenticationResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaClusterSaslScramAuthentication CreateKafkaClusterSaslScramAuthentication()
    {
        var kafkaClusterSaslScramAuthenticationResult = new Humidifier.MSK.ReplicatorTypes.KafkaClusterSaslScramAuthentication();

        return kafkaClusterSaslScramAuthenticationResult;
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterSaslScramAuthenticationFactoryExtensions
{
}

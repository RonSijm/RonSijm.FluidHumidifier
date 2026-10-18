// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterOAuthClientCredentialsFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentials> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentials>
{

    protected override Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentials Create()
    {
        var kafkaClusterOAuthClientCredentialsResult = CreateKafkaClusterOAuthClientCredentials();
        factoryAction?.Invoke(kafkaClusterOAuthClientCredentialsResult);

        return kafkaClusterOAuthClientCredentialsResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentials CreateKafkaClusterOAuthClientCredentials()
    {
        var kafkaClusterOAuthClientCredentialsResult = new Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentials();

        return kafkaClusterOAuthClientCredentialsResult;
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterOAuthClientCredentialsFactoryExtensions
{
}

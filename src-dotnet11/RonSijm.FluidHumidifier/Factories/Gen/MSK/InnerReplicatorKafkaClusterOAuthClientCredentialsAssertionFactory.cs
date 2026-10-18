// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterOAuthClientCredentialsAssertionFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentialsAssertion> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentialsAssertion>
{

    protected override Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentialsAssertion Create()
    {
        var kafkaClusterOAuthClientCredentialsAssertionResult = CreateKafkaClusterOAuthClientCredentialsAssertion();
        factoryAction?.Invoke(kafkaClusterOAuthClientCredentialsAssertionResult);

        return kafkaClusterOAuthClientCredentialsAssertionResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentialsAssertion CreateKafkaClusterOAuthClientCredentialsAssertion()
    {
        var kafkaClusterOAuthClientCredentialsAssertionResult = new Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthClientCredentialsAssertion();

        return kafkaClusterOAuthClientCredentialsAssertionResult;
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterOAuthClientCredentialsAssertionFactoryExtensions
{
}

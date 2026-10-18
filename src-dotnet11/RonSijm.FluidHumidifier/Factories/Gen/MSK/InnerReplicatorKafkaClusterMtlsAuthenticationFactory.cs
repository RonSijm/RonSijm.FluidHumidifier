// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterMtlsAuthenticationFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterMtlsAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaClusterMtlsAuthentication>
{

    protected override Humidifier.MSK.ReplicatorTypes.KafkaClusterMtlsAuthentication Create()
    {
        var kafkaClusterMtlsAuthenticationResult = CreateKafkaClusterMtlsAuthentication();
        factoryAction?.Invoke(kafkaClusterMtlsAuthenticationResult);

        return kafkaClusterMtlsAuthenticationResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaClusterMtlsAuthentication CreateKafkaClusterMtlsAuthentication()
    {
        var kafkaClusterMtlsAuthenticationResult = new Humidifier.MSK.ReplicatorTypes.KafkaClusterMtlsAuthentication();

        return kafkaClusterMtlsAuthenticationResult;
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterMtlsAuthenticationFactoryExtensions
{
}

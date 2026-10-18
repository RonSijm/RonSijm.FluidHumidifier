// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterEncryptionInTransitFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterEncryptionInTransit> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaClusterEncryptionInTransit>
{

    protected override Humidifier.MSK.ReplicatorTypes.KafkaClusterEncryptionInTransit Create()
    {
        var kafkaClusterEncryptionInTransitResult = CreateKafkaClusterEncryptionInTransit();
        factoryAction?.Invoke(kafkaClusterEncryptionInTransitResult);

        return kafkaClusterEncryptionInTransitResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaClusterEncryptionInTransit CreateKafkaClusterEncryptionInTransit()
    {
        var kafkaClusterEncryptionInTransitResult = new Humidifier.MSK.ReplicatorTypes.KafkaClusterEncryptionInTransit();

        return kafkaClusterEncryptionInTransitResult;
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterEncryptionInTransitFactoryExtensions
{
}

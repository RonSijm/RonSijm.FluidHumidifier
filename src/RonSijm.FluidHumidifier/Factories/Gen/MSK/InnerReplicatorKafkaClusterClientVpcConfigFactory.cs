// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterClientVpcConfigFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig>
{

    protected override Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig Create()
    {
        var kafkaClusterClientVpcConfigResult = CreateKafkaClusterClientVpcConfig();
        factoryAction?.Invoke(kafkaClusterClientVpcConfigResult);

        return kafkaClusterClientVpcConfigResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig CreateKafkaClusterClientVpcConfig()
    {
        var kafkaClusterClientVpcConfigResult = new Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig();

        return kafkaClusterClientVpcConfigResult;
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterClientVpcConfigFactoryExtensions
{
}

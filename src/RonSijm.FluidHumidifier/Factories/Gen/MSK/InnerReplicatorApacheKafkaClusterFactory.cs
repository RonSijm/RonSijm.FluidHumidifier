// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorApacheKafkaClusterFactory(Action<Humidifier.MSK.ReplicatorTypes.ApacheKafkaCluster> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.ApacheKafkaCluster>
{

    protected override Humidifier.MSK.ReplicatorTypes.ApacheKafkaCluster Create()
    {
        var apacheKafkaClusterResult = CreateApacheKafkaCluster();
        factoryAction?.Invoke(apacheKafkaClusterResult);

        return apacheKafkaClusterResult;
    }

    private Humidifier.MSK.ReplicatorTypes.ApacheKafkaCluster CreateApacheKafkaCluster()
    {
        var apacheKafkaClusterResult = new Humidifier.MSK.ReplicatorTypes.ApacheKafkaCluster();

        return apacheKafkaClusterResult;
    }

} // End Of Class

public static class InnerReplicatorApacheKafkaClusterFactoryExtensions
{
}

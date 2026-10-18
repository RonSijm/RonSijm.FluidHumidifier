// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorAmazonMskClusterFactory(Action<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.AmazonMskCluster>
{

    protected override Humidifier.MSK.ReplicatorTypes.AmazonMskCluster Create()
    {
        var amazonMskClusterResult = CreateAmazonMskCluster();
        factoryAction?.Invoke(amazonMskClusterResult);

        return amazonMskClusterResult;
    }

    private Humidifier.MSK.ReplicatorTypes.AmazonMskCluster CreateAmazonMskCluster()
    {
        var amazonMskClusterResult = new Humidifier.MSK.ReplicatorTypes.AmazonMskCluster();

        return amazonMskClusterResult;
    }

} // End Of Class

public static class InnerReplicatorAmazonMskClusterFactoryExtensions
{
}

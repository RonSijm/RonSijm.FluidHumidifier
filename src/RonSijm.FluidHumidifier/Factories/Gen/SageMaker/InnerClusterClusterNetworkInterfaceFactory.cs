// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterNetworkInterfaceFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterNetworkInterface> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterNetworkInterface>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterNetworkInterface Create()
    {
        var clusterNetworkInterfaceResult = CreateClusterNetworkInterface();
        factoryAction?.Invoke(clusterNetworkInterfaceResult);

        return clusterNetworkInterfaceResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterNetworkInterface CreateClusterNetworkInterface()
    {
        var clusterNetworkInterfaceResult = new Humidifier.SageMaker.ClusterTypes.ClusterNetworkInterface();

        return clusterNetworkInterfaceResult;
    }

} // End Of Class

public static class InnerClusterClusterNetworkInterfaceFactoryExtensions
{
}

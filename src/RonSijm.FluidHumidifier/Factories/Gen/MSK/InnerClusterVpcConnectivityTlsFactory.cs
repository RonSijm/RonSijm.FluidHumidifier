// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterVpcConnectivityTlsFactory(Action<Humidifier.MSK.ClusterTypes.VpcConnectivityTls> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.VpcConnectivityTls>
{

    protected override Humidifier.MSK.ClusterTypes.VpcConnectivityTls Create()
    {
        var vpcConnectivityTlsResult = CreateVpcConnectivityTls();
        factoryAction?.Invoke(vpcConnectivityTlsResult);

        return vpcConnectivityTlsResult;
    }

    private Humidifier.MSK.ClusterTypes.VpcConnectivityTls CreateVpcConnectivityTls()
    {
        var vpcConnectivityTlsResult = new Humidifier.MSK.ClusterTypes.VpcConnectivityTls();

        return vpcConnectivityTlsResult;
    }

} // End Of Class

public static class InnerClusterVpcConnectivityTlsFactoryExtensions
{
}

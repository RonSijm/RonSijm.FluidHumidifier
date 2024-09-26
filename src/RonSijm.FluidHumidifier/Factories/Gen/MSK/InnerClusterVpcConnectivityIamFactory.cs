// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterVpcConnectivityIamFactory(Action<Humidifier.MSK.ClusterTypes.VpcConnectivityIam> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.VpcConnectivityIam>
{

    protected override Humidifier.MSK.ClusterTypes.VpcConnectivityIam Create()
    {
        var vpcConnectivityIamResult = CreateVpcConnectivityIam();
        factoryAction?.Invoke(vpcConnectivityIamResult);

        return vpcConnectivityIamResult;
    }

    private Humidifier.MSK.ClusterTypes.VpcConnectivityIam CreateVpcConnectivityIam()
    {
        var vpcConnectivityIamResult = new Humidifier.MSK.ClusterTypes.VpcConnectivityIam();

        return vpcConnectivityIamResult;
    }

} // End Of Class

public static class InnerClusterVpcConnectivityIamFactoryExtensions
{
}

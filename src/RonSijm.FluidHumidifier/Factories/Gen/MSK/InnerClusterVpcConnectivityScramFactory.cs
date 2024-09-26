// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterVpcConnectivityScramFactory(Action<Humidifier.MSK.ClusterTypes.VpcConnectivityScram> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.VpcConnectivityScram>
{

    protected override Humidifier.MSK.ClusterTypes.VpcConnectivityScram Create()
    {
        var vpcConnectivityScramResult = CreateVpcConnectivityScram();
        factoryAction?.Invoke(vpcConnectivityScramResult);

        return vpcConnectivityScramResult;
    }

    private Humidifier.MSK.ClusterTypes.VpcConnectivityScram CreateVpcConnectivityScram()
    {
        var vpcConnectivityScramResult = new Humidifier.MSK.ClusterTypes.VpcConnectivityScram();

        return vpcConnectivityScramResult;
    }

} // End Of Class

public static class InnerClusterVpcConnectivityScramFactoryExtensions
{
}

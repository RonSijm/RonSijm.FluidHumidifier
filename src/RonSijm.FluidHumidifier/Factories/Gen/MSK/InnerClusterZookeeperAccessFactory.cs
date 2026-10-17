// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterZookeeperAccessFactory(Action<Humidifier.MSK.ClusterTypes.ZookeeperAccess> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.ZookeeperAccess>
{

    protected override Humidifier.MSK.ClusterTypes.ZookeeperAccess Create()
    {
        var zookeeperAccessResult = CreateZookeeperAccess();
        factoryAction?.Invoke(zookeeperAccessResult);

        return zookeeperAccessResult;
    }

    private Humidifier.MSK.ClusterTypes.ZookeeperAccess CreateZookeeperAccess()
    {
        var zookeeperAccessResult = new Humidifier.MSK.ClusterTypes.ZookeeperAccess();

        return zookeeperAccessResult;
    }

} // End Of Class

public static class InnerClusterZookeeperAccessFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterEtcdPlacementFactory(Action<Humidifier.EKS.ClusterTypes.EtcdPlacement> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.EtcdPlacement>
{

    protected override Humidifier.EKS.ClusterTypes.EtcdPlacement Create()
    {
        var etcdPlacementResult = CreateEtcdPlacement();
        factoryAction?.Invoke(etcdPlacementResult);

        return etcdPlacementResult;
    }

    private Humidifier.EKS.ClusterTypes.EtcdPlacement CreateEtcdPlacement()
    {
        var etcdPlacementResult = new Humidifier.EKS.ClusterTypes.EtcdPlacement();

        return etcdPlacementResult;
    }

} // End Of Class

public static class InnerClusterEtcdPlacementFactoryExtensions
{
}

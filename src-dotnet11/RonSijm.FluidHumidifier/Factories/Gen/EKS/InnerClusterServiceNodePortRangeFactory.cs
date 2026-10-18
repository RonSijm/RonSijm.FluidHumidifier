// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterServiceNodePortRangeFactory(Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ServiceNodePortRange>
{

    protected override Humidifier.EKS.ClusterTypes.ServiceNodePortRange Create()
    {
        var serviceNodePortRangeResult = CreateServiceNodePortRange();
        factoryAction?.Invoke(serviceNodePortRangeResult);

        return serviceNodePortRangeResult;
    }

    private Humidifier.EKS.ClusterTypes.ServiceNodePortRange CreateServiceNodePortRange()
    {
        var serviceNodePortRangeResult = new Humidifier.EKS.ClusterTypes.ServiceNodePortRange();

        return serviceNodePortRangeResult;
    }

} // End Of Class

public static class InnerClusterServiceNodePortRangeFactoryExtensions
{
}

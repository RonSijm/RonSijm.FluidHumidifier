// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterClusterLoggingFactory(Action<Humidifier.EKS.ClusterTypes.ClusterLogging> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ClusterLogging>
{

    protected override Humidifier.EKS.ClusterTypes.ClusterLogging Create()
    {
        var clusterLoggingResult = CreateClusterLogging();
        factoryAction?.Invoke(clusterLoggingResult);

        return clusterLoggingResult;
    }

    private Humidifier.EKS.ClusterTypes.ClusterLogging CreateClusterLogging()
    {
        var clusterLoggingResult = new Humidifier.EKS.ClusterTypes.ClusterLogging();

        return clusterLoggingResult;
    }

} // End Of Class

public static class InnerClusterClusterLoggingFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterSlurmConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterSlurmConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterSlurmConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterSlurmConfig Create()
    {
        var clusterSlurmConfigResult = CreateClusterSlurmConfig();
        factoryAction?.Invoke(clusterSlurmConfigResult);

        return clusterSlurmConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterSlurmConfig CreateClusterSlurmConfig()
    {
        var clusterSlurmConfigResult = new Humidifier.SageMaker.ClusterTypes.ClusterSlurmConfig();

        return clusterSlurmConfigResult;
    }

} // End Of Class

public static class InnerClusterClusterSlurmConfigFactoryExtensions
{
}

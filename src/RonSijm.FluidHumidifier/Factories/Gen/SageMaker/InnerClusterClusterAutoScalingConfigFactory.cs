// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterAutoScalingConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterAutoScalingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterAutoScalingConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterAutoScalingConfig Create()
    {
        var clusterAutoScalingConfigResult = CreateClusterAutoScalingConfig();
        factoryAction?.Invoke(clusterAutoScalingConfigResult);

        return clusterAutoScalingConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterAutoScalingConfig CreateClusterAutoScalingConfig()
    {
        var clusterAutoScalingConfigResult = new Humidifier.SageMaker.ClusterTypes.ClusterAutoScalingConfig();

        return clusterAutoScalingConfigResult;
    }

} // End Of Class

public static class InnerClusterClusterAutoScalingConfigFactoryExtensions
{
}

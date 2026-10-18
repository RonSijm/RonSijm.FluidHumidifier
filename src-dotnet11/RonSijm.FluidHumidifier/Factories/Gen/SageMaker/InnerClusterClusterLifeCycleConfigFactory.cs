// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterLifeCycleConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig Create()
    {
        var clusterLifeCycleConfigResult = CreateClusterLifeCycleConfig();
        factoryAction?.Invoke(clusterLifeCycleConfigResult);

        return clusterLifeCycleConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig CreateClusterLifeCycleConfig()
    {
        var clusterLifeCycleConfigResult = new Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig();

        return clusterLifeCycleConfigResult;
    }

} // End Of Class

public static class InnerClusterClusterLifeCycleConfigFactoryExtensions
{
}

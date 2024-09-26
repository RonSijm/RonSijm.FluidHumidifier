// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionClusterConfigFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig Create()
    {
        var clusterConfigResult = CreateClusterConfig();
        factoryAction?.Invoke(clusterConfigResult);

        return clusterConfigResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig CreateClusterConfig()
    {
        var clusterConfigResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig();

        return clusterConfigResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionClusterConfigFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobModelShardingConfigFactory(Action<Humidifier.SageMaker.OptimizationJobTypes.ModelShardingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.ModelShardingConfig>
{

    protected override Humidifier.SageMaker.OptimizationJobTypes.ModelShardingConfig Create()
    {
        var modelShardingConfigResult = CreateModelShardingConfig();
        factoryAction?.Invoke(modelShardingConfigResult);

        return modelShardingConfigResult;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.ModelShardingConfig CreateModelShardingConfig()
    {
        var modelShardingConfigResult = new Humidifier.SageMaker.OptimizationJobTypes.ModelShardingConfig();

        return modelShardingConfigResult;
    }

} // End Of Class

public static class InnerOptimizationJobModelShardingConfigFactoryExtensions
{
}

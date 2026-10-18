// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobOptimizationVpcConfigFactory(Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationVpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.OptimizationVpcConfig>
{

    protected override Humidifier.SageMaker.OptimizationJobTypes.OptimizationVpcConfig Create()
    {
        var optimizationVpcConfigResult = CreateOptimizationVpcConfig();
        factoryAction?.Invoke(optimizationVpcConfigResult);

        return optimizationVpcConfigResult;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.OptimizationVpcConfig CreateOptimizationVpcConfig()
    {
        var optimizationVpcConfigResult = new Humidifier.SageMaker.OptimizationJobTypes.OptimizationVpcConfig();

        return optimizationVpcConfigResult;
    }

} // End Of Class

public static class InnerOptimizationJobOptimizationVpcConfigFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobOptimizationJobOutputConfigFactory(Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobOutputConfig>
{

    protected override Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobOutputConfig Create()
    {
        var optimizationJobOutputConfigResult = CreateOptimizationJobOutputConfig();
        factoryAction?.Invoke(optimizationJobOutputConfigResult);

        return optimizationJobOutputConfigResult;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobOutputConfig CreateOptimizationJobOutputConfig()
    {
        var optimizationJobOutputConfigResult = new Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobOutputConfig();

        return optimizationJobOutputConfigResult;
    }

} // End Of Class

public static class InnerOptimizationJobOptimizationJobOutputConfigFactoryExtensions
{
}

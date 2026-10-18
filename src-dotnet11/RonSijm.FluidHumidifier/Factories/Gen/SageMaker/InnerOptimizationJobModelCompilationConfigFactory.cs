// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobModelCompilationConfigFactory(Action<Humidifier.SageMaker.OptimizationJobTypes.ModelCompilationConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.ModelCompilationConfig>
{

    protected override Humidifier.SageMaker.OptimizationJobTypes.ModelCompilationConfig Create()
    {
        var modelCompilationConfigResult = CreateModelCompilationConfig();
        factoryAction?.Invoke(modelCompilationConfigResult);

        return modelCompilationConfigResult;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.ModelCompilationConfig CreateModelCompilationConfig()
    {
        var modelCompilationConfigResult = new Humidifier.SageMaker.OptimizationJobTypes.ModelCompilationConfig();

        return modelCompilationConfigResult;
    }

} // End Of Class

public static class InnerOptimizationJobModelCompilationConfigFactoryExtensions
{
}

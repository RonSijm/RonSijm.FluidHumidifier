// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobModelQuantizationConfigFactory(Action<Humidifier.SageMaker.OptimizationJobTypes.ModelQuantizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.ModelQuantizationConfig>
{

    protected override Humidifier.SageMaker.OptimizationJobTypes.ModelQuantizationConfig Create()
    {
        var modelQuantizationConfigResult = CreateModelQuantizationConfig();
        factoryAction?.Invoke(modelQuantizationConfigResult);

        return modelQuantizationConfigResult;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.ModelQuantizationConfig CreateModelQuantizationConfig()
    {
        var modelQuantizationConfigResult = new Humidifier.SageMaker.OptimizationJobTypes.ModelQuantizationConfig();

        return modelQuantizationConfigResult;
    }

} // End Of Class

public static class InnerOptimizationJobModelQuantizationConfigFactoryExtensions
{
}

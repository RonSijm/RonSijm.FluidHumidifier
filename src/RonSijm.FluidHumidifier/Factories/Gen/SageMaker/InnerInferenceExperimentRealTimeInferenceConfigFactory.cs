// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceExperimentRealTimeInferenceConfigFactory(Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig>
{

    protected override Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig Create()
    {
        var realTimeInferenceConfigResult = CreateRealTimeInferenceConfig();
        factoryAction?.Invoke(realTimeInferenceConfigResult);

        return realTimeInferenceConfigResult;
    }

    private Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig CreateRealTimeInferenceConfig()
    {
        var realTimeInferenceConfigResult = new Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig();

        return realTimeInferenceConfigResult;
    }

} // End Of Class

public static class InnerInferenceExperimentRealTimeInferenceConfigFactoryExtensions
{
}

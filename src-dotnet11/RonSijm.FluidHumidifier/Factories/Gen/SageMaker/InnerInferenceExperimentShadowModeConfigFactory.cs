// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceExperimentShadowModeConfigFactory(Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig>
{

    protected override Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig Create()
    {
        var shadowModeConfigResult = CreateShadowModeConfig();
        factoryAction?.Invoke(shadowModeConfigResult);

        return shadowModeConfigResult;
    }

    private Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig CreateShadowModeConfig()
    {
        var shadowModeConfigResult = new Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig();

        return shadowModeConfigResult;
    }

} // End Of Class

public static class InnerInferenceExperimentShadowModeConfigFactoryExtensions
{
}

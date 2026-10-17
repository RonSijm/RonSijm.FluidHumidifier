// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobHyperParameterTuningJobWarmStartConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobWarmStartConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobWarmStartConfig>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobWarmStartConfig Create()
    {
        var hyperParameterTuningJobWarmStartConfigResult = CreateHyperParameterTuningJobWarmStartConfig();
        factoryAction?.Invoke(hyperParameterTuningJobWarmStartConfigResult);

        return hyperParameterTuningJobWarmStartConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobWarmStartConfig CreateHyperParameterTuningJobWarmStartConfig()
    {
        var hyperParameterTuningJobWarmStartConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobWarmStartConfig();

        return hyperParameterTuningJobWarmStartConfigResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobHyperParameterTuningJobWarmStartConfigFactoryExtensions
{
}

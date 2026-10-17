// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobProfilerConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.ProfilerConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.ProfilerConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.ProfilerConfig Create()
    {
        var profilerConfigResult = CreateProfilerConfig();
        factoryAction?.Invoke(profilerConfigResult);

        return profilerConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.ProfilerConfig CreateProfilerConfig()
    {
        var profilerConfigResult = new Humidifier.SageMaker.TrainingJobTypes.ProfilerConfig();

        return profilerConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobProfilerConfigFactoryExtensions
{
}

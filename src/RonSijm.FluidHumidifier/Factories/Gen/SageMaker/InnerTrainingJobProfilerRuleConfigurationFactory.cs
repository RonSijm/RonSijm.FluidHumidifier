// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobProfilerRuleConfigurationFactory(Action<Humidifier.SageMaker.TrainingJobTypes.ProfilerRuleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.ProfilerRuleConfiguration>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.ProfilerRuleConfiguration Create()
    {
        var profilerRuleConfigurationResult = CreateProfilerRuleConfiguration();
        factoryAction?.Invoke(profilerRuleConfigurationResult);

        return profilerRuleConfigurationResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.ProfilerRuleConfiguration CreateProfilerRuleConfiguration()
    {
        var profilerRuleConfigurationResult = new Humidifier.SageMaker.TrainingJobTypes.ProfilerRuleConfiguration();

        return profilerRuleConfigurationResult;
    }

} // End Of Class

public static class InnerTrainingJobProfilerRuleConfigurationFactoryExtensions
{
}

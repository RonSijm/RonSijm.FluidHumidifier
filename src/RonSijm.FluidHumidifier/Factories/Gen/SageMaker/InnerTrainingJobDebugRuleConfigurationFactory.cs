// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobDebugRuleConfigurationFactory(Action<Humidifier.SageMaker.TrainingJobTypes.DebugRuleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.DebugRuleConfiguration>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.DebugRuleConfiguration Create()
    {
        var debugRuleConfigurationResult = CreateDebugRuleConfiguration();
        factoryAction?.Invoke(debugRuleConfigurationResult);

        return debugRuleConfigurationResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.DebugRuleConfiguration CreateDebugRuleConfiguration()
    {
        var debugRuleConfigurationResult = new Humidifier.SageMaker.TrainingJobTypes.DebugRuleConfiguration();

        return debugRuleConfigurationResult;
    }

} // End Of Class

public static class InnerTrainingJobDebugRuleConfigurationFactoryExtensions
{
}

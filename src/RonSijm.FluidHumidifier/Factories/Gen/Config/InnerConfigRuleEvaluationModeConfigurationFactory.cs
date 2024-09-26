// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigRuleEvaluationModeConfigurationFactory(Action<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration>
{

    protected override Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration Create()
    {
        var evaluationModeConfigurationResult = CreateEvaluationModeConfiguration();
        factoryAction?.Invoke(evaluationModeConfigurationResult);

        return evaluationModeConfigurationResult;
    }

    private Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration CreateEvaluationModeConfiguration()
    {
        var evaluationModeConfigurationResult = new Humidifier.Config.ConfigRuleTypes.EvaluationModeConfiguration();

        return evaluationModeConfigurationResult;
    }

} // End Of Class

public static class InnerConfigRuleEvaluationModeConfigurationFactoryExtensions
{
}

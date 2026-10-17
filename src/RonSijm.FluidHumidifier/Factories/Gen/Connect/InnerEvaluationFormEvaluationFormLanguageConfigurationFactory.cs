// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEvaluationFormEvaluationFormLanguageConfigurationFactory(Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormLanguageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EvaluationFormTypes.EvaluationFormLanguageConfiguration>
{

    protected override Humidifier.Connect.EvaluationFormTypes.EvaluationFormLanguageConfiguration Create()
    {
        var evaluationFormLanguageConfigurationResult = CreateEvaluationFormLanguageConfiguration();
        factoryAction?.Invoke(evaluationFormLanguageConfigurationResult);

        return evaluationFormLanguageConfigurationResult;
    }

    private Humidifier.Connect.EvaluationFormTypes.EvaluationFormLanguageConfiguration CreateEvaluationFormLanguageConfiguration()
    {
        var evaluationFormLanguageConfigurationResult = new Humidifier.Connect.EvaluationFormTypes.EvaluationFormLanguageConfiguration();

        return evaluationFormLanguageConfigurationResult;
    }

} // End Of Class

public static class InnerEvaluationFormEvaluationFormLanguageConfigurationFactoryExtensions
{
}

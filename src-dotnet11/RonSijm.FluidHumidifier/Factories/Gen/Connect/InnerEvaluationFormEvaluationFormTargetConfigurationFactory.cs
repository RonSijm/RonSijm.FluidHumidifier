// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEvaluationFormEvaluationFormTargetConfigurationFactory(Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormTargetConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EvaluationFormTypes.EvaluationFormTargetConfiguration>
{

    protected override Humidifier.Connect.EvaluationFormTypes.EvaluationFormTargetConfiguration Create()
    {
        var evaluationFormTargetConfigurationResult = CreateEvaluationFormTargetConfiguration();
        factoryAction?.Invoke(evaluationFormTargetConfigurationResult);

        return evaluationFormTargetConfigurationResult;
    }

    private Humidifier.Connect.EvaluationFormTypes.EvaluationFormTargetConfiguration CreateEvaluationFormTargetConfiguration()
    {
        var evaluationFormTargetConfigurationResult = new Humidifier.Connect.EvaluationFormTypes.EvaluationFormTargetConfiguration();

        return evaluationFormTargetConfigurationResult;
    }

} // End Of Class

public static class InnerEvaluationFormEvaluationFormTargetConfigurationFactoryExtensions
{
}

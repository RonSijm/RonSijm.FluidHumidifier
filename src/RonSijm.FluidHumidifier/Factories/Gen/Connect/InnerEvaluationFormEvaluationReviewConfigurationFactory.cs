// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEvaluationFormEvaluationReviewConfigurationFactory(Action<Humidifier.Connect.EvaluationFormTypes.EvaluationReviewConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EvaluationFormTypes.EvaluationReviewConfiguration>
{

    protected override Humidifier.Connect.EvaluationFormTypes.EvaluationReviewConfiguration Create()
    {
        var evaluationReviewConfigurationResult = CreateEvaluationReviewConfiguration();
        factoryAction?.Invoke(evaluationReviewConfigurationResult);

        return evaluationReviewConfigurationResult;
    }

    private Humidifier.Connect.EvaluationFormTypes.EvaluationReviewConfiguration CreateEvaluationReviewConfiguration()
    {
        var evaluationReviewConfigurationResult = new Humidifier.Connect.EvaluationFormTypes.EvaluationReviewConfiguration();

        return evaluationReviewConfigurationResult;
    }

} // End Of Class

public static class InnerEvaluationFormEvaluationReviewConfigurationFactoryExtensions
{
}

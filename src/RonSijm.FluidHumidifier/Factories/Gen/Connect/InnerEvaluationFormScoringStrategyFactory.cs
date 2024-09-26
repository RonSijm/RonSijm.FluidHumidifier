// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEvaluationFormScoringStrategyFactory(Action<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EvaluationFormTypes.ScoringStrategy>
{

    protected override Humidifier.Connect.EvaluationFormTypes.ScoringStrategy Create()
    {
        var scoringStrategyResult = CreateScoringStrategy();
        factoryAction?.Invoke(scoringStrategyResult);

        return scoringStrategyResult;
    }

    private Humidifier.Connect.EvaluationFormTypes.ScoringStrategy CreateScoringStrategy()
    {
        var scoringStrategyResult = new Humidifier.Connect.EvaluationFormTypes.ScoringStrategy();

        return scoringStrategyResult;
    }

} // End Of Class

public static class InnerEvaluationFormScoringStrategyFactoryExtensions
{
}

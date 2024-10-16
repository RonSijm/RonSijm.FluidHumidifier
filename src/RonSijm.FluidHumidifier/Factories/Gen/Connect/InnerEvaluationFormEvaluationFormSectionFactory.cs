// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEvaluationFormEvaluationFormSectionFactory(Action<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection>
{

    protected override Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection Create()
    {
        var evaluationFormSectionResult = CreateEvaluationFormSection();
        factoryAction?.Invoke(evaluationFormSectionResult);

        return evaluationFormSectionResult;
    }

    private Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection CreateEvaluationFormSection()
    {
        var evaluationFormSectionResult = new Humidifier.Connect.EvaluationFormTypes.EvaluationFormSection();

        return evaluationFormSectionResult;
    }

} // End Of Class

public static class InnerEvaluationFormEvaluationFormSectionFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Inspector;

public class AssessmentTemplateFactory(string resourceName = null, Action<Humidifier.Inspector.AssessmentTemplate> factoryAction = null) : ResourceFactory<Humidifier.Inspector.AssessmentTemplate>(resourceName)
{

    protected override Humidifier.Inspector.AssessmentTemplate Create()
    {
        var assessmentTemplateResult = CreateAssessmentTemplate();
        factoryAction?.Invoke(assessmentTemplateResult);

        return assessmentTemplateResult;
    }

    private Humidifier.Inspector.AssessmentTemplate CreateAssessmentTemplate()
    {
        var assessmentTemplateResult = new Humidifier.Inspector.AssessmentTemplate
        {
            GivenName = InputResourceName,
        };

        return assessmentTemplateResult;
    }

} // End Of Class

public static class AssessmentTemplateFactoryExtensions
{
}

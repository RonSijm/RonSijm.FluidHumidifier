// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Inspector;

public class AssessmentTargetFactory(string resourceName = null, Action<Humidifier.Inspector.AssessmentTarget> factoryAction = null) : ResourceFactory<Humidifier.Inspector.AssessmentTarget>(resourceName)
{

    protected override Humidifier.Inspector.AssessmentTarget Create()
    {
        var assessmentTargetResult = CreateAssessmentTarget();
        factoryAction?.Invoke(assessmentTargetResult);

        return assessmentTargetResult;
    }

    private Humidifier.Inspector.AssessmentTarget CreateAssessmentTarget()
    {
        var assessmentTargetResult = new Humidifier.Inspector.AssessmentTarget
        {
            GivenName = InputResourceName,
        };

        return assessmentTargetResult;
    }

} // End Of Class

public static class AssessmentTargetFactoryExtensions
{
}

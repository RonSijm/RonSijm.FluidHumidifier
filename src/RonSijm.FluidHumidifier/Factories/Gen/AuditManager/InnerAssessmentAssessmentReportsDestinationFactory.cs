// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AuditManager;

public class InnerAssessmentAssessmentReportsDestinationFactory(Action<Humidifier.AuditManager.AssessmentTypes.AssessmentReportsDestination> factoryAction = null) : SubResourceFactory<Humidifier.AuditManager.AssessmentTypes.AssessmentReportsDestination>
{

    protected override Humidifier.AuditManager.AssessmentTypes.AssessmentReportsDestination Create()
    {
        var assessmentReportsDestinationResult = CreateAssessmentReportsDestination();
        factoryAction?.Invoke(assessmentReportsDestinationResult);

        return assessmentReportsDestinationResult;
    }

    private Humidifier.AuditManager.AssessmentTypes.AssessmentReportsDestination CreateAssessmentReportsDestination()
    {
        var assessmentReportsDestinationResult = new Humidifier.AuditManager.AssessmentTypes.AssessmentReportsDestination();

        return assessmentReportsDestinationResult;
    }

} // End Of Class

public static class InnerAssessmentAssessmentReportsDestinationFactoryExtensions
{
}

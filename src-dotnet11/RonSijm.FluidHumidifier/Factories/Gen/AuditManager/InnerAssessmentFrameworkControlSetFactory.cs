// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AuditManager;

public class InnerAssessmentFrameworkControlSetFactory(Action<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet> factoryAction = null) : SubResourceFactory<Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet>
{

    protected override Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet Create()
    {
        var controlSetResult = CreateControlSet();
        factoryAction?.Invoke(controlSetResult);

        return controlSetResult;
    }

    private Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet CreateControlSet()
    {
        var controlSetResult = new Humidifier.AuditManager.AssessmentFrameworkTypes.ControlSet();

        return controlSetResult;
    }

} // End Of Class

public static class InnerAssessmentFrameworkControlSetFactoryExtensions
{
}

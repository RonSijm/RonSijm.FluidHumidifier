// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AuditManager;

public class InnerAssessmentScopeFactory(Action<Humidifier.AuditManager.AssessmentTypes.Scope> factoryAction = null) : SubResourceFactory<Humidifier.AuditManager.AssessmentTypes.Scope>
{

    protected override Humidifier.AuditManager.AssessmentTypes.Scope Create()
    {
        var scopeResult = CreateScope();
        factoryAction?.Invoke(scopeResult);

        return scopeResult;
    }

    private Humidifier.AuditManager.AssessmentTypes.Scope CreateScope()
    {
        var scopeResult = new Humidifier.AuditManager.AssessmentTypes.Scope();

        return scopeResult;
    }

} // End Of Class

public static class InnerAssessmentScopeFactoryExtensions
{
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AuditManager;

public class InnerAssessmentRoleFactory(Action<Humidifier.AuditManager.AssessmentTypes.Role> factoryAction = null) : SubResourceFactory<Humidifier.AuditManager.AssessmentTypes.Role>
{

    protected override Humidifier.AuditManager.AssessmentTypes.Role Create()
    {
        var roleResult = CreateRole();
        factoryAction?.Invoke(roleResult);

        return roleResult;
    }

    private Humidifier.AuditManager.AssessmentTypes.Role CreateRole()
    {
        var roleResult = new Humidifier.AuditManager.AssessmentTypes.Role();

        return roleResult;
    }

} // End Of Class

public static class InnerAssessmentRoleFactoryExtensions
{
}

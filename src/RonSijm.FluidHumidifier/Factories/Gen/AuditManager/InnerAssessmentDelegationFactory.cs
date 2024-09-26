// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AuditManager;

public class InnerAssessmentDelegationFactory(Action<Humidifier.AuditManager.AssessmentTypes.Delegation> factoryAction = null) : SubResourceFactory<Humidifier.AuditManager.AssessmentTypes.Delegation>
{

    protected override Humidifier.AuditManager.AssessmentTypes.Delegation Create()
    {
        var delegationResult = CreateDelegation();
        factoryAction?.Invoke(delegationResult);

        return delegationResult;
    }

    private Humidifier.AuditManager.AssessmentTypes.Delegation CreateDelegation()
    {
        var delegationResult = new Humidifier.AuditManager.AssessmentTypes.Delegation();

        return delegationResult;
    }

} // End Of Class

public static class InnerAssessmentDelegationFactoryExtensions
{
}

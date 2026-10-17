// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class InnerApprovalTeamPolicyFactory(Action<Humidifier.MPA.ApprovalTeamTypes.Policy> factoryAction = null) : SubResourceFactory<Humidifier.MPA.ApprovalTeamTypes.Policy>
{

    protected override Humidifier.MPA.ApprovalTeamTypes.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.MPA.ApprovalTeamTypes.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.MPA.ApprovalTeamTypes.Policy();

        return policyResult;
    }

} // End Of Class

public static class InnerApprovalTeamPolicyFactoryExtensions
{
}

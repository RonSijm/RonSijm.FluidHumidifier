// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerMemberApprovalThresholdPolicyFactory(Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy>
{

    protected override Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy Create()
    {
        var approvalThresholdPolicyResult = CreateApprovalThresholdPolicy();
        factoryAction?.Invoke(approvalThresholdPolicyResult);

        return approvalThresholdPolicyResult;
    }

    private Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy CreateApprovalThresholdPolicy()
    {
        var approvalThresholdPolicyResult = new Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy();

        return approvalThresholdPolicyResult;
    }

} // End Of Class

public static class InnerMemberApprovalThresholdPolicyFactoryExtensions
{
}

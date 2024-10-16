// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerMemberVotingPolicyFactory(Action<Humidifier.ManagedBlockchain.MemberTypes.VotingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.MemberTypes.VotingPolicy>
{

    internal InnerMemberApprovalThresholdPolicyFactory ApprovalThresholdPolicyFactory { get; set; }

    protected override Humidifier.ManagedBlockchain.MemberTypes.VotingPolicy Create()
    {
        var votingPolicyResult = CreateVotingPolicy();
        factoryAction?.Invoke(votingPolicyResult);

        return votingPolicyResult;
    }

    private Humidifier.ManagedBlockchain.MemberTypes.VotingPolicy CreateVotingPolicy()
    {
        var votingPolicyResult = new Humidifier.ManagedBlockchain.MemberTypes.VotingPolicy();

        return votingPolicyResult;
    }
    public override void CreateChildren(Humidifier.ManagedBlockchain.MemberTypes.VotingPolicy result)
    {
        base.CreateChildren(result);

        result.ApprovalThresholdPolicy ??= ApprovalThresholdPolicyFactory?.Build();
    }

} // End Of Class

public static class InnerMemberVotingPolicyFactoryExtensions
{
    public static CombinedResult<InnerMemberVotingPolicyFactory, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy(this InnerMemberVotingPolicyFactory parentFactory, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null)
    {
        parentFactory.ApprovalThresholdPolicyFactory = new InnerMemberApprovalThresholdPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApprovalThresholdPolicyFactory);
    }

    public static CombinedResult<InnerMemberVotingPolicyFactory, T1, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1>(this CombinedResult<InnerMemberVotingPolicyFactory, T1> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberVotingPolicyFactory, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1>(this CombinedResult<T1, InnerMemberVotingPolicyFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMemberVotingPolicyFactory, T1, T2, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2>(this CombinedResult<InnerMemberVotingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberVotingPolicyFactory, T2, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2>(this CombinedResult<T1, InnerMemberVotingPolicyFactory, T2> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberVotingPolicyFactory, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2>(this CombinedResult<T1, T2, InnerMemberVotingPolicyFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMemberVotingPolicyFactory, T1, T2, T3, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3>(this CombinedResult<InnerMemberVotingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberVotingPolicyFactory, T2, T3, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3>(this CombinedResult<T1, InnerMemberVotingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberVotingPolicyFactory, T3, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerMemberVotingPolicyFactory, T3> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberVotingPolicyFactory, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMemberVotingPolicyFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMemberVotingPolicyFactory, T1, T2, T3, T4, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3, T4>(this CombinedResult<InnerMemberVotingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMemberVotingPolicyFactory, T2, T3, T4, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerMemberVotingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMemberVotingPolicyFactory, T3, T4, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMemberVotingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMemberVotingPolicyFactory, T4, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMemberVotingPolicyFactory, T4> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMemberVotingPolicyFactory, InnerMemberApprovalThresholdPolicyFactory> WithApprovalThresholdPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMemberVotingPolicyFactory> combinedResult, Action<Humidifier.ManagedBlockchain.MemberTypes.ApprovalThresholdPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalThresholdPolicy(combinedResult.T5, subFactoryAction));
}

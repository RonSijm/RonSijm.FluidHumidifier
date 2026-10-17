// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MPA;

public class ApprovalTeamFactory(string resourceName = null, Action<Humidifier.MPA.ApprovalTeam> factoryAction = null) : ResourceFactory<Humidifier.MPA.ApprovalTeam>(resourceName)
{

    internal List<InnerApprovalTeamPolicyFactory> PoliciesFactories { get; set; } = [];

    internal List<InnerApprovalTeamApproverFactory> ApproversFactories { get; set; } = [];

    internal InnerApprovalTeamApprovalStrategyFactory ApprovalStrategyFactory { get; set; }

    protected override Humidifier.MPA.ApprovalTeam Create()
    {
        var approvalTeamResult = CreateApprovalTeam();
        factoryAction?.Invoke(approvalTeamResult);

        return approvalTeamResult;
    }

    private Humidifier.MPA.ApprovalTeam CreateApprovalTeam()
    {
        var approvalTeamResult = new Humidifier.MPA.ApprovalTeam
        {
            GivenName = InputResourceName,
        };

        return approvalTeamResult;
    }
    public override void CreateChildren(Humidifier.MPA.ApprovalTeam result)
    {
        base.CreateChildren(result);

        result.Policies = PoliciesFactories.Any() ? PoliciesFactories.Select(x => x.Build()).ToList() : null;
        result.Approvers = ApproversFactories.Any() ? ApproversFactories.Select(x => x.Build()).ToList() : null;
        result.ApprovalStrategy ??= ApprovalStrategyFactory?.Build();
    }

} // End Of Class

public static class ApprovalTeamFactoryExtensions
{
    public static CombinedResult<ApprovalTeamFactory, InnerApprovalTeamPolicyFactory> WithPolicies(this ApprovalTeamFactory parentFactory, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null)
    {
        var factory = new InnerApprovalTeamPolicyFactory(subFactoryAction);
        parentFactory.PoliciesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApprovalTeamFactory, InnerApprovalTeamApproverFactory> WithApprovers(this ApprovalTeamFactory parentFactory, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null)
    {
        var factory = new InnerApprovalTeamApproverFactory(subFactoryAction);
        parentFactory.ApproversFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApprovalTeamFactory, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy(this ApprovalTeamFactory parentFactory, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null)
    {
        parentFactory.ApprovalStrategyFactory = new InnerApprovalTeamApprovalStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApprovalStrategyFactory);
    }

    public static CombinedResult<ApprovalTeamFactory, T1, InnerApprovalTeamPolicyFactory> WithPolicies<T1>(this CombinedResult<ApprovalTeamFactory, T1> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, InnerApprovalTeamPolicyFactory> WithPolicies<T1>(this CombinedResult<T1, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<ApprovalTeamFactory, T1, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, ApprovalTeamFactory, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2>(this CombinedResult<T1, T2, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, T3, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<ApprovalTeamFactory, T1, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, T3, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, ApprovalTeamFactory, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, T3, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, ApprovalTeamFactory, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalTeamFactory, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, T3, T4, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<ApprovalTeamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, T3, T4, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, ApprovalTeamFactory, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, T3, T4, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApprovalTeamFactory, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalTeamFactory, T4, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApprovalTeamFactory, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApprovalTeamFactory, InnerApprovalTeamPolicyFactory> WithPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicies(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, InnerApprovalTeamApproverFactory> WithApprovers<T1>(this CombinedResult<ApprovalTeamFactory, T1> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, InnerApprovalTeamApproverFactory> WithApprovers<T1>(this CombinedResult<T1, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2>(this CombinedResult<ApprovalTeamFactory, T1, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2>(this CombinedResult<T1, ApprovalTeamFactory, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2>(this CombinedResult<T1, T2, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, T3, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3>(this CombinedResult<ApprovalTeamFactory, T1, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, T3, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3>(this CombinedResult<T1, ApprovalTeamFactory, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, T3, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3>(this CombinedResult<T1, T2, ApprovalTeamFactory, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalTeamFactory, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, T3, T4, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3, T4>(this CombinedResult<ApprovalTeamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, T3, T4, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3, T4>(this CombinedResult<T1, ApprovalTeamFactory, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, T3, T4, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApprovalTeamFactory, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalTeamFactory, T4, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApprovalTeamFactory, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApprovalTeamFactory, InnerApprovalTeamApproverFactory> WithApprovers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.Approver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovers(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1>(this CombinedResult<ApprovalTeamFactory, T1> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1>(this CombinedResult<T1, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2>(this CombinedResult<ApprovalTeamFactory, T1, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2>(this CombinedResult<T1, ApprovalTeamFactory, T2> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2>(this CombinedResult<T1, T2, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, T3, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3>(this CombinedResult<ApprovalTeamFactory, T1, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, T3, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3>(this CombinedResult<T1, ApprovalTeamFactory, T2, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, T3, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3>(this CombinedResult<T1, T2, ApprovalTeamFactory, T3> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalTeamFactory, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApprovalTeamFactory, T1, T2, T3, T4, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3, T4>(this CombinedResult<ApprovalTeamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApprovalTeamFactory, T2, T3, T4, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3, T4>(this CombinedResult<T1, ApprovalTeamFactory, T2, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApprovalTeamFactory, T3, T4, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApprovalTeamFactory, T3, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApprovalTeamFactory, T4, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApprovalTeamFactory, T4> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApprovalTeamFactory, InnerApprovalTeamApprovalStrategyFactory> WithApprovalStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApprovalTeamFactory> combinedResult, Action<Humidifier.MPA.ApprovalTeamTypes.ApprovalStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApprovalStrategy(combinedResult.T5, subFactoryAction).T2);
}

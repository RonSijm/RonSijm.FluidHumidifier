// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicyNetworkAclCommonPolicyFactory(Action<Humidifier.FMS.PolicyTypes.NetworkAclCommonPolicy> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.NetworkAclCommonPolicy>
{

    internal InnerPolicyNetworkAclEntrySetFactory NetworkAclEntrySetFactory { get; set; }

    protected override Humidifier.FMS.PolicyTypes.NetworkAclCommonPolicy Create()
    {
        var networkAclCommonPolicyResult = CreateNetworkAclCommonPolicy();
        factoryAction?.Invoke(networkAclCommonPolicyResult);

        return networkAclCommonPolicyResult;
    }

    private Humidifier.FMS.PolicyTypes.NetworkAclCommonPolicy CreateNetworkAclCommonPolicy()
    {
        var networkAclCommonPolicyResult = new Humidifier.FMS.PolicyTypes.NetworkAclCommonPolicy();

        return networkAclCommonPolicyResult;
    }
    public override void CreateChildren(Humidifier.FMS.PolicyTypes.NetworkAclCommonPolicy result)
    {
        base.CreateChildren(result);

        result.NetworkAclEntrySet ??= NetworkAclEntrySetFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyNetworkAclCommonPolicyFactoryExtensions
{
    public static CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet(this InnerPolicyNetworkAclCommonPolicyFactory parentFactory, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null)
    {
        parentFactory.NetworkAclEntrySetFactory = new InnerPolicyNetworkAclEntrySetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkAclEntrySetFactory);
    }

    public static CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1>(this CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1>(this CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1, T2, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2>(this CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory, T2, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2>(this CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory, T2> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyNetworkAclCommonPolicyFactory, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2>(this CombinedResult<T1, T2, InnerPolicyNetworkAclCommonPolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1, T2, T3, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3>(this CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory, T2, T3, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3>(this CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory, T2, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyNetworkAclCommonPolicyFactory, T3, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyNetworkAclCommonPolicyFactory, T3> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyNetworkAclCommonPolicyFactory, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyNetworkAclCommonPolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1, T2, T3, T4, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3, T4>(this CombinedResult<InnerPolicyNetworkAclCommonPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory, T2, T3, T4, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyNetworkAclCommonPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPolicyNetworkAclCommonPolicyFactory, T3, T4, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyNetworkAclCommonPolicyFactory, T3, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPolicyNetworkAclCommonPolicyFactory, T4, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyNetworkAclCommonPolicyFactory, T4> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyNetworkAclCommonPolicyFactory, InnerPolicyNetworkAclEntrySetFactory> WithNetworkAclEntrySet<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyNetworkAclCommonPolicyFactory> combinedResult, Action<Humidifier.FMS.PolicyTypes.NetworkAclEntrySet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAclEntrySet(combinedResult.T5, subFactoryAction));
}

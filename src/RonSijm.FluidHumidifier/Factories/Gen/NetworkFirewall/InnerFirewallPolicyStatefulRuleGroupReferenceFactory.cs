// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyStatefulRuleGroupReferenceFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference>
{

    internal InnerFirewallPolicyStatefulRuleGroupOverrideFactory OverrideFactory { get; set; }

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference Create()
    {
        var statefulRuleGroupReferenceResult = CreateStatefulRuleGroupReference();
        factoryAction?.Invoke(statefulRuleGroupReferenceResult);

        return statefulRuleGroupReferenceResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference CreateStatefulRuleGroupReference()
    {
        var statefulRuleGroupReferenceResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference();

        return statefulRuleGroupReferenceResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference result)
    {
        base.CreateChildren(result);

        result.Override ??= OverrideFactory?.Build();
    }

} // End Of Class

public static class InnerFirewallPolicyStatefulRuleGroupReferenceFactoryExtensions
{
    public static CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride(this InnerFirewallPolicyStatefulRuleGroupReferenceFactory parentFactory, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null)
    {
        parentFactory.OverrideFactory = new InnerFirewallPolicyStatefulRuleGroupOverrideFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OverrideFactory);
    }

    public static CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1>(this CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverride(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1>(this CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverride(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1, T2, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2>(this CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T2, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2>(this CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2>(this CombinedResult<T1, T2, InnerFirewallPolicyStatefulRuleGroupReferenceFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1, T2, T3, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3>(this CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T2, T3, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3>(this CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T3, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3>(this CombinedResult<T1, T2, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulRuleGroupReferenceFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1, T2, T3, T4, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3, T4>(this CombinedResult<InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T2, T3, T4, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3, T4>(this CombinedResult<T1, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T3, T4, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T4, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyStatefulRuleGroupReferenceFactory, InnerFirewallPolicyStatefulRuleGroupOverrideFactory> WithOverride<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyStatefulRuleGroupReferenceFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverride(combinedResult.T5, subFactoryAction));
}

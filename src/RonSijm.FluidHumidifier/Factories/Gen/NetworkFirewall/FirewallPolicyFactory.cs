// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class FirewallPolicyFactory(string resourceName = null, Action<Humidifier.NetworkFirewall.FirewallPolicy> factoryAction = null) : ResourceFactory<Humidifier.NetworkFirewall.FirewallPolicy>(resourceName)
{

    internal InnerFirewallPolicyFirewallPolicyFactory FirewallPolicy_Factory { get; set; }

    protected override Humidifier.NetworkFirewall.FirewallPolicy Create()
    {
        var firewallPolicyResult = CreateFirewallPolicy();
        factoryAction?.Invoke(firewallPolicyResult);

        return firewallPolicyResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicy CreateFirewallPolicy()
    {
        var firewallPolicyResult = new Humidifier.NetworkFirewall.FirewallPolicy
        {
            GivenName = InputResourceName,
        };

        return firewallPolicyResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.FirewallPolicy result)
    {
        base.CreateChildren(result);

        result.FirewallPolicy_ ??= FirewallPolicy_Factory?.Build();
    }

} // End Of Class

public static class FirewallPolicyFactoryExtensions
{
    public static CombinedResult<FirewallPolicyFactory, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_(this FirewallPolicyFactory parentFactory, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null)
    {
        parentFactory.FirewallPolicy_Factory = new InnerFirewallPolicyFirewallPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FirewallPolicy_Factory);
    }

    public static CombinedResult<FirewallPolicyFactory, T1, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1>(this CombinedResult<FirewallPolicyFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallPolicyFactory, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1>(this CombinedResult<T1, FirewallPolicyFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FirewallPolicyFactory, T1, T2, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2>(this CombinedResult<FirewallPolicyFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallPolicyFactory, T2, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2>(this CombinedResult<T1, FirewallPolicyFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallPolicyFactory, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2>(this CombinedResult<T1, T2, FirewallPolicyFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FirewallPolicyFactory, T1, T2, T3, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3>(this CombinedResult<FirewallPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallPolicyFactory, T2, T3, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3>(this CombinedResult<T1, FirewallPolicyFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallPolicyFactory, T3, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3>(this CombinedResult<T1, T2, FirewallPolicyFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FirewallPolicyFactory, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3>(this CombinedResult<T1, T2, T3, FirewallPolicyFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FirewallPolicyFactory, T1, T2, T3, T4, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3, T4>(this CombinedResult<FirewallPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FirewallPolicyFactory, T2, T3, T4, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, FirewallPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FirewallPolicyFactory, T3, T4, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, T2, FirewallPolicyFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FirewallPolicyFactory, T4, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FirewallPolicyFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FirewallPolicyFactory, InnerFirewallPolicyFirewallPolicyFactory> WithFirewallPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FirewallPolicyFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirewallPolicy_(combinedResult.T5, subFactoryAction));
}

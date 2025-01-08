// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyStatefulEngineOptionsFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions>
{

    internal InnerFirewallPolicyFlowTimeoutsFactory FlowTimeoutsFactory { get; set; }

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions Create()
    {
        var statefulEngineOptionsResult = CreateStatefulEngineOptions();
        factoryAction?.Invoke(statefulEngineOptionsResult);

        return statefulEngineOptionsResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions CreateStatefulEngineOptions()
    {
        var statefulEngineOptionsResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions();

        return statefulEngineOptionsResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions result)
    {
        base.CreateChildren(result);

        result.FlowTimeouts ??= FlowTimeoutsFactory?.Build();
    }

} // End Of Class

public static class InnerFirewallPolicyStatefulEngineOptionsFactoryExtensions
{
    public static CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts(this InnerFirewallPolicyStatefulEngineOptionsFactory parentFactory, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null)
    {
        parentFactory.FlowTimeoutsFactory = new InnerFirewallPolicyFlowTimeoutsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FlowTimeoutsFactory);
    }

    public static CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1>(this CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1>(this CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1, T2, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2>(this CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory, T2, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2>(this CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyStatefulEngineOptionsFactory, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2>(this CombinedResult<T1, T2, InnerFirewallPolicyStatefulEngineOptionsFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1, T2, T3, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3>(this CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory, T2, T3, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3>(this CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyStatefulEngineOptionsFactory, T3, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3>(this CombinedResult<T1, T2, InnerFirewallPolicyStatefulEngineOptionsFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulEngineOptionsFactory, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulEngineOptionsFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1, T2, T3, T4, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3, T4>(this CombinedResult<InnerFirewallPolicyStatefulEngineOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory, T2, T3, T4, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3, T4>(this CombinedResult<T1, InnerFirewallPolicyStatefulEngineOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyStatefulEngineOptionsFactory, T3, T4, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFirewallPolicyStatefulEngineOptionsFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulEngineOptionsFactory, T4, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyStatefulEngineOptionsFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyStatefulEngineOptionsFactory, InnerFirewallPolicyFlowTimeoutsFactory> WithFlowTimeouts<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyStatefulEngineOptionsFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowTimeouts(combinedResult.T5, subFactoryAction));
}

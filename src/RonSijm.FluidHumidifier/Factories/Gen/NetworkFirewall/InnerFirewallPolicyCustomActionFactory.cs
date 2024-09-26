// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyCustomActionFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction>
{

    internal InnerFirewallPolicyActionDefinitionFactory ActionDefinitionFactory { get; set; }

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction Create()
    {
        var customActionResult = CreateCustomAction();
        factoryAction?.Invoke(customActionResult);

        return customActionResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction CreateCustomAction()
    {
        var customActionResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction();

        return customActionResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction result)
    {
        base.CreateChildren(result);

        result.ActionDefinition ??= ActionDefinitionFactory?.Build();
    }

} // End Of Class

public static class InnerFirewallPolicyCustomActionFactoryExtensions
{
    public static CombinedResult<InnerFirewallPolicyCustomActionFactory, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition(this InnerFirewallPolicyCustomActionFactory parentFactory, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null)
    {
        parentFactory.ActionDefinitionFactory = new InnerFirewallPolicyActionDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionDefinitionFactory);
    }

    public static CombinedResult<InnerFirewallPolicyCustomActionFactory, T1, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1>(this CombinedResult<InnerFirewallPolicyCustomActionFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyCustomActionFactory, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1>(this CombinedResult<T1, InnerFirewallPolicyCustomActionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyCustomActionFactory, T1, T2, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2>(this CombinedResult<InnerFirewallPolicyCustomActionFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyCustomActionFactory, T2, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2>(this CombinedResult<T1, InnerFirewallPolicyCustomActionFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyCustomActionFactory, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2>(this CombinedResult<T1, T2, InnerFirewallPolicyCustomActionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyCustomActionFactory, T1, T2, T3, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3>(this CombinedResult<InnerFirewallPolicyCustomActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyCustomActionFactory, T2, T3, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3>(this CombinedResult<T1, InnerFirewallPolicyCustomActionFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyCustomActionFactory, T3, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InnerFirewallPolicyCustomActionFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyCustomActionFactory, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyCustomActionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyCustomActionFactory, T1, T2, T3, T4, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3, T4>(this CombinedResult<InnerFirewallPolicyCustomActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyCustomActionFactory, T2, T3, T4, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InnerFirewallPolicyCustomActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyCustomActionFactory, T3, T4, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFirewallPolicyCustomActionFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyCustomActionFactory, T4, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyCustomActionFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyCustomActionFactory, InnerFirewallPolicyActionDefinitionFactory> WithActionDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyCustomActionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionDefinition(combinedResult.T5, subFactoryAction));
}

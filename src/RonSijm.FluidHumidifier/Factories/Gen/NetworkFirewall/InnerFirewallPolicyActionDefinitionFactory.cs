// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyActionDefinitionFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition>
{

    internal InnerFirewallPolicyPublishMetricActionFactory PublishMetricActionFactory { get; set; }

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition Create()
    {
        var actionDefinitionResult = CreateActionDefinition();
        factoryAction?.Invoke(actionDefinitionResult);

        return actionDefinitionResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition CreateActionDefinition()
    {
        var actionDefinitionResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition();

        return actionDefinitionResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition result)
    {
        base.CreateChildren(result);

        result.PublishMetricAction ??= PublishMetricActionFactory?.Build();
    }

} // End Of Class

public static class InnerFirewallPolicyActionDefinitionFactoryExtensions
{
    public static CombinedResult<InnerFirewallPolicyActionDefinitionFactory, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction(this InnerFirewallPolicyActionDefinitionFactory parentFactory, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null)
    {
        parentFactory.PublishMetricActionFactory = new InnerFirewallPolicyPublishMetricActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PublishMetricActionFactory);
    }

    public static CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1>(this CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1>(this CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1, T2, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2>(this CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory, T2, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2>(this CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyActionDefinitionFactory, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2>(this CombinedResult<T1, T2, InnerFirewallPolicyActionDefinitionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1, T2, T3, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3>(this CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory, T2, T3, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3>(this CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyActionDefinitionFactory, T3, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerFirewallPolicyActionDefinitionFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyActionDefinitionFactory, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyActionDefinitionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1, T2, T3, T4, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3, T4>(this CombinedResult<InnerFirewallPolicyActionDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory, T2, T3, T4, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerFirewallPolicyActionDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFirewallPolicyActionDefinitionFactory, T3, T4, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFirewallPolicyActionDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFirewallPolicyActionDefinitionFactory, T4, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFirewallPolicyActionDefinitionFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyActionDefinitionFactory, InnerFirewallPolicyPublishMetricActionFactory> WithPublishMetricAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFirewallPolicyActionDefinitionFactory> combinedResult, Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublishMetricAction(combinedResult.T5, subFactoryAction));
}

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerRuleGroupRulesSourceFactory(Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSource> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSource>
{

    internal InnerRuleGroupStatelessRulesAndCustomActionsFactory StatelessRulesAndCustomActionsFactory { get; set; }

    internal InnerRuleGroupRulesSourceListFactory RulesSourceListFactory { get; set; }

    protected override Humidifier.NetworkFirewall.RuleGroupTypes.RulesSource Create()
    {
        var rulesSourceResult = CreateRulesSource();
        factoryAction?.Invoke(rulesSourceResult);

        return rulesSourceResult;
    }

    private Humidifier.NetworkFirewall.RuleGroupTypes.RulesSource CreateRulesSource()
    {
        var rulesSourceResult = new Humidifier.NetworkFirewall.RuleGroupTypes.RulesSource();

        return rulesSourceResult;
    }
    public override void CreateChildren(Humidifier.NetworkFirewall.RuleGroupTypes.RulesSource result)
    {
        base.CreateChildren(result);

        result.StatelessRulesAndCustomActions ??= StatelessRulesAndCustomActionsFactory?.Build();
        result.RulesSourceList ??= RulesSourceListFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupRulesSourceFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions(this InnerRuleGroupRulesSourceFactory parentFactory, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null)
    {
        parentFactory.StatelessRulesAndCustomActionsFactory = new InnerRuleGroupStatelessRulesAndCustomActionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatelessRulesAndCustomActionsFactory);
    }

    public static CombinedResult<InnerRuleGroupRulesSourceFactory, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList(this InnerRuleGroupRulesSourceFactory parentFactory, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null)
    {
        parentFactory.RulesSourceListFactory = new InnerRuleGroupRulesSourceListFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RulesSourceListFactory);
    }

    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3, T4, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3, T4, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3, T4, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory, T4, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupRulesSourceFactory, InnerRuleGroupStatelessRulesAndCustomActionsFactory> WithStatelessRulesAndCustomActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatelessRulesAndCustomActions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, WithRulesSourceList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, WithRulesSourceList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3, T4, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupRulesSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3, T4, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupRulesSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3, T4, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupRulesSourceFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory, T4, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupRulesSourceFactory, T4> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupRulesSourceFactory, InnerRuleGroupRulesSourceListFactory> WithRulesSourceList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupRulesSourceFactory> combinedResult, Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRulesSourceList(combinedResult.T5, subFactoryAction));
}

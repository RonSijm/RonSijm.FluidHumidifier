// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class RuleFactory(string resourceName = null, Action<Humidifier.VpcLattice.Rule> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.Rule>(resourceName)
{

    internal InnerRuleActionFactory ActionFactory { get; set; }

    internal InnerRuleMatchFactory MatchFactory { get; set; }

    protected override Humidifier.VpcLattice.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.VpcLattice.Rule CreateRule()
    {
        var ruleResult = new Humidifier.VpcLattice.Rule
        {
            GivenName = InputResourceName,
        };

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.Rule result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
        result.Match ??= MatchFactory?.Build();
    }

} // End Of Class

public static class RuleFactoryExtensions
{
    public static CombinedResult<RuleFactory, InnerRuleActionFactory> WithAction(this RuleFactory parentFactory, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerRuleActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<RuleFactory, InnerRuleMatchFactory> WithMatch(this RuleFactory parentFactory, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null)
    {
        parentFactory.MatchFactory = new InnerRuleMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchFactory);
    }

    public static CombinedResult<RuleFactory, T1, InnerRuleActionFactory> WithAction<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleActionFactory> WithAction<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleActionFactory> WithAction<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleActionFactory> WithAction<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, InnerRuleMatchFactory> WithMatch<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleMatchFactory> WithMatch<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleMatchFactory> WithMatch<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.Match> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T5, subFactoryAction));
}

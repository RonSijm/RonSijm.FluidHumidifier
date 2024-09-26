// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerRulePathMatchFactory(Action<Humidifier.VpcLattice.RuleTypes.PathMatch> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.RuleTypes.PathMatch>
{

    internal InnerRulePathMatchTypeFactory MatchFactory { get; set; }

    protected override Humidifier.VpcLattice.RuleTypes.PathMatch Create()
    {
        var pathMatchResult = CreatePathMatch();
        factoryAction?.Invoke(pathMatchResult);

        return pathMatchResult;
    }

    private Humidifier.VpcLattice.RuleTypes.PathMatch CreatePathMatch()
    {
        var pathMatchResult = new Humidifier.VpcLattice.RuleTypes.PathMatch();

        return pathMatchResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.RuleTypes.PathMatch result)
    {
        base.CreateChildren(result);

        result.Match ??= MatchFactory?.Build();
    }

} // End Of Class

public static class InnerRulePathMatchFactoryExtensions
{
    public static CombinedResult<InnerRulePathMatchFactory, InnerRulePathMatchTypeFactory> WithMatch(this InnerRulePathMatchFactory parentFactory, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null)
    {
        parentFactory.MatchFactory = new InnerRulePathMatchTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchFactory);
    }

    public static CombinedResult<InnerRulePathMatchFactory, T1, InnerRulePathMatchTypeFactory> WithMatch<T1>(this CombinedResult<InnerRulePathMatchFactory, T1> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulePathMatchFactory, InnerRulePathMatchTypeFactory> WithMatch<T1>(this CombinedResult<T1, InnerRulePathMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRulePathMatchFactory, T1, T2, InnerRulePathMatchTypeFactory> WithMatch<T1, T2>(this CombinedResult<InnerRulePathMatchFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulePathMatchFactory, T2, InnerRulePathMatchTypeFactory> WithMatch<T1, T2>(this CombinedResult<T1, InnerRulePathMatchFactory, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRulePathMatchFactory, InnerRulePathMatchTypeFactory> WithMatch<T1, T2>(this CombinedResult<T1, T2, InnerRulePathMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRulePathMatchFactory, T1, T2, T3, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3>(this CombinedResult<InnerRulePathMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulePathMatchFactory, T2, T3, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, InnerRulePathMatchFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRulePathMatchFactory, T3, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRulePathMatchFactory, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRulePathMatchFactory, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRulePathMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRulePathMatchFactory, T1, T2, T3, T4, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<InnerRulePathMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRulePathMatchFactory, T2, T3, T4, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRulePathMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRulePathMatchFactory, T3, T4, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRulePathMatchFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRulePathMatchFactory, T4, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRulePathMatchFactory, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRulePathMatchFactory, InnerRulePathMatchTypeFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRulePathMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T5, subFactoryAction));
}

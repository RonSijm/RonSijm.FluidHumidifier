// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerRuleMatchFactory(Action<Humidifier.VpcLattice.RuleTypes.Match> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.RuleTypes.Match>
{

    internal InnerRuleHttpMatchFactory HttpMatchFactory { get; set; }

    protected override Humidifier.VpcLattice.RuleTypes.Match Create()
    {
        var matchResult = CreateMatch();
        factoryAction?.Invoke(matchResult);

        return matchResult;
    }

    private Humidifier.VpcLattice.RuleTypes.Match CreateMatch()
    {
        var matchResult = new Humidifier.VpcLattice.RuleTypes.Match();

        return matchResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.RuleTypes.Match result)
    {
        base.CreateChildren(result);

        result.HttpMatch ??= HttpMatchFactory?.Build();
    }

} // End Of Class

public static class InnerRuleMatchFactoryExtensions
{
    public static CombinedResult<InnerRuleMatchFactory, InnerRuleHttpMatchFactory> WithHttpMatch(this InnerRuleMatchFactory parentFactory, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null)
    {
        parentFactory.HttpMatchFactory = new InnerRuleHttpMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HttpMatchFactory);
    }

    public static CombinedResult<InnerRuleMatchFactory, T1, InnerRuleHttpMatchFactory> WithHttpMatch<T1>(this CombinedResult<InnerRuleMatchFactory, T1> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleMatchFactory, InnerRuleHttpMatchFactory> WithHttpMatch<T1>(this CombinedResult<T1, InnerRuleMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleMatchFactory, T1, T2, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2>(this CombinedResult<InnerRuleMatchFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleMatchFactory, T2, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2>(this CombinedResult<T1, InnerRuleMatchFactory, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleMatchFactory, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2>(this CombinedResult<T1, T2, InnerRuleMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleMatchFactory, T1, T2, T3, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3>(this CombinedResult<InnerRuleMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleMatchFactory, T2, T3, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3>(this CombinedResult<T1, InnerRuleMatchFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleMatchFactory, T3, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleMatchFactory, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleMatchFactory, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleMatchFactory, T1, T2, T3, T4, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3, T4>(this CombinedResult<InnerRuleMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleMatchFactory, T2, T3, T4, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleMatchFactory, T3, T4, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleMatchFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleMatchFactory, T4, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleMatchFactory, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleMatchFactory, InnerRuleHttpMatchFactory> WithHttpMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpMatch(combinedResult.T5, subFactoryAction));
}

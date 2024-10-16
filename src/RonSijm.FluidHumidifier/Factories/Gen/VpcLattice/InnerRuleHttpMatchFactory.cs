// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerRuleHttpMatchFactory(Action<Humidifier.VpcLattice.RuleTypes.HttpMatch> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.RuleTypes.HttpMatch>
{

    internal InnerRulePathMatchFactory PathMatchFactory { get; set; }

    protected override Humidifier.VpcLattice.RuleTypes.HttpMatch Create()
    {
        var httpMatchResult = CreateHttpMatch();
        factoryAction?.Invoke(httpMatchResult);

        return httpMatchResult;
    }

    private Humidifier.VpcLattice.RuleTypes.HttpMatch CreateHttpMatch()
    {
        var httpMatchResult = new Humidifier.VpcLattice.RuleTypes.HttpMatch();

        return httpMatchResult;
    }
    public override void CreateChildren(Humidifier.VpcLattice.RuleTypes.HttpMatch result)
    {
        base.CreateChildren(result);

        result.PathMatch ??= PathMatchFactory?.Build();
    }

} // End Of Class

public static class InnerRuleHttpMatchFactoryExtensions
{
    public static CombinedResult<InnerRuleHttpMatchFactory, InnerRulePathMatchFactory> WithPathMatch(this InnerRuleHttpMatchFactory parentFactory, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null)
    {
        parentFactory.PathMatchFactory = new InnerRulePathMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PathMatchFactory);
    }

    public static CombinedResult<InnerRuleHttpMatchFactory, T1, InnerRulePathMatchFactory> WithPathMatch<T1>(this CombinedResult<InnerRuleHttpMatchFactory, T1> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPathMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleHttpMatchFactory, InnerRulePathMatchFactory> WithPathMatch<T1>(this CombinedResult<T1, InnerRuleHttpMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithPathMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleHttpMatchFactory, T1, T2, InnerRulePathMatchFactory> WithPathMatch<T1, T2>(this CombinedResult<InnerRuleHttpMatchFactory, T1, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleHttpMatchFactory, T2, InnerRulePathMatchFactory> WithPathMatch<T1, T2>(this CombinedResult<T1, InnerRuleHttpMatchFactory, T2> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleHttpMatchFactory, InnerRulePathMatchFactory> WithPathMatch<T1, T2>(this CombinedResult<T1, T2, InnerRuleHttpMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleHttpMatchFactory, T1, T2, T3, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3>(this CombinedResult<InnerRuleHttpMatchFactory, T1, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleHttpMatchFactory, T2, T3, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3>(this CombinedResult<T1, InnerRuleHttpMatchFactory, T2, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleHttpMatchFactory, T3, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleHttpMatchFactory, T3> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleHttpMatchFactory, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleHttpMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleHttpMatchFactory, T1, T2, T3, T4, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3, T4>(this CombinedResult<InnerRuleHttpMatchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleHttpMatchFactory, T2, T3, T4, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleHttpMatchFactory, T2, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleHttpMatchFactory, T3, T4, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleHttpMatchFactory, T3, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleHttpMatchFactory, T4, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleHttpMatchFactory, T4> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleHttpMatchFactory, InnerRulePathMatchFactory> WithPathMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleHttpMatchFactory> combinedResult, Action<Humidifier.VpcLattice.RuleTypes.PathMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPathMatch(combinedResult.T5, subFactoryAction));
}

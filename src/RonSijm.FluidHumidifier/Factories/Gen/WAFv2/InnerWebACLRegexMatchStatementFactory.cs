// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLRegexMatchStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.RegexMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.RegexMatchStatement>
{

    internal InnerWebACLFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.RegexMatchStatement Create()
    {
        var regexMatchStatementResult = CreateRegexMatchStatement();
        factoryAction?.Invoke(regexMatchStatementResult);

        return regexMatchStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.RegexMatchStatement CreateRegexMatchStatement()
    {
        var regexMatchStatementResult = new Humidifier.WAFv2.WebACLTypes.RegexMatchStatement();

        return regexMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.RegexMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLRegexMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLRegexMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch(this InnerWebACLRegexMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerWebACLFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerWebACLRegexMatchStatementFactory, T1, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerWebACLRegexMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRegexMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerWebACLRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRegexMatchStatementFactory, T1, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerWebACLRegexMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRegexMatchStatementFactory, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerWebACLRegexMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRegexMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRegexMatchStatementFactory, T1, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerWebACLRegexMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRegexMatchStatementFactory, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRegexMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRegexMatchStatementFactory, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRegexMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRegexMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRegexMatchStatementFactory, T1, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRegexMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRegexMatchStatementFactory, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRegexMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRegexMatchStatementFactory, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRegexMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRegexMatchStatementFactory, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRegexMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRegexMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}

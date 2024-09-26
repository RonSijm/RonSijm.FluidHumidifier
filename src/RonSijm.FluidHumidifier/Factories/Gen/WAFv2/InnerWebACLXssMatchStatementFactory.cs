// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLXssMatchStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.XssMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.XssMatchStatement>
{

    internal InnerWebACLFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.XssMatchStatement Create()
    {
        var xssMatchStatementResult = CreateXssMatchStatement();
        factoryAction?.Invoke(xssMatchStatementResult);

        return xssMatchStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.XssMatchStatement CreateXssMatchStatement()
    {
        var xssMatchStatementResult = new Humidifier.WAFv2.WebACLTypes.XssMatchStatement();

        return xssMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.XssMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLXssMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLXssMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch(this InnerWebACLXssMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerWebACLFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerWebACLXssMatchStatementFactory, T1, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerWebACLXssMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLXssMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerWebACLXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLXssMatchStatementFactory, T1, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerWebACLXssMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLXssMatchStatementFactory, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerWebACLXssMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLXssMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerWebACLXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLXssMatchStatementFactory, T1, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerWebACLXssMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLXssMatchStatementFactory, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerWebACLXssMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLXssMatchStatementFactory, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLXssMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLXssMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLXssMatchStatementFactory, T1, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerWebACLXssMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLXssMatchStatementFactory, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLXssMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLXssMatchStatementFactory, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLXssMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLXssMatchStatementFactory, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLXssMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLXssMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}

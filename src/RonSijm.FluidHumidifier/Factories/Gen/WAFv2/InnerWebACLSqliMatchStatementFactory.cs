// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLSqliMatchStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.SqliMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.SqliMatchStatement>
{

    internal InnerWebACLFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.SqliMatchStatement Create()
    {
        var sqliMatchStatementResult = CreateSqliMatchStatement();
        factoryAction?.Invoke(sqliMatchStatementResult);

        return sqliMatchStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.SqliMatchStatement CreateSqliMatchStatement()
    {
        var sqliMatchStatementResult = new Humidifier.WAFv2.WebACLTypes.SqliMatchStatement();

        return sqliMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.SqliMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLSqliMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLSqliMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch(this InnerWebACLSqliMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerWebACLFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerWebACLSqliMatchStatementFactory, T1, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerWebACLSqliMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSqliMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerWebACLSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLSqliMatchStatementFactory, T1, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerWebACLSqliMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSqliMatchStatementFactory, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerWebACLSqliMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLSqliMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerWebACLSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLSqliMatchStatementFactory, T1, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerWebACLSqliMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSqliMatchStatementFactory, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerWebACLSqliMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLSqliMatchStatementFactory, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLSqliMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLSqliMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLSqliMatchStatementFactory, T1, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerWebACLSqliMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSqliMatchStatementFactory, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLSqliMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLSqliMatchStatementFactory, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLSqliMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLSqliMatchStatementFactory, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLSqliMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLSqliMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}

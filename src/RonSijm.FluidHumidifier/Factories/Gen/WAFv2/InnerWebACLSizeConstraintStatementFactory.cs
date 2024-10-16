// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLSizeConstraintStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.SizeConstraintStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.SizeConstraintStatement>
{

    internal InnerWebACLFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.SizeConstraintStatement Create()
    {
        var sizeConstraintStatementResult = CreateSizeConstraintStatement();
        factoryAction?.Invoke(sizeConstraintStatementResult);

        return sizeConstraintStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.SizeConstraintStatement CreateSizeConstraintStatement()
    {
        var sizeConstraintStatementResult = new Humidifier.WAFv2.WebACLTypes.SizeConstraintStatement();

        return sizeConstraintStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.SizeConstraintStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLSizeConstraintStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLSizeConstraintStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch(this InnerWebACLSizeConstraintStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerWebACLFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLSizeConstraintStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerWebACLSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLSizeConstraintStatementFactory, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLSizeConstraintStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLSizeConstraintStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerWebACLSizeConstraintStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLSizeConstraintStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLSizeConstraintStatementFactory, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLSizeConstraintStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLSizeConstraintStatementFactory, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLSizeConstraintStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLSizeConstraintStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}

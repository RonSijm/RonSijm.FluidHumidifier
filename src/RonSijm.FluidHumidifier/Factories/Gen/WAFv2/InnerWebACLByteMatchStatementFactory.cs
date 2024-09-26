// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLByteMatchStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.ByteMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.ByteMatchStatement>
{

    internal InnerWebACLFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.ByteMatchStatement Create()
    {
        var byteMatchStatementResult = CreateByteMatchStatement();
        factoryAction?.Invoke(byteMatchStatementResult);

        return byteMatchStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.ByteMatchStatement CreateByteMatchStatement()
    {
        var byteMatchStatementResult = new Humidifier.WAFv2.WebACLTypes.ByteMatchStatement();

        return byteMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.ByteMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLByteMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLByteMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch(this InnerWebACLByteMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerWebACLFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerWebACLByteMatchStatementFactory, T1, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerWebACLByteMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLByteMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerWebACLByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLByteMatchStatementFactory, T1, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerWebACLByteMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLByteMatchStatementFactory, T2, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerWebACLByteMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLByteMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerWebACLByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLByteMatchStatementFactory, T1, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerWebACLByteMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLByteMatchStatementFactory, T2, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerWebACLByteMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLByteMatchStatementFactory, T3, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLByteMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLByteMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLByteMatchStatementFactory, T1, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerWebACLByteMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLByteMatchStatementFactory, T2, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLByteMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLByteMatchStatementFactory, T3, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLByteMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLByteMatchStatementFactory, T4, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLByteMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLByteMatchStatementFactory, InnerWebACLFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}

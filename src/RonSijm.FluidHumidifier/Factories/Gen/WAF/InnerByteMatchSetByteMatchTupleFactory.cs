// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerByteMatchSetByteMatchTupleFactory(Action<Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple> factoryAction = null) : SubResourceFactory<Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple>
{

    internal InnerByteMatchSetFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple Create()
    {
        var byteMatchTupleResult = CreateByteMatchTuple();
        factoryAction?.Invoke(byteMatchTupleResult);

        return byteMatchTupleResult;
    }

    private Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple CreateByteMatchTuple()
    {
        var byteMatchTupleResult = new Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple();

        return byteMatchTupleResult;
    }
    public override void CreateChildren(Humidifier.WAF.ByteMatchSetTypes.ByteMatchTuple result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerByteMatchSetByteMatchTupleFactoryExtensions
{
    public static CombinedResult<InnerByteMatchSetByteMatchTupleFactory, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch(this InnerByteMatchSetByteMatchTupleFactory parentFactory, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerByteMatchSetFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1, T2, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1, T2> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory, T2, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory, T2> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerByteMatchSetByteMatchTupleFactory, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerByteMatchSetByteMatchTupleFactory> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1, T2, T3, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory, T2, T3, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory, T2, T3> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerByteMatchSetByteMatchTupleFactory, T3, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerByteMatchSetByteMatchTupleFactory, T3> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerByteMatchSetByteMatchTupleFactory, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerByteMatchSetByteMatchTupleFactory> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1, T2, T3, T4, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerByteMatchSetByteMatchTupleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory, T2, T3, T4, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerByteMatchSetByteMatchTupleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerByteMatchSetByteMatchTupleFactory, T3, T4, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerByteMatchSetByteMatchTupleFactory, T3, T4> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerByteMatchSetByteMatchTupleFactory, T4, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerByteMatchSetByteMatchTupleFactory, T4> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerByteMatchSetByteMatchTupleFactory, InnerByteMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerByteMatchSetByteMatchTupleFactory> combinedResult, Action<Humidifier.WAF.ByteMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}

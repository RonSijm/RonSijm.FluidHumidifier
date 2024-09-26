// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class ByteMatchSetFactory(string resourceName = null, Action<Humidifier.WAFRegional.ByteMatchSet> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.ByteMatchSet>(resourceName)
{

    internal List<InnerByteMatchSetByteMatchTupleFactory> ByteMatchTuplesFactories { get; set; } = [];

    protected override Humidifier.WAFRegional.ByteMatchSet Create()
    {
        var byteMatchSetResult = CreateByteMatchSet();
        factoryAction?.Invoke(byteMatchSetResult);

        return byteMatchSetResult;
    }

    private Humidifier.WAFRegional.ByteMatchSet CreateByteMatchSet()
    {
        var byteMatchSetResult = new Humidifier.WAFRegional.ByteMatchSet
        {
            GivenName = InputResourceName,
        };

        return byteMatchSetResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.ByteMatchSet result)
    {
        base.CreateChildren(result);

        result.ByteMatchTuples = ByteMatchTuplesFactories.Any() ? ByteMatchTuplesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ByteMatchSetFactoryExtensions
{
    public static CombinedResult<ByteMatchSetFactory, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples(this ByteMatchSetFactory parentFactory, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null)
    {
        var factory = new InnerByteMatchSetByteMatchTupleFactory(subFactoryAction);
        parentFactory.ByteMatchTuplesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ByteMatchSetFactory, T1, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1>(this CombinedResult<ByteMatchSetFactory, T1> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ByteMatchSetFactory, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1>(this CombinedResult<T1, ByteMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ByteMatchSetFactory, T1, T2, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2>(this CombinedResult<ByteMatchSetFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ByteMatchSetFactory, T2, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2>(this CombinedResult<T1, ByteMatchSetFactory, T2> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ByteMatchSetFactory, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2>(this CombinedResult<T1, T2, ByteMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ByteMatchSetFactory, T1, T2, T3, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3>(this CombinedResult<ByteMatchSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ByteMatchSetFactory, T2, T3, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3>(this CombinedResult<T1, ByteMatchSetFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ByteMatchSetFactory, T3, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3>(this CombinedResult<T1, T2, ByteMatchSetFactory, T3> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ByteMatchSetFactory, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3>(this CombinedResult<T1, T2, T3, ByteMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ByteMatchSetFactory, T1, T2, T3, T4, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3, T4>(this CombinedResult<ByteMatchSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ByteMatchSetFactory, T2, T3, T4, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, ByteMatchSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ByteMatchSetFactory, T3, T4, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, ByteMatchSetFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ByteMatchSetFactory, T4, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ByteMatchSetFactory, T4> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ByteMatchSetFactory, InnerByteMatchSetByteMatchTupleFactory> WithByteMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ByteMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.ByteMatchSetTypes.ByteMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithByteMatchTuples(combinedResult.T5, subFactoryAction));
}

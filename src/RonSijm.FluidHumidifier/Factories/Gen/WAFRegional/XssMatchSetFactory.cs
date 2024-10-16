// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class XssMatchSetFactory(string resourceName = null, Action<Humidifier.WAFRegional.XssMatchSet> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.XssMatchSet>(resourceName)
{

    internal List<InnerXssMatchSetXssMatchTupleFactory> XssMatchTuplesFactories { get; set; } = [];

    protected override Humidifier.WAFRegional.XssMatchSet Create()
    {
        var xssMatchSetResult = CreateXssMatchSet();
        factoryAction?.Invoke(xssMatchSetResult);

        return xssMatchSetResult;
    }

    private Humidifier.WAFRegional.XssMatchSet CreateXssMatchSet()
    {
        var xssMatchSetResult = new Humidifier.WAFRegional.XssMatchSet
        {
            GivenName = InputResourceName,
        };

        return xssMatchSetResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.XssMatchSet result)
    {
        base.CreateChildren(result);

        result.XssMatchTuples = XssMatchTuplesFactories.Any() ? XssMatchTuplesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class XssMatchSetFactoryExtensions
{
    public static CombinedResult<XssMatchSetFactory, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples(this XssMatchSetFactory parentFactory, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null)
    {
        var factory = new InnerXssMatchSetXssMatchTupleFactory(subFactoryAction);
        parentFactory.XssMatchTuplesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<XssMatchSetFactory, T1, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1>(this CombinedResult<XssMatchSetFactory, T1> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, XssMatchSetFactory, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1>(this CombinedResult<T1, XssMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<XssMatchSetFactory, T1, T2, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2>(this CombinedResult<XssMatchSetFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, XssMatchSetFactory, T2, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2>(this CombinedResult<T1, XssMatchSetFactory, T2> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, XssMatchSetFactory, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2>(this CombinedResult<T1, T2, XssMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<XssMatchSetFactory, T1, T2, T3, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3>(this CombinedResult<XssMatchSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, XssMatchSetFactory, T2, T3, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3>(this CombinedResult<T1, XssMatchSetFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, XssMatchSetFactory, T3, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3>(this CombinedResult<T1, T2, XssMatchSetFactory, T3> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, XssMatchSetFactory, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3>(this CombinedResult<T1, T2, T3, XssMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T4, subFactoryAction));
    public static CombinedResult<XssMatchSetFactory, T1, T2, T3, T4, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3, T4>(this CombinedResult<XssMatchSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, XssMatchSetFactory, T2, T3, T4, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, XssMatchSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, XssMatchSetFactory, T3, T4, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, XssMatchSetFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, XssMatchSetFactory, T4, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, XssMatchSetFactory, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, XssMatchSetFactory, InnerXssMatchSetXssMatchTupleFactory> WithXssMatchTuples<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, XssMatchSetFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithXssMatchTuples(combinedResult.T5, subFactoryAction));
}

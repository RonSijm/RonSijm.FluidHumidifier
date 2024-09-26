// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerXssMatchSetXssMatchTupleFactory(Action<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple>
{

    internal InnerXssMatchSetFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple Create()
    {
        var xssMatchTupleResult = CreateXssMatchTuple();
        factoryAction?.Invoke(xssMatchTupleResult);

        return xssMatchTupleResult;
    }

    private Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple CreateXssMatchTuple()
    {
        var xssMatchTupleResult = new Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple();

        return xssMatchTupleResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.XssMatchSetTypes.XssMatchTuple result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerXssMatchSetXssMatchTupleFactoryExtensions
{
    public static CombinedResult<InnerXssMatchSetXssMatchTupleFactory, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch(this InnerXssMatchSetXssMatchTupleFactory parentFactory, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerXssMatchSetFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1, T2, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory, T2, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory, T2> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerXssMatchSetXssMatchTupleFactory, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerXssMatchSetXssMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1, T2, T3, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory, T2, T3, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerXssMatchSetXssMatchTupleFactory, T3, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerXssMatchSetXssMatchTupleFactory, T3> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerXssMatchSetXssMatchTupleFactory, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerXssMatchSetXssMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1, T2, T3, T4, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerXssMatchSetXssMatchTupleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory, T2, T3, T4, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerXssMatchSetXssMatchTupleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerXssMatchSetXssMatchTupleFactory, T3, T4, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerXssMatchSetXssMatchTupleFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerXssMatchSetXssMatchTupleFactory, T4, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerXssMatchSetXssMatchTupleFactory, T4> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerXssMatchSetXssMatchTupleFactory, InnerXssMatchSetFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerXssMatchSetXssMatchTupleFactory> combinedResult, Action<Humidifier.WAFRegional.XssMatchSetTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
